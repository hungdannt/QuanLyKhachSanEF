using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class frmLogin : Form

    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        List<UserDTO> lst;
        int sl;



        private void frmLogin_Load(object sender, EventArgs e)
        {
            lst = UserBUS.LayThongTinUser();
            sl = UserBUS.DemSoLuongTK();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show(
                "Muốn thoát ?",
                "Bạn chưa đăng nhập!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 160;
                mouseY = MousePosition.Y - 10;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        public string MaHoa(string pass)
        {
            MD5 mh = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pass);
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
        public void Alert(string msg, frmAlert.Type type)
        {
            frmAlert frm = new frmAlert();
            frm.showAlert(msg, type);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                Alert("Bạn Chưa Nhập Pass Nhé !", frmAlert.Type.Warning);
            }
            else
            {
                bool check = false;
                for (int i = 0; i < sl; i++)
                {
                    if (txtTen.Text == lst[i].TenDangNhap.ToString())
                    {
                        check = true;
                        if (lst[i].MatKhau.ToString() == MaHoa(txtPass.Text))
                        {

                            Alert("Đăng Nhập Thành Công !", frmAlert.Type.Success);
                            if (UserBUS.GetChucVu(int.Parse(lst[i].MaChucVu.ToString())) == "letan")
                            {

                                this.Hide();
                                new Thread(() => new frmLeTan().ShowDialog()).Start();
                                
                                this.Show();
                                txtPass.Text = null;
                            }
                            if (UserBUS.GetChucVu(int.Parse(lst[i].MaChucVu.ToString())) == "admin")
                            {

                                
                                this.Hide();
                                new Thread(() => new frmLeTan()).Start();
                                
                                this.Show();

                                txtPass.Text = null;
                            }
                            break;
                        }
                        else
                        {
                            Alert("Nhập Sai Pass Rồi !", frmAlert.Type.Error);
                            break;
                        }
                    }
                    else
                    {
                        check = false;
                    }
                }
                if (!check)
                {
                    Alert("Sai tên đăng nhập !", frmAlert.Type.Error);

                }
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void showPASS_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;

        }
        private void showPASS_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;

        }
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }




    }
}
