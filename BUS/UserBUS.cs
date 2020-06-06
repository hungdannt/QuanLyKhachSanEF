using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class UserBUS
    {
        public static List<Acc> LayThongTinUser()
        {
            return UserDAO.LayThongTinUser();
        }


        public static int DemSoLuongTK()
        {
            return UserDAO.DemSoLuongTK();
        }
        

    }
}
