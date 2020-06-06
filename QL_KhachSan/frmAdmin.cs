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
    public partial class frmAdmin : Form
    {
        private int cmnd;
        public frmAdmin(int cmnd)
        {   
            this.cmnd = cmnd;
            InitializeComponent();
        }

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
            lbAvatarName.Text = UserBUS.LayThongChiTietUser(cmnd).HoTen;
            timer1.Start();
            lbDate.Text = DateTime.Now.ToLongDateString();
            MoveSidePanel(btnHome);
            Opacity = 30;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnHome);
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnDanhSach);
            if (!panelNV.Controls.Contains(UCHoaDon.Instance))
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

        private void btnSetting_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnSetting);

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

        private void panelmove_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion
    }
}
