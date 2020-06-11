namespace DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intital : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        STT = c.Int(nullable: false),
                        CMND = c.Int(nullable: false),
                        TenDangNhap = c.String(maxLength: 50),
                        MatKhau = c.String(maxLength: 50),
                        ChucVu = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.STT)
                .ForeignKey("dbo.User", t => t.CMND, cascadeDelete: true)
                .Index(t => t.CMND);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        CMND = c.Int(nullable: false),
                        HoTen = c.String(maxLength: 50),
                        NgaySinh = c.DateTime(nullable: false, storeType: "date"),
                        GioiTinh = c.Boolean(nullable: false),
                        SDT = c.String(maxLength: 10),
                        DiaChi = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.CMND);
            
            CreateTable(
                "dbo.DichVu",
                c => new
                    {
                        MaDichVu = c.Int(nullable: false),
                        TenDichVu = c.String(maxLength: 20),
                        DonGia = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.MaDichVu);
            
            CreateTable(
                "dbo.PhieuDichVu",
                c => new
                    {
                        MaPhieuDichVu = c.String(nullable: false, maxLength: 10),
                        MaPhieuThuePhong = c.String(maxLength: 10),
                        MaDichVu = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhieuDichVu)
                .ForeignKey("dbo.DichVu", t => t.MaDichVu, cascadeDelete: true)
                .ForeignKey("dbo.PhieuThuePhong", t => t.MaPhieuThuePhong)
                .Index(t => t.MaPhieuThuePhong)
                .Index(t => t.MaDichVu);
            
            CreateTable(
                "dbo.PhieuThuePhong",
                c => new
                    {
                        MaPhieuThuePhong = c.String(nullable: false, maxLength: 10),
                        CMNDKhachHang = c.Int(nullable: false),
                        MaPhong = c.Int(nullable: false),
                        NgayThue = c.DateTime(nullable: false, storeType: "date"),
                        NgayTra = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.MaPhieuThuePhong)
                .ForeignKey("dbo.KhachHang", t => t.CMNDKhachHang, cascadeDelete: true)
                .ForeignKey("dbo.Phong", t => t.MaPhong, cascadeDelete: true)
                .Index(t => t.CMNDKhachHang)
                .Index(t => t.MaPhong);
            
            CreateTable(
                "dbo.KhachHang",
                c => new
                    {
                        CMND = c.Int(nullable: false),
                        HoTen = c.String(maxLength: 50),
                        NgaySinh = c.DateTime(nullable: false, storeType: "date"),
                        GioiTinh = c.Boolean(nullable: false),
                        SDT = c.String(maxLength: 10),
                        DiaChi = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.CMND);
            
            CreateTable(
                "dbo.HoaDon",
                c => new
                    {
                        MaHoaDon = c.String(nullable: false, maxLength: 10),
                        CMNDKhachHang = c.Int(nullable: false),
                        Tien = c.Single(nullable: false),
                        NgayXuat = c.DateTime(nullable: false, storeType: "date"),
                        HinhThucThanhToan = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaHoaDon)
                .ForeignKey("dbo.KhachHang", t => t.CMNDKhachHang, cascadeDelete: true)
                .Index(t => t.CMNDKhachHang);
            
            CreateTable(
                "dbo.Phong",
                c => new
                    {
                        MaPhong = c.Int(nullable: false),
                        LoaiPhong = c.String(maxLength: 10),
                        DonGia = c.Single(nullable: false),
                        SoNguoiToiDa = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhong);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhieuThuePhong", "MaPhong", "dbo.Phong");
            DropForeignKey("dbo.PhieuDichVu", "MaPhieuThuePhong", "dbo.PhieuThuePhong");
            DropForeignKey("dbo.PhieuThuePhong", "CMNDKhachHang", "dbo.KhachHang");
            DropForeignKey("dbo.HoaDon", "CMNDKhachHang", "dbo.KhachHang");
            DropForeignKey("dbo.PhieuDichVu", "MaDichVu", "dbo.DichVu");
            DropForeignKey("dbo.Account", "CMND", "dbo.User");
            DropIndex("dbo.HoaDon", new[] { "CMNDKhachHang" });
            DropIndex("dbo.PhieuThuePhong", new[] { "MaPhong" });
            DropIndex("dbo.PhieuThuePhong", new[] { "CMNDKhachHang" });
            DropIndex("dbo.PhieuDichVu", new[] { "MaDichVu" });
            DropIndex("dbo.PhieuDichVu", new[] { "MaPhieuThuePhong" });
            DropIndex("dbo.Account", new[] { "CMND" });
            DropTable("dbo.Phong");
            DropTable("dbo.HoaDon");
            DropTable("dbo.KhachHang");
            DropTable("dbo.PhieuThuePhong");
            DropTable("dbo.PhieuDichVu");
            DropTable("dbo.DichVu");
            DropTable("dbo.User");
            DropTable("dbo.Account");
        }
    }
}
