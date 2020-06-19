using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace DTO
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

        [StringLength(50)]
        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        public bool GioiTinh { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }

     
    }
}
