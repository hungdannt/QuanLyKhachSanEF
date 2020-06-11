using DAO.Model;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Account
    {
        public static List<DTO_Account> GetAllAccount()
        {
            KhachSanContext context = new KhachSanContext();
            var query = (from n in context.Accounts
                         select new DTO_Account
                         {
                             STT = n.STT,
                             CMND = n.CMND,
                             TenDangNhap = n.TenDangNhap,
                             MatKhau = n.MatKhau,
                             ChucVu = n.ChucVu,

                         });

            return query.ToList();
        }
        public static DTO_Account GetAccount(int id)
        {
            Account a = Account.GetAccount(id);
            DTO_Account b = new DTO_Account();
            b.STT = a.STT;
            b.TenDangNhap = a.TenDangNhap;
            b.CMND = a.CMND;
            b.MatKhau = a.MatKhau;
            b.ChucVu = a.ChucVu;
            return b;
        }
        public static void InsertUpdate(DTO_Account a)
        {
            Account acc = new Account();
            acc.STT = a.STT;
            acc.ChucVu = a.ChucVu;
            acc.TenDangNhap = a.TenDangNhap;
            acc.MatKhau = a.MatKhau;
            acc.CMND = a.CMND;
            acc.InsertUpdate();
        }
      





    }
}
