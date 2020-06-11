using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    [Table("User")]
    public class User
    {
        public User()
        {
            this.Accounts = new HashSet<Account>();
        }     
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CMND { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        public bool GioiTinh { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string DiaChi { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }

        public static List<User> GetAll()
        {
            KhachSanContext context = new KhachSanContext();
            return context.Users.ToList();
        }
        public static User GetUser(int cmnd)
        {
            KhachSanContext context = new KhachSanContext();
            return context.Users.Where(p => p.CMND == cmnd).FirstOrDefault();
        }

        public static void Delete(int cmnd)
        {
            KhachSanContext context = new KhachSanContext();
            User u = context.Users.Where(p => p.CMND == cmnd).FirstOrDefault();
            try
            {
                context.Users.Remove(u);
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
            context.Users.AddOrUpdate(this);
            context.SaveChanges();
        }
    }
}
