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
    
    public partial class UCPhieuDV : UserControl
    {
        private static UCPhieuDV _Instance;
        public static UCPhieuDV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new UCPhieuDV();
                }
                return _Instance;
            }
        }
        public UCPhieuDV()
        {
            InitializeComponent();
        }
    }
}
