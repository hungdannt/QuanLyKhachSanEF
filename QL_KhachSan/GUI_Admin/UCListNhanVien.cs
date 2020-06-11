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
using System.Threading;
using DTO;

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
            dgvListAcc.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvListAcc.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListAcc.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvListAcc.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvListAcc.BackgroundColor = Color.White;

            dgvListAcc.EnableHeadersVisualStyles = false;
            dgvListAcc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListAcc.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvListAcc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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


            var frm = new frmAddAcc(0);
            this.ParentForm.Opacity = .55;
            frm.ShowDialog();
            this.ParentForm.Opacity = 1;


            List<DTO_User> lst = BUS_User.GetAllUser();


        }

        private void dgvListAcc_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDel.Normalcolor = System.Drawing.Color.SkyBlue;
            btnEdit.Normalcolor = System.Drawing.Color.SkyBlue;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvListAcc.SelectedRows;
            if (r.Count == 1)
            {
                int key = Convert.ToInt32(r[0].Cells["Column1"].Value.ToString());
                try
                {
                    BUS_User.Delete(key);
                    Alert("Đã xóa thành công ^^", frmAlert.Type.Success);
                    dgvListAcc.DataSource = BUS_User.GetAllUser();
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
            DataGridViewSelectedRowCollection r = dgvListAcc.SelectedRows;
            if (r.Count == 1)
            {
                int key = Convert.ToInt32(r[0].Cells["Column1"].Value.ToString());
                var frm = new frmAddAcc(key);
                this.ParentForm.Opacity = .55;
                frm.ShowDialog();
                this.ParentForm.Opacity = 1;
                dgvListAcc.DataSource = BUS_User.GetAllUser();

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

            dgvListAcc.DataSource = BUS_User.GetAllUser();
        }
    }
}
