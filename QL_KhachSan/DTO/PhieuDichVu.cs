using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("PhieuDichVu")]
    public class PhieuDichVu
    {
        [Key]
        [StringLength(10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string MaPhieuDichVu { get; set; }

        [StringLength(10)]
        public string MaPhieuThuePhong { get; set; }

        public int MaDichVu { get; set; }

        
        public int SoLuong { get; set; }

        [ForeignKey("MaDichVu")]
        public virtual DichVu DichVu { get; set; }

        [ForeignKey("MaPhieuThuePhong")]
        public virtual PhieuThuePhong PhieuThuePhong { get; set; }
    }
}
