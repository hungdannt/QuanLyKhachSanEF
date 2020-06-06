using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class frmAddAcc : Form
    {
        public frmAddAcc()
        {
            InitializeComponent();
            cbbChucVu.AddItem("Admin");
            cbbChucVu.AddItem("Lê Tân");
            cbbChucVu.AddItem("Kinh Doanh");

        }

        

        private void frmAddAcc_Load(object sender, EventArgs e)
        {
            
            
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Acc acc = new Acc();
            int stt = UserBUS.DemSoLuongTK();
            acc.STT = stt + 1;
            acc.CMND = Convert.ToInt32(txtCMND.Text);
            acc.TenDangNhap = txtTenDangNhap.Text;
            acc.MatKhau = UserBUS.MaHoa(txtPassRepeat.Text);
            acc.ChucVu = cbbChucVu.selectedValue.ToString();
            UserBUS.AddAcc(acc);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
