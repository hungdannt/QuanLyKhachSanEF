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
    public partial class UCAccount : UserControl
    {
        private static UCAccount _Instance;

        public static UCAccount Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new UCAccount();
                }
                return _Instance;
            }
        }
        private UCAccount()
        {
            InitializeComponent();
        }


    }
}
