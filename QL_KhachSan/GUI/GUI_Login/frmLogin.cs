using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class frmLogin : Form
    {
        #region Khởi tạo form
        List<DTO_Account> lst;
        public frmLogin()
        {
            Thread thread = new Thread(new ThreadStart(() => Application.Run(new frmSplashScreen())));
            thread.Start();
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

            this.Hide();
            lst = BUS_Account.GetAllAccount();
            
        }
        #endregion

        #region Xử lý đóng form
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
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
        #endregion

        #region Hàm di chuyển vị trí form
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 160;
                mouseY = MousePosition.Y - 10;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

  

        #region Hàm gọi MessageBox
        public void Alert(string msg, frmAlert.Type type)
        {
            Thread aleart = new Thread(new ThreadStart(() => Application.Run(new frmAlert(msg, type))));
            aleart.Start();
        }
        #endregion

        #region Hàm xử lý sự kiện click đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                Alert("Bạn Chưa Nhập Pass", frmAlert.Type.Warning);
            }
            else
            {
                bool check = false;
                for (int i = 0; i < lst.Count(); i++)
                {
                    if (txtTen.Text == lst[i].TenDangNhap.ToString())
                    {
                        check = true;
                        if (lst[i].MatKhau.ToString() == BUS_Account.MaHoa(txtPass.Text))
                        {


                            Alert("Đăng nhập thành công !", frmAlert.Type.Success);
                            if (lst[i].ChucVu == "Admin")
                            {

                                this.Hide();
                                var frm = new frmAdmin(lst[i].STT);
                                frm.ShowDialog();
                                Alert("Đã đăng xuất!", frmAlert.Type.Info);

                                this.Show();
                                lst = BUS_Account.GetAllAccount();
                                
                                txtPass.Text = null;
                            }
                            if (lst[i].ChucVu == "Lễ Tân")
                            {

                                this.Hide();
                                var frm = new frmLeTan(lst[i].STT);
                                frm.ShowDialog();
                                Alert("Đã đăng xuất!", frmAlert.Type.Info);
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
        #endregion

        #region Ẩn hiện pass 
        private void showPASS_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;

        }
        private void showPASS_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;

        }
        #endregion

 
    }
}
