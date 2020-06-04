using QL_KhachSan.Properties;
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
    public partial class frmAlert : Form
    {
       
        public frmAlert()
        {
            InitializeComponent();
        }
        public enum Action
        {
            wait,
            start,
            close
        }

        public enum Type
        {
            Success,
            Warning,
            Error,
            Info
        }
        private frmAlert.Action action;
        private int x, y;
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case Action.wait:
                    timer1.Interval = 5000;
                    action = Action.close;
                    break;
                case frmAlert.Action.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = frmAlert.Action.wait;
                        }
                    }
                    break;
                case Action.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (this.Opacity == 0.0)
                    {
                        this.Close();
                    }
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = Action.close;
        }

        public void showAlert(string msg, Type type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                frmAlert frm = (frmAlert)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case Type.Success:
                    this.pictureBox1.Image = Resources.success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case Type.Error:
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.DarkRed;
                    break;
                case Type.Info:
                    this.pictureBox1.Image = Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case Type.Warning:
                    this.pictureBox1.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
            }
            this.lblMsg.Text = msg;
            this.Show();
            this.action = Action.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }
    }
}
