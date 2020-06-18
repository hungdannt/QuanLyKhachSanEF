using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
namespace DTO
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STT { get; set; }

        public int CMND { get; set; }

        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [StringLength(50)]
        public string MatKhau { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string ChucVu { get; set; }

        public virtual User User { get; set; }


        public static List<Account> GetAll()
        {
            KhachSanContext context = new KhachSanContext();
            return context.Accounts.ToList();
        }
        public static Account GetAccount(int idAccount)
        {
            KhachSanContext context = new KhachSanContext();
            return context.Accounts.Where(p => p.STT == idAccount).FirstOrDefault();
        }

        public static void Delete(int id)
        {
            KhachSanContext context = new KhachSanContext();
            Account ac = context.Accounts.Where(p => p.STT == id).FirstOrDefault();
            try
            {
                context.Accounts.Remove(ac);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InsertUpdate()
        {
            KhachSanContext context = new KhachSanContext();
            context.Accounts.AddOrUpdate(this);
            context.SaveChanges();
        }
    }
}
