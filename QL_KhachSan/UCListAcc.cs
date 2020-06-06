using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QL_KhachSan
{
    public partial class UCListAcc : UserControl
    {
        private static UCListAcc _Instance;
        public static UCListAcc Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new UCListAcc();
                }
                return _Instance;
            }
        }
        public UCListAcc()
        {
            InitializeComponent();
        }

        private void UCListAcc_Load(object sender, EventArgs e)
        {
            dgvListAcc.DataSource = UserBUS.LayThongTinUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = UserBUS.LayThongChiTietUser(187859120).HoTen;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmAddAcc();
            this.ParentForm.Opacity = 40;
            this.ParentForm.Update();
            frm.ShowDialog();
            dgvListAcc.DataSource= UserBUS.LayThongTinUser();
            
            
        }
    }
}
