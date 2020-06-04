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
    public partial class frmLeTan : Form
    {
        public frmLeTan()
        {
            InitializeComponent();
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

    
        private void MoveSidePanel(Control c)  // sáng chức năng khi được click
        {
            panel3.Height = c.Height;
            panel3.Top = c.Top;

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 700;
                mouseY = MousePosition.Y - 10;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnDatPhong);
            if (!panelNV.Controls.Contains(UCDatPhong.Instance))
            {
                UCDatPhong.Instance.Dock = DockStyle.Fill;
                panelNV.Controls.Add(UCDatPhong.Instance);
                UCDatPhong.Instance.BringToFront();

            }
            else
            {
                UCDatPhong.Instance.BringToFront();
            }
            
           
        }

      
      
        private void frmLeTan_Load(object sender, EventArgs e)
        {
            MoveSidePanel(btnAccount);
          
            UCAccount.Instance.Dock = DockStyle.Fill;
            
            panelNV.Controls.Add(UCAccount.Instance);
            UCAccount.Instance.Show();
            

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnAccount);
           
            
            UCAccount.Instance.Dock = DockStyle.Fill;
            panelNV.Controls.Add(UCAccount.Instance);
            UCAccount.Instance.BringToFront();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();        
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnLapHoaDon);
            if (!panelNV.Controls.Contains(UCHoaDon.Instance))
            {
                UCHoaDon.Instance.Dock = DockStyle.Fill;
                panelNV.Controls.Add(UCHoaDon.Instance);
                UCHoaDon.Instance.BringToFront();

            }
            else
            {
                UCHoaDon.Instance.BringToFront();
            }






        }

        private void btnLapDV_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnLapDV);  

            if (!panelNV.Controls.Contains(UCPhieuDV.Instance))
            {
                UCPhieuDV.Instance.Dock = DockStyle.Fill;
                panelNV.Controls.Add(UCPhieuDV.Instance);
                UCPhieuDV.Instance.BringToFront();

            }
            else
            {
                UCPhieuDV.Instance.BringToFront();
            }


        }

        private void btnDoiPass_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnDoiPass);
            if (!panelNV.Controls.Contains(UCDoiPass.Instance))
            {
                UCDoiPass.Instance.Dock = DockStyle.Fill;
                panelNV.Controls.Add(UCDoiPass.Instance);
                UCDoiPass.Instance.BringToFront();

            }
            else
            {
                UCDoiPass.Instance.BringToFront();
            }
            

        }

    



    

   
      

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
