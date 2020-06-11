using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Model;
using DTO;

namespace DAO
{
    public class DAO_User
    {
        public static List<DTO_User> GetAllUser()
        {
            KhachSanContext context = new KhachSanContext();
            var query = (from n in context.Users
                         select new DTO_User
                         {
                             SDT = n.SDT,
                             DiaChi = n.DiaChi,
                             CMND = n.CMND,
                             HoTen = n.HoTen,
                             Sex = n.GioiTinh,
                             NgaySinh = n.NgaySinh,

                         });

            return query.ToList();
        }

        public static DTO_User GetUser(int cmnd)
        {
            User a = User.GetUser(cmnd);
            DTO_User b = new DTO_User();
            b.SDT = a.SDT;
            b.NgaySinh = a.NgaySinh;
            b.DiaChi = a.DiaChi;
            b.HoTen = a.HoTen;
            b.Sex = a.GioiTinh;
            b.CMND = a.CMND;
            return b;
        }

        public static void InsertUpdate(DTO_User a)
        {
            User u = new User();
            u.CMND = a.CMND;
            u.DiaChi = a.DiaChi;
            u.SDT = a.SDT;
            u.NgaySinh = a.NgaySinh;
            u.HoTen = a.HoTen;
            u.GioiTinh = u.GioiTinh;
            u.InsertUpdate();
        }
       


    }
}
