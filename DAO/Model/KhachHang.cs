using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    [Table("KhachHang")]
    public class KhachHang
    {
        public KhachHang()
        {
            this.HoaDons = new HashSet<HoaDon>();
            this.PhieuThuePhongs = new HashSet<PhieuThuePhong>();
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

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string SDT { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string DiaChi { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }

        public virtual ICollection<PhieuThuePhong> PhieuThuePhongs { get; set; }
    }
}
