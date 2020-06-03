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
    public partial class UCDoiPass : UserControl
    {
        private static UCDoiPass _Instance;

        public static UCDoiPass Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new UCDoiPass();
                }
                return _Instance;
            }
        }
        private UCDoiPass()
        {
            InitializeComponent();
        }

        private void UCHoaDon_Load(object sender, EventArgs e)
        {
            
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
    }
}
