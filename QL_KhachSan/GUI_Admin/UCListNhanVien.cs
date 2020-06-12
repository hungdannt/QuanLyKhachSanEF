using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace QL_KhachSan
{
    public partial class UCListNhanVien : UserControl
    {
        private static UCListNhanVien _Instance;
        public static UCListNhanVien Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new UCListNhanVien();
                }
                return _Instance;
            }
        }
        public UCListNhanVien()
        {
            InitializeComponent();
            dgvListNV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvListNV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListNV.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvListNV.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvListNV.BackgroundColor = Color.White;

            dgvListNV.EnableHeadersVisualStyles = false;
            dgvListNV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListNV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvListNV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }


        #region Hàm gọi MessageBox
        public void Alert(string msg, frmAlert.Type type)
        {
            Thread aleart = new Thread(new ThreadStart(() => Application.Run(new frmAlert(msg, type))));
            aleart.Start();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            var frm = new frmAddUser(0);
            this.ParentForm.Opacity = .55;
            frm.ShowDialog();
            this.ParentForm.Opacity = 1;
            dgvListNV.DataSource = BUS_User.GetAllUser();


        }

        private void dgvListAcc_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDel.Normalcolor = System.Drawing.Color.SkyBlue;
            btnEdit.Normalcolor = System.Drawing.Color.SkyBlue;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvListNV.SelectedRows;
            if (r.Count == 1)
            {
                int key = Convert.ToInt32(r[0].Cells["Column1"].Value.ToString());
                try
                {
                    BUS_User.Delete(key);
                    Alert("Đã xóa thành công ^^", frmAlert.Type.Success);
                    dgvListNV.DataSource = BUS_User.GetAllUser();
                }
                catch (Exception)
                {
                    Alert("Đã xảy ra lỗi !!", frmAlert.Type.Error);
                }
            }
            else
            {
                Alert("Vui lòng chọn dòng cần xóa !", frmAlert.Type.Info);
            }
        }

        private void dgvListAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvListNV.SelectedRows;
            if (r.Count == 1)
            {
                int cmnd = Convert.ToInt32(r[0].Cells["Column1"].Value.ToString());
                var frm = new frmAddUser(cmnd);
                this.ParentForm.Opacity = .55;
                frm.ShowDialog();
                this.ParentForm.Opacity = 1;
                dgvListNV.DataSource = BUS_User.GetAllUser();

            }


        }

        private void dgvListAcc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDel.Normalcolor = System.Drawing.Color.Gray;
            btnEdit.Normalcolor = System.Drawing.Color.Gray;

        }

        private void UCListNhanVien_Load(object sender, EventArgs e)
        {
            List<DTO_User> lst = BUS_User.GetAllUser();
            //foreach (var item in lst)
            //{
            //    if (item.Sex)
            //    {
            //        dgvListAcc.Columns[]
            //    }
            //}

            dgvListNV.DataSource = BUS_User.GetAllUser();
        }

        private void dgvListAcc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvListNV.Columns[e.ColumnIndex].Name.Equals("sex"))
            {
                bool a = (bool)e.Value;
                if (a)
                {
                    e.Value = "Nam";
                }
                else if (!a)
                {
                    e.Value = "Nữ";
                }
            }

            if (dgvListNV.Columns[e.ColumnIndex].Name.Equals("ngaysinh"))
            {
                e.Value = ((DateTime)e.Value).ToString("dd/MM/yyyy");
            }

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dgvListAcc.Columns["sex"].);
        }
    }
}
