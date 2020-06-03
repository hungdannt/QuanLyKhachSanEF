using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class UCDatPhong : UserControl
    {
        private static UCDatPhong _Instance;

        public static UCDatPhong Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new UCDatPhong();
                }
                return _Instance;
            }
        }
        private UCDatPhong()
        {
            InitializeComponent();
        }

        private void UCDatPhong_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Thông tin nhận phòng";
            cardDatPhong.Visible = false;
            cardNhanPhong.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Thông tin đặt phòng";
            cardDatPhong.Visible = true;
            cardNhanPhong.Visible = false;
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
