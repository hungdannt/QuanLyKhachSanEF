using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class frmAddAcc : Form
    {
        private int key;
        private string msg;
        public frmAddAcc(int key)
        {
            this.key = key;

            InitializeComponent();
            cbbChucVu.AddItem("Admin");
            cbbChucVu.AddItem("Lễ Tân");
            cbbChucVu.AddItem("Kinh Doanh");

        }
        #region Hàm gọi MessageBox
        public void Alert(string msg, frmAlert.Type type)
        {
            Thread aleart = new Thread(new ThreadStart(() => Application.Run(new frmAlert(msg, type))));
            aleart.Start();
        }
        #endregion



        private void frmAddAcc_Load(object sender, EventArgs e)
        {
            botro.ApplyElipse(txtCMND, 40);
            if (key != 0)
            {
                DTO_Account acc = BUS_Account.GetAccount(key);
                txtCMND.Text = acc.CMND.ToString();
                txtTenDangNhap.Text = acc.TenDangNhap;
                string chucvu = acc.ChucVu;

                switch (chucvu)
                {
                    case "Admin":
                        cbbChucVu.selectedIndex = 0;
                        break;
                    case "Lễ Tân":
                        cbbChucVu.selectedIndex = 1;
                        break;
                    case "Kinh Doanh":
                        cbbChucVu.selectedIndex = 2;
                        break;
                }
                txtPass.Text = null;
                txtPass.Focus();
                txtPassRepeat.Text = null;
                msg = "Sửa thành công";


            }


        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Account acc = new DTO_Account();
                int stt = BUS_User.GetAllUser().Count();
                if (key != 0)
                {
                    acc.STT = stt;

                }
                else
                {
                    acc.STT = stt + 1;
                }
                acc.CMND = Convert.ToInt32(txtCMND.Text);
                acc.TenDangNhap = txtTenDangNhap.Text;
                acc.MatKhau = BUS_Account.MaHoa(txtPassRepeat.Text);
                acc.ChucVu = cbbChucVu.selectedValue.ToString();
                if (key != 0)
                {
                    acc.TenDangNhap = txtTenDangNhap.Text;
                    acc.MatKhau = BUS_Account.MaHoa(txtPassRepeat.Text);
                    acc.ChucVu = cbbChucVu.selectedValue.ToString();
                    BUS_Account.InsertUpdate(acc);
                    Alert(msg, frmAlert.Type.Success);

                }
                else
                {
                    BUS_Account.InsertUpdate(acc);
                    msg = "Đã thêm thành công ^^";
                    Alert(msg, frmAlert.Type.Success);
                }

            }
            catch (Exception)
            {

                Alert("Đã xảy ra lỗi !", frmAlert.Type.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            Dispose();
        }



        private void showpass_mousedown(object sender, MouseEventArgs e)
        {
            txtPass.isPassword = false;
        }



        private void showPASS_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.isPassword = true;
        }



        private void txtPassRepeat_OnValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPassRepeat, "");
            if (txtPass.Text != txtPassRepeat.Text)
            {
                errorProvider1.SetError(txtPassRepeat, "Pass không khớp, xin nhập lại !");
            }
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.Text = null;
        }
    }

}
