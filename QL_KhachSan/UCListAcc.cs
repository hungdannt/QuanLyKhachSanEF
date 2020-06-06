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
           
        }
    }
}
