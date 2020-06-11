namespace DAO.Migrations
{
    using DAO.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAO.KhachSanContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAO.KhachSanContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Users.AddOrUpdate(p => p.CMND, new User()
            {
                CMND = 187859120,
                HoTen = "Dân Dẻo Dai",
                GioiTinh = true,
                DiaChi = "86 Nguyễn Sinh Sắc",
                SDT = "0922024223",
                NgaySinh = new DateTime(2000,07,21)
            });
            context.Accounts.AddOrUpdate(p => p.STT, new Account()
            {
                CMND = 187859120,
                STT = 1,
                TenDangNhap = "admin",
                MatKhau = "86 Nguyễn Sinh Sắc",
                ChucVu = "Admin"
            });
        }
    }
}
