using QL_KhachSan;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_User
    {


        private static BLL_User _Instance;
        public static BLL_User Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_User();
                }
                return _Instance;
            }
        }

        public List<User> GetAll()
        {
            var context = new KhachSanContext();
            return context.Users.ToList();
        }
        public User Get(int cmnd)
        {
            var context = new KhachSanContext();
            return context.Users.Where(p => p.CMND == cmnd).FirstOrDefault();
        }

        public bool Add(int cmnd, string hoten, DateTime ns, bool sex, string phone, string dc)
        {
            try
            {
                var context = new KhachSanContext();
                User a = new User
                {
                    CMND = cmnd,
                    DiaChi = dc,
                    GioiTinh = sex,
                    SDT = phone,
                    HoTen = hoten,
                    NgaySinh = ns
                };
                context.Users.Add(a);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int cmnd)
        {
            try
            {
                var context = new KhachSanContext();
                User a = context.Users.Where(p => p.CMND == cmnd).FirstOrDefault();
                context.Users.Remove(a);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(int cmnd, string hoten, DateTime ns, bool sex, string phone, string dc)
        {
            try
            {
                var context = new KhachSanContext();
                User a = context.Users.Where(p => p.CMND == cmnd).FirstOrDefault();
                a.DiaChi = dc;
                a.GioiTinh = sex;
                a.SDT = phone;
                a.HoTen = hoten;
                a.NgaySinh = ns;
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




   

