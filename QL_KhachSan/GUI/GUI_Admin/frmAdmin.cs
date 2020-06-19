using BLL;
using DTO;
using QL_KhachSan.GUI_Admin;
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
    public partial class frmAdmin : Form
    {
        private int stt;
        private Account thisacc;
        public frmAdmin(int stt)
        {
            this.stt = stt;
            this.thisacc = BLL_Account.Instance.Get(stt);
            InitializeComponent();
        }
        #region Hàm gọi MessageBox
        public void Alert(string msg, frmAlert.Type type)
        {
            Thread aleart = new Thread(new ThreadStart(() => Application.Run(new frmAlert(msg, type))));
            aleart.Start();
        }
        #endregion
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void MoveSidePanel(Control c)  // sáng chức năng khi được click
        {
            sidepanel.Height = c.Height;
            sidepanel.Top = c.Top;

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            lbAvatarName.Text = BLL_User.Instance.Get(thisacc.CMND).HoTen;
            timer1.Start();
            lbDate.Text = DateTime.Now.ToLongDateString();
            MoveSidePanel(btnHome);

            UCHome.Instance.Dock = DockStyle.Fill;
            panelNV.Controls.Add(UCHome.Instance);
            UCHome.Instance.BringToFront();
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnHome);
            if (panel6.Visible == true)
            {
                panel6.Visible = false;
                panel6.Width = 9;
            }
            if (!panelNV.Controls.Contains(UCHome.Instance))
            {
                UCHome.Instance.Dock = DockStyle.Fill;
                panelNV.Controls.Add(UCHome.Instance);
                UCHome.Instance.BringToFront();
            }
            else
            {
                UCHome.Instance.BringToFront();
            }
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            if (panel6.Visible == false)
            {
                panel6.Visible = true;
                panel6.BringToFront();
                timer2.Start();
            }
            else
            {
                    
            }
            
            MoveSidePanel(btnDanhSach);


        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (panel6.Visible == true)
            {
                panel6.Visible = false;
                panel6.Width = 9;
            }
            MoveSidePanel(btnSetting);
            var frm = new frmAddUser(thisacc.CMND);
            this.Opacity = .55;
            frm.ShowDialog();
            this.Opacity = 1;
        }
        #region Hàm di chuyển vị trí form
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void panelmove_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 1500;
                mouseY = MousePosition.Y - 10;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
        private void panelmove_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (panel6.Visible == true)
            {
                panel6.Visible = false;
                panel6.Width = 9;
            }
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("T");
            if (bunifuProgressBar1.Value == 100)
            {
                bunifuProgressBar1.Value = 0;
            }
            else
            {
                bunifuProgressBar1.Value += 20;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sidepanel.Top == btnDanhSach.Top)
            {
                panel6.Width += 20;

            }
            if (panel6.Width == 329)
            {
                timer2.Stop();

            }
        }

        private void lbDSTK_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel6.Width = 9;
            if (!panelNV.Controls.Contains(UCListAcc.Instance))
            {
                UCListAcc.Instance.Dock = DockStyle.Fill;
                panelNV.Controls.Add(UCListAcc.Instance);
                UCListAcc.Instance.BringToFront();

            }
            else
            {

                UCListAcc.Instance.BringToFront();
            }

        }

        private void lbDSNV_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel6.Width = 9;
            if (!panelNV.Controls.Contains(UCListNhanVien.Instance))
            {
                UCListNhanVien.Instance.Dock = DockStyle.Fill;
                panelNV.Controls.Add(UCListNhanVien.Instance);
                UCListNhanVien.Instance.BringToFront();

            }
            else
            {

                UCListNhanVien.Instance.BringToFront();
            }
        }

       

  

        

        private void panelmove_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion
    }
}
