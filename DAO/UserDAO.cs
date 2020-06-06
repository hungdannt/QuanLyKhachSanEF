using System;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DAO
{
    public class UserDAO
    {
        static HotelEntities context = new HotelEntities();
        public static List<Acc> LayThongTinUser()
        {

            var query = (from n in context.Accounts
                         select new Acc
                         {
                             STT = n.stt,
                             CMND = (int)n.cmnd,
                             TenDangNhap = n.username,
                             MatKhau = n.pass,
                             ChucVu = n.chucvu,

                         }); ;

            return query.ToList();

        }

        public static UserDetail LayThongTinChiTietUser(int cmnd)
        {
            string gioitinh;
            User u = context.Users.Where(p => p.soCMND == cmnd).SingleOrDefault();
            if ((bool)u.gioitinh)
            {
                gioitinh = "Nam";
            }
            else gioitinh = "Nữ";
            UserDetail ud = new UserDetail
            {
                CMND = u.soCMND,
                HoTen = u.hoten,
                DiaChi = u.diachi,
                Sex = gioitinh,
                SDT = u.sdt,
                NgaySinh = u.ngaysinh
            };
            return ud;

        }
        //Đếm số lượng tài khoản có trong hệ thống
        public static int DemSoLuongTK()
        {
            int query = (from n in context.Accounts
                         select new Acc
                         {
                         }).Count();
            return query;
        }
        public static bool AddAcc(Account acc)
        {
            try
            {
                context.Accounts.Add(acc);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }      
        }
    }
}
