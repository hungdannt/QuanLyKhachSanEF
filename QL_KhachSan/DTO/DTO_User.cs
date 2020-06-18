using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_User
    {

        public int CMND { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool Sex { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }


        public DTO_User(int cmnd, string hoten, DateTime ngaysinh, bool sex, string sdt, string diachi)
        {
            this.CMND = cmnd;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.Sex = sex;
            this.SDT = sdt;
            this.DiaChi = diachi;
        }
        public DTO_User()
        {

        }
    }
}
