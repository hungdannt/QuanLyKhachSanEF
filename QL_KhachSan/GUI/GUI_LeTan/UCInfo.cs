using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;  
using BLL;

namespace QL_KhachSan
{
    public partial class UCInfo : UserControl
    {
        private static UCInfo _Instance;

        public static UCInfo Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new UCInfo();
                }
                return _Instance;
            }
        }
        private UCInfo()
        {
            InitializeComponent();
        }
        public void ShowInfo(int cmnd)
        {
            panelInfo.Visible = true;
            panelChangePass.Visible = false;
            User u = BLL_User.Instance.Get(cmnd);
            lbCMND.Text = u.CMND.ToString();
            lbHoTen.Text = u.HoTen;
            lbdiachi.Text = u.DiaChi;
            lbPhone.Text = u.SDT;
        }
        public void ChangePass(int cmnd)
        {
            panelInfo.Visible = false;
            panelChangePass.Visible = true;

        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtPass.Text = null;
            txtPassRepeat.Text = null;
            

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassRepeat_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPassRepeat, "");
            if (txtPass.Text != txtPassRepeat.Text)
            {
                errorProvider1.SetError(txtPassRepeat, "Pass không khớp, xin nhập lại !");
            }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }
    }
}
