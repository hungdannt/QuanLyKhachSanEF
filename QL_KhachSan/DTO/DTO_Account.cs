using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Account
    {
        public int STT { get; set; }
        public int CMND { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string ChucVu { get; set; }

        public DTO_Account(int stt, int cmnd, string name, string pass, string chucvu)
        {
            this.STT = stt;
            this.CMND = cmnd;
            this.MatKhau = pass;
            this.TenDangNhap = name;
            this.ChucVu = chucvu;
        }
        public DTO_Account()
        {

        }
    }
}
