using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("PhieuThuePhong")]
    public class PhieuThuePhong
    {
        public PhieuThuePhong()
        {
            this.PhieuDichVus = new HashSet<PhieuDichVu>();
        }

        [Key]
        [StringLength(10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string MaPhieuThuePhong { get; set; }

        public int CMNDKhachHang { get; set; }

        
        public int MaPhong { get; set; }

        [Column(TypeName = "Date")]
        public DateTime NgayThue { get; set; }

        [Column(TypeName = "Date")]
        public DateTime NgayTra { get; set; }

        [ForeignKey("CMNDKhachHang")]
        public virtual KhachHang KhachHang { get; set; }

        public virtual ICollection<PhieuDichVu> PhieuDichVus { get; set; }
       
        [ForeignKey("MaPhong")]
        public virtual Phong Phong { get; set; }
    }
}
