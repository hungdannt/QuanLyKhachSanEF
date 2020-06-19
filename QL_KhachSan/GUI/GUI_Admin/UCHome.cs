﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QL_KhachSan.GUI_Admin
{
    public partial class UCHome : UserControl
    {
        private UCHome()
        {
            InitializeComponent();


        }
        private static UCHome _Instance;
        public static UCHome Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new UCHome();
                }
                return _Instance;
            }
        }
       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void UCHome_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (circleSLTaiKhoan.Value == 20)
            {
                timer1.Interval = 5000;

            }
            if (circleSLTaiKhoan.Value == 100)
            {
                circleSLTaiKhoan.Value = 0;
            }
            circleSLTaiKhoan.Value += 20;
            txtSLNhanVien.Text = BLL_User.Instance.GetAll().Count().ToString();
            txtSLAdmin.Text = BLL_Account.Instance.GetAll().Where(p => p.ChucVu == "Admin").ToList().Count().ToString();
            txtSLLeTan.Text = BLL_Account.Instance.GetAll().Where(p => p.ChucVu == "Lễ Tân").ToList().Count().ToString();
            txtSLKinhDoanh.Text = BLL_Account.Instance.GetAll().Where(p => p.ChucVu == "Kinh Doanh").ToList().Count().ToString();
            txtSLTK.Text = BLL_Account.Instance.GetAll().Count().ToString();

        }

    }
}
