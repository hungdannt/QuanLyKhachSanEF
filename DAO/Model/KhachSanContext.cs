namespace DAO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DAO.Model;

    public partial class KhachSanContext : DbContext
    {
        public KhachSanContext()
            : base("name=KhachSanPro")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<PhieuDichVu> PhieuDichVus { get; set; }
        public virtual DbSet<PhieuThuePhong> PhieuThuePhongs { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<User> Users { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<DichVu>()
        //        .Property(e => e.maDichVu)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<DichVu>()
        //        .HasMany(e => e.PhieuDichVus)
        //        .WithRequired(e => e.DichVu)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<HoaDon>()
        //        .Property(e => e.maHoaDon)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<KhachHang>()
        //        .Property(e => e.sdt)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<KhachHang>()
        //        .HasMany(e => e.HoaDons)
        //        .WithRequired(e => e.KhachHang)
        //        .HasForeignKey(e => e.cmndKhachHang)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<KhachHang>()
        //        .HasMany(e => e.PhieuThuePhongs)
        //        .WithRequired(e => e.KhachHang)
        //        .HasForeignKey(e => e.cmndKhachHang)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<PhieuDichVu>()
        //        .Property(e => e.maPhieuDichVu)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PhieuDichVu>()
        //        .Property(e => e.maPhieuThuePhong)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PhieuDichVu>()
        //        .Property(e => e.maDichVu)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PhieuThuePhong>()
        //        .Property(e => e.maPhieuThuePhong)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PhieuThuePhong>()
        //        .Property(e => e.maPhong)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PhieuThuePhong>()
        //        .HasMany(e => e.PhieuDichVus)
        //        .WithRequired(e => e.PhieuThuePhong)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Phong>()
        //        .Property(e => e.maPhong)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Phong>()
        //        .Property(e => e.soNguoiToiDa)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Phong>()
        //        .HasMany(e => e.PhieuThuePhongs)
        //        .WithRequired(e => e.Phong)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<User>()
        //        .Property(e => e.sdt)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<User>()
        //        .HasMany(e => e.Accounts)
        //        .WithOptional(e => e.User)
        //        .HasForeignKey(e => e.cmnd);
        //}
    }
}
