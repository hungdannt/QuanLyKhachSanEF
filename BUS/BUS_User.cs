using DAO;
using DAO.Model;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_User
    {
       
       
        public static DTO_User GetUser(int cmnd)
        {
            return DAO_User.GetUser(cmnd);
        }

        public static List<DTO_User> GetAllUser()
        {
            return DAO_User.GetAllUser();
        }
        public static void InsertUpdate(DTO_User u)
        {
            DAO_User.InsertUpdate(u);
        }
        public static void Delete(int cmnd)
        {
            User.Delete(cmnd);
        }

   
       
       
    }
}
