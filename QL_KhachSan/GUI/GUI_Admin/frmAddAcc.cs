using BLL;
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
using System.Xml.Serialization;

namespace QL_KhachSan
{
    public partial class frmAddAcc : Form
    {
        private int key;
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
                Account acc = BLL_Account.Instance.Get(key);
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
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
          
                if (txtCMND.Text == "" || txtPass.Text == "" || txtTenDangNhap.Text == "")
                {
                    Alert("Vui lòng điền đầy đủ", frmAlert.Type.Info);
                }
                if (txtPass.Text.Equals(txtPassRepeat.Text) && txtPassRepeat.Text != "")
                {
                    int stt = BLL_Account.Instance.GetAll().Count();
                    if (key == 0)
                    {
                        stt += 1;
                        if (BLL_Account.Instance.Add
                                (
                                stt,
                                Convert.ToInt32(txtCMND.Text),
                                txtTenDangNhap.Text,
                                BLL_Account.Instance.MaHoa(txtPassRepeat.Text),
                                cbbChucVu.selectedValue.ToString()
                                )
                            )
                        {
                            Alert("Đã thêm thành công", frmAlert.Type.Success);
                        }
                        else
                        {
                            Alert("Đã xảy ra lỗi", frmAlert.Type.Error);

                        }
                    }
                    if (key != 0)
                    {
                        if (BLL_Account.Instance.Update
                                (
                                stt,
                                Convert.ToInt32(txtCMND.Text),
                                txtTenDangNhap.Text,
                                BLL_Account.Instance.MaHoa(txtPassRepeat.Text),
                                cbbChucVu.selectedValue.ToString()
                                )
                           )
                        {
                            Alert("Đã sửa thành công", frmAlert.Type.Success);
                        }
                        else
                        {
                            Alert("Đã xảy ra lỗi", frmAlert.Type.Error);
                        }
                    }                 
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

        private void txtTenDangNhap_OnValueChanged(object sender, EventArgs e)
        {
            if (key == 0)
            {
                errorProvider1.SetError(txtTenDangNhap, "");
                if (BLL_Account.Instance.GetAll().SingleOrDefault(p => p.TenDangNhap == txtTenDangNhap.Text) != null)
                {
                    errorProvider1.SetError(txtTenDangNhap, "Tên đăng nhập đã tồn tại, xin nhập lại !");
                }
            }

        }

    }

}
