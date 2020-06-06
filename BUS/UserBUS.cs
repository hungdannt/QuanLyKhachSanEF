using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        public static UserDetail LayThongChiTietUser(int cmnd)
        {
            return UserDAO.LayThongTinChiTietUser(cmnd);
        }

        public static int DemSoLuongTK()
        {
            return UserDAO.DemSoLuongTK();
        }
        #region Giải mã mật khẩu
        public static string MaHoa(string pass)
        {
            MD5 mh = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pass);
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
        #endregion

        public static bool AddAcc(Acc acc)
        {
            try
            {
                Account account = new Account();
                account.cmnd = acc.CMND;
                account.stt = acc.STT;
                account.username = acc.TenDangNhap;
                account.pass = acc.MatKhau;
                account.chucvu = acc.ChucVu;
                UserDAO.AddAcc(account);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
               
        }
    }
}
