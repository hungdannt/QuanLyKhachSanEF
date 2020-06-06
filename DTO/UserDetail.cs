using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDetail
    {

        public int CMND { get; set; }
        public string HoTen { get; set; }
        public Nullable<DateTime> NgaySinh { get; set; }
        public String Sex { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }    
    }
}
