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
        public string hoten { get; set; }
        public Nullable<DateTime> ngaysinh { get; set; }
        public Nullable<bool> sex { get; set; }
        public string sdt { get; set; }
        public string diachi { get; set; }    
    }
}
