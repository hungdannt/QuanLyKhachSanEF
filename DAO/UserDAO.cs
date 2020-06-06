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
        public static List<Acc> LayThongTinUser()
        {

            var query = (from n in context.Accounts 
                         select new Acc
                         {
                             TenDangNhap = n.username,
                             MatKhau = n.pass,
                             ChucVu = n.chucvu,
                         });
            return query.ToList();

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
    }

}
