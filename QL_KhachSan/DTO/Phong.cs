using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("Phong")]
    public class Phong
    {
        public Phong()
        {
            this.PhieuThuePhongs = new HashSet<PhieuThuePhong>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPhong { get; set; }

        [StringLength(10)]
        public string LoaiPhong { get; set; }

        public float DonGia { get; set; }

        public int SoNguoiToiDa { get; set; }

        public virtual ICollection<PhieuThuePhong> PhieuThuePhongs { get; set; }
    }
}
