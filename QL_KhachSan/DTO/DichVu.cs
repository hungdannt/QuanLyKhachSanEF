using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("DichVu")]
    public class DichVu
    {
        public DichVu()
        {
            this.PhieuDichVus = new HashSet<PhieuDichVu>();
        }
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDichVu { get; set; }

        [StringLength(20)]
        public string TenDichVu { get; set; }

        public float DonGia { get; set; }

        public virtual ICollection<PhieuDichVu> PhieuDichVus { get; set; }
    }
}
