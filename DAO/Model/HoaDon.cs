using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    [Table("HoaDon")]
    public class HoaDon
    {
        [Key]
        [StringLength(10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string MaHoaDon { get; set; }


        public int CMNDKhachHang { get; set; }

        public float Tien { get; set; }

        [Column(TypeName = "Date")]
        public DateTime NgayXuat { get; set; }    
        
        public bool HinhThucThanhToan { get; set; }
     
        [ForeignKey("CMNDKhachHang")]
        public virtual KhachHang KhachHang { get; set; }
    }
}
