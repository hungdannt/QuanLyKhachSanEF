namespace QL_KhachSan.GUI_Admin
{
    partial class UCHome
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHome));
            this.circleSLTaiKhoan = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtSLKinhDoanh = new System.Windows.Forms.Label();
            this.txtSLLeTan = new System.Windows.Forms.Label();
            this.txtSLAdmin = new System.Windows.Forms.Label();
            this.txtSLNhanVien = new System.Windows.Forms.Label();
            this.txtKinhDoanh = new System.Windows.Forms.Label();
            this.txtLeTan = new System.Windows.Forms.Label();
            this.txtAdmin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtSLTK = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // circleSLTaiKhoan
            // 
            this.circleSLTaiKhoan.animated = true;
            this.circleSLTaiKhoan.animationIterval = 100;
            this.circleSLTaiKhoan.animationSpeed = 300;
            this.circleSLTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.circleSLTaiKhoan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleSLTaiKhoan.BackgroundImage")));
            this.circleSLTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.circleSLTaiKhoan.ForeColor = System.Drawing.Color.SeaGreen;
            this.circleSLTaiKhoan.LabelVisible = false;
            this.circleSLTaiKhoan.LineProgressThickness = 10;
            this.circleSLTaiKhoan.LineThickness = 10;
            this.circleSLTaiKhoan.Location = new System.Drawing.Point(504, 484);
            this.circleSLTaiKhoan.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.circleSLTaiKhoan.MaxValue = 100;
            this.circleSLTaiKhoan.Name = "circleSLTaiKhoan";
            this.circleSLTaiKhoan.ProgressBackColor = System.Drawing.Color.Blue;
            this.circleSLTaiKhoan.ProgressColor = System.Drawing.Color.Fuchsia;
            this.circleSLTaiKhoan.Size = new System.Drawing.Size(224, 224);
            this.circleSLTaiKhoan.TabIndex = 0;
            this.circleSLTaiKhoan.Value = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.txtSLKinhDoanh);
            this.panel1.Controls.Add(this.txtSLLeTan);
            this.panel1.Controls.Add(this.txtSLAdmin);
            this.panel1.Controls.Add(this.txtSLNhanVien);
            this.panel1.Controls.Add(this.txtKinhDoanh);
            this.panel1.Controls.Add(this.txtLeTan);
            this.panel1.Controls.Add(this.txtAdmin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(27, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 383);
            this.panel1.TabIndex = 1;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(90, 192);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(351, 23);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            this.bunifuSeparator1.Load += new System.EventHandler(this.bunifuSeparator1_Load);
            // 
            // txtSLKinhDoanh
            // 
            this.txtSLKinhDoanh.BackColor = System.Drawing.Color.Transparent;
            this.txtSLKinhDoanh.Font = new System.Drawing.Font("Yu Gothic Light", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLKinhDoanh.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtSLKinhDoanh.Location = new System.Drawing.Point(389, 256);
            this.txtSLKinhDoanh.Name = "txtSLKinhDoanh";
            this.txtSLKinhDoanh.Size = new System.Drawing.Size(100, 58);
            this.txtSLKinhDoanh.TabIndex = 0;
            this.txtSLKinhDoanh.Text = "100";
            this.txtSLKinhDoanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSLLeTan
            // 
            this.txtSLLeTan.BackColor = System.Drawing.Color.Transparent;
            this.txtSLLeTan.Font = new System.Drawing.Font("Yu Gothic Light", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLLeTan.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtSLLeTan.Location = new System.Drawing.Point(219, 256);
            this.txtSLLeTan.Name = "txtSLLeTan";
            this.txtSLLeTan.Size = new System.Drawing.Size(100, 58);
            this.txtSLLeTan.TabIndex = 0;
            this.txtSLLeTan.Text = "100";
            this.txtSLLeTan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSLAdmin
            // 
            this.txtSLAdmin.BackColor = System.Drawing.Color.Transparent;
            this.txtSLAdmin.Font = new System.Drawing.Font("Yu Gothic Light", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLAdmin.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtSLAdmin.Location = new System.Drawing.Point(41, 256);
            this.txtSLAdmin.Name = "txtSLAdmin";
            this.txtSLAdmin.Size = new System.Drawing.Size(100, 58);
            this.txtSLAdmin.TabIndex = 0;
            this.txtSLAdmin.Text = "100";
            this.txtSLAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSLNhanVien
            // 
            this.txtSLNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.txtSLNhanVien.Font = new System.Drawing.Font("Yu Gothic Light", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLNhanVien.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtSLNhanVien.Location = new System.Drawing.Point(188, 111);
            this.txtSLNhanVien.Name = "txtSLNhanVien";
            this.txtSLNhanVien.Size = new System.Drawing.Size(150, 58);
            this.txtSLNhanVien.TabIndex = 0;
            this.txtSLNhanVien.Text = "54";
            this.txtSLNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKinhDoanh
            // 
            this.txtKinhDoanh.AutoSize = true;
            this.txtKinhDoanh.Font = new System.Drawing.Font("Yu Gothic Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKinhDoanh.Location = new System.Drawing.Point(363, 324);
            this.txtKinhDoanh.Name = "txtKinhDoanh";
            this.txtKinhDoanh.Size = new System.Drawing.Size(147, 34);
            this.txtKinhDoanh.TabIndex = 0;
            this.txtKinhDoanh.Text = "Kinh Doanh";
            // 
            // txtLeTan
            // 
            this.txtLeTan.AutoSize = true;
            this.txtLeTan.Font = new System.Drawing.Font("Yu Gothic Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeTan.Location = new System.Drawing.Point(223, 324);
            this.txtLeTan.Name = "txtLeTan";
            this.txtLeTan.Size = new System.Drawing.Size(90, 34);
            this.txtLeTan.TabIndex = 0;
            this.txtLeTan.Text = "Lê Tân";
            // 
            // txtAdmin
            // 
            this.txtAdmin.AutoSize = true;
            this.txtAdmin.Font = new System.Drawing.Font("Yu Gothic Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmin.Location = new System.Drawing.Point(45, 324);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(86, 34);
            this.txtAdmin.TabIndex = 0;
            this.txtAdmin.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân Viên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bunifuSeparator2);
            this.panel2.Controls.Add(this.txtSLTK);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(697, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 383);
            this.panel2.TabIndex = 1;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(104, 233);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(351, 23);
            this.bunifuSeparator2.TabIndex = 2;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            this.bunifuSeparator2.Load += new System.EventHandler(this.bunifuSeparator1_Load);
            // 
            // txtSLTK
            // 
            this.txtSLTK.BackColor = System.Drawing.Color.Transparent;
            this.txtSLTK.Font = new System.Drawing.Font("Yu Gothic Light", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLTK.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtSLTK.Location = new System.Drawing.Point(221, 128);
            this.txtSLTK.Name = "txtSLTK";
            this.txtSLTK.Size = new System.Drawing.Size(100, 58);
            this.txtSLTK.TabIndex = 0;
            this.txtSLTK.Text = "100";
            this.txtSLTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SeaGreen;
            this.label10.Location = new System.Drawing.Point(187, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 35);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tài  Khoản";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(527, 717);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Live Update";
            // 
            // UCHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.circleSLTaiKhoan);
            this.Controls.Add(this.label2);
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(1279, 801);
            this.Load += new System.EventHandler(this.UCHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar circleSLTaiKhoan;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtSLNhanVien;
        private System.Windows.Forms.Label txtSLKinhDoanh;
        private System.Windows.Forms.Label txtSLLeTan;
        private System.Windows.Forms.Label txtSLAdmin;
        private System.Windows.Forms.Label txtKinhDoanh;
        private System.Windows.Forms.Label txtLeTan;
        private System.Windows.Forms.Label txtAdmin;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label txtSLTK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}
