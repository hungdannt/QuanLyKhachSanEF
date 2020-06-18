using DAO;
using DAO.Model;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Account
    {
        public static List<DTO_Account> GetAllAccount()
        {
            return DAO_Account.GetAllAccount();
        }
        public static DTO_Account GetAccount(int id)
        {
            return DAO_Account.GetAccount(id);
        }

        public static void InsertUpdate(DTO_Account a)
        {
            DAO_Account.InsertUpdate(a);
        }

        public static void Delete(int id)
        {
            Account.Delete(id);
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


    }
}
