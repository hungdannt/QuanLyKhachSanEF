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
    public partial class UCHoaDon : UserControl
    {
        private static UCHoaDon _Instance;
        public static UCHoaDon Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new UCHoaDon();
                }
                return _Instance;
            }
        }
        private UCHoaDon()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel17_Click(object sender, EventArgs e)
        {

        }
    }
}
