using System;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UserDAO
    {
        static HotelEntities context = new HotelEntities();
        public static List<UserDTO> LayThongTinUser()
        {

            var query = (from n in context.Accounts 
                         select new UserDTO
                         {
                             TenDangNhap = n.username,
                             MatKhau = n.pass,
                             MaChucVu = n.idGroup,
                         });
            return query.ToList();

        }
        public static string GetChucVu(int machucvu)
        {
            var query = (from n in context.Groups
                         where n.id == machucvu select n.tenGroup).Single();
            return query.ToString();
        }

        //Đếm số lượng tài khoản có trong hệ thống
        public static int DemSoLuongTK()
        {
            int query = (from n in context.Accounts
                         select new UserDTO
                         {
                         }).Count();
            return query;
        }
    }

}
