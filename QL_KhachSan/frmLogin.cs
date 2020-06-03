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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < sl; i++)
            {
                if (txtTen.Text == lst[i].TenDangNhap.ToString())
                {
                    if (lst[i].MatKhau.ToString() == MaHoa(txtPass.Text))
                    {
                       
                        MessageBox.Show("Dang Nhap Thanh Cong");
                        if (UserBUS.GetChucVu(int.Parse(lst[i].MaChucVu.ToString())) == "letan")
                        {
                            MessageBox.Show("May la letan");
                            frmLeTan f = new frmLeTan();
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                            txtPass.Text = null;
                        }
                        if (UserBUS.GetChucVu(int.Parse(lst[i].MaChucVu.ToString())) == "admin")
                        {
                            MessageBox.Show("may la admin");
                            frmAdmin f = new frmAdmin();
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                            txtPass.Text = null;
                        }
                        break;

                        

                    }
                    else
                    {
                        MessageBox.Show("Nhap Sai Pas ");
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("Khong ton tai user nay");
                }

            }

           
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showPASS_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;

        }

        private void showPASS_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;

        }

   

    
    }
}
