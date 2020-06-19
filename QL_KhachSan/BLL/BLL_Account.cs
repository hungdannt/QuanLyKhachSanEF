using DTO;
using QL_KhachSan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Account
    {
        private static BLL_Account _Instance;
        public static BLL_Account Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Account();
                }
                return _Instance;
            }
        }

        public List<Account> GetAll()
        {
            var context = new KhachSanContext();
            return context.Accounts.ToList();
        }
        public Account Get(int id)
        {
            var context = new KhachSanContext();
            return context.Accounts.Where(p => p.STT == id).FirstOrDefault();
        }
        
        public bool Add(int stt, int cmnd, string tendangnhap, string pass, string chucvu)
        {
            try
            {
                var context = new KhachSanContext();
                Account a = new Account
                {
                    STT = stt,
                    ChucVu = chucvu,
                    MatKhau = pass,
                    TenDangNhap = tendangnhap,
                    CMND = cmnd
                };
                context.Accounts.Add(a);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public bool Delete(int id)
        {
            try
            {
                var context = new KhachSanContext();
                Account a = context.Accounts.Where(p => p.STT == id).FirstOrDefault();
                context.Accounts.Remove(a);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(int stt, int cmnd, string tendangnhap, string pass, string chucvu)
        {
            try
            {
                var context = new KhachSanContext();
                Account a = context.Accounts.Where(p => p.STT == stt).FirstOrDefault();
                a.CMND = cmnd;
                a.ChucVu = chucvu;
                a.MatKhau = pass;
                a.TenDangNhap = tendangnhap;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #region Giải mã mật khẩu
        public string MaHoa(string pass)
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
