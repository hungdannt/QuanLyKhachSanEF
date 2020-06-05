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
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circle.Value += 12;
            panel2.Width += 20;
            if (circle.Value >= 400)
            {
                circle.Value = 0;
                circle.Visible = false;
            }


            if (panel2.Width == 361)
            {
                label1.Text = "Đang nạp cơ sở dữ liệu ...";
            }
            if (panel2.Width == 561 )
            {
                label1.Text = "Đang load giao diện ...";
            }

            if (panel2.Width == 741)
            {
                label1.Text = "Hoàn Tất !";
            }
            if (panel2.Width > 1100)
            {
                timer1.Stop();
                this.Dispose();
               
            }

        }
    }
}
