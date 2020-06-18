using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace QL_KhachSan
{
    public class CreateDB : CreateDatabaseIfNotExists<KhachSanContext>
    {
        protected override void Seed(KhachSanContext context)
        {
            context.KhachHangs.Add(new KhachHang
            {
                CMND = 187859120,
                GioiTinh = true,
                HoTen = "Tran Van A",
                NgaySinh = new DateTime(),
                DiaChi = "86 Nguyen Sinh Sac",
                SDT = "0978374738"
            });

            context.Users.Add(new User
            {
                CMND = 123456789,
                HoTen = "Trần Văn An",
                DiaChi = "1 Lê Đình Lý",
                GioiTinh = true,
                SDT = "098356233",
                NgaySinh = new DateTime(2000, 01, 12)
            }) ;

            context.Users.Add(new User
            {
                CMND = 213456789,
                HoTen = "Nguyễn Văn Linh",
                DiaChi = "76 Lý Thái Tổ",
                GioiTinh = true,
                SDT = "098354343",
                NgaySinh = new DateTime(2000, 11, 27)
            });

            context.Users.Add(new User
            {
                CMND = 213456789,
                HoTen = "Hồ Hải Đăng ",
                DiaChi = "76 Lý Thái Tổ",
                GioiTinh = true,
                SDT = "098354343",
                NgaySinh = new DateTime(2000, 11, 27)
            });
            context.Accounts.Add(new ac
            {
                cm
            })


        }
    }
}
