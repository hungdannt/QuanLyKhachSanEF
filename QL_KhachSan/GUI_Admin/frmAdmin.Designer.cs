namespace QL_KhachSan
{
    partial class frmAdmin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.botron = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.lbTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbAvatarName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetting = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDanhSach = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelmove = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelNV = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbDSNV = new System.Windows.Forms.Label();
            this.lbDSTK = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelmove)).BeginInit();
            this.panelNV.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // botron
            // 
            this.botron.ElipseRadius = 100;
            this.botron.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.bunifuProgressBar1);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnDanhSach);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.sidepanel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 855);
            this.panel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.panel5.Location = new System.Drawing.Point(283, 402);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(283, 399);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 9;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(3, 721);
            this.bunifuProgressBar1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(280, 13);
            this.bunifuProgressBar1.TabIndex = 8;
            this.bunifuProgressBar1.Value = 0;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Consolas", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(33, 769);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(169, 40);
            this.lbTime.TabIndex = 7;
            this.lbTime.Text = "00:00:00";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbAvatarName);
            this.panel3.Location = new System.Drawing.Point(3, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 41);
            this.panel3.TabIndex = 6;
            // 
            // lbAvatarName
            // 
            this.lbAvatarName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAvatarName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAvatarName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvatarName.Location = new System.Drawing.Point(0, 0);
            this.lbAvatarName.Name = "lbAvatarName";
            this.lbAvatarName.Size = new System.Drawing.Size(277, 41);
            this.lbAvatarName.TabIndex = 4;
            this.lbAvatarName.Text = "Dân Đẹp Trai";
            this.lbAvatarName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Xin Chào Admin !";
            // 
            // btnSetting
            // 
            this.btnSetting.Activecolor = System.Drawing.Color.DarkGreen;
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.BorderRadius = 0;
            this.btnSetting.ButtonText = "  Setting";
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.DisabledColor = System.Drawing.Color.Gray;
            this.btnSetting.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSetting.Iconimage = global::QL_KhachSan.Properties.Resources.settings_48px;
            this.btnSetting.Iconimage_right = null;
            this.btnSetting.Iconimage_right_Selected = null;
            this.btnSetting.Iconimage_Selected = null;
            this.btnSetting.IconMarginLeft = 0;
            this.btnSetting.IconMarginRight = 0;
            this.btnSetting.IconRightVisible = true;
            this.btnSetting.IconRightZoom = 0D;
            this.btnSetting.IconVisible = true;
            this.btnSetting.IconZoom = 70D;
            this.btnSetting.IsTab = false;
            this.btnSetting.Location = new System.Drawing.Point(15, 476);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSetting.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSetting.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSetting.selected = false;
            this.btnSetting.Size = new System.Drawing.Size(268, 89);
            this.btnSetting.TabIndex = 3;
            this.btnSetting.Text = "  Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Textcolor = System.Drawing.Color.White;
            this.btnSetting.TextFont = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Activecolor = System.Drawing.Color.DarkGreen;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.ButtonText = "  Logout";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogout.Iconimage = global::QL_KhachSan.Properties.Resources.logout_rounded_left_64px;
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 0;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = true;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = true;
            this.btnLogout.IconZoom = 70D;
            this.btnLogout.IsTab = false;
            this.btnLogout.Location = new System.Drawing.Point(15, 577);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(268, 89);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "  Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Textcolor = System.Drawing.Color.White;
            this.btnLogout.TextFont = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Activecolor = System.Drawing.Color.DarkGreen;
            this.btnDanhSach.BackColor = System.Drawing.Color.Transparent;
            this.btnDanhSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDanhSach.BorderRadius = 0;
            this.btnDanhSach.ButtonText = "   Danh Sách";
            this.btnDanhSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDanhSach.DisabledColor = System.Drawing.Color.Gray;
            this.btnDanhSach.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDanhSach.Iconimage = global::QL_KhachSan.Properties.Resources.menu_100px;
            this.btnDanhSach.Iconimage_right = null;
            this.btnDanhSach.Iconimage_right_Selected = null;
            this.btnDanhSach.Iconimage_Selected = null;
            this.btnDanhSach.IconMarginLeft = 0;
            this.btnDanhSach.IconMarginRight = 0;
            this.btnDanhSach.IconRightVisible = true;
            this.btnDanhSach.IconRightZoom = 0D;
            this.btnDanhSach.IconVisible = true;
            this.btnDanhSach.IconZoom = 50D;
            this.btnDanhSach.IsTab = false;
            this.btnDanhSach.Location = new System.Drawing.Point(15, 375);
            this.btnDanhSach.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDanhSach.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDanhSach.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDanhSach.selected = false;
            this.btnDanhSach.Size = new System.Drawing.Size(268, 89);
            this.btnDanhSach.TabIndex = 3;
            this.btnDanhSach.Text = "   Danh Sách";
            this.btnDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSach.Textcolor = System.Drawing.Color.White;
            this.btnDanhSach.TextFont = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.DarkGreen;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "  Home";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = global::QL_KhachSan.Properties.Resources.home_64px;
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 70D;
            this.btnHome.IsTab = false;
            this.btnHome.Location = new System.Drawing.Point(15, 274);
            this.btnHome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.selected = false;
            this.btnHome.Size = new System.Drawing.Size(268, 89);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "  Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.White;
            this.btnHome.TextFont = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.sidepanel.Location = new System.Drawing.Point(0, 275);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(15, 89);
            this.sidepanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QL_KhachSan.Properties.Resources.person;
            this.pictureBox1.Location = new System.Drawing.Point(71, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.Controls.Add(this.lbDate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panelmove);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(283, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1279, 54);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelmove_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelmove_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelmove_MouseUp);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Consolas", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(6, 9);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(153, 37);
            this.lbDate.TabIndex = 7;
            this.lbDate.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(792, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quản Lí Tài Khoản Hệ Thống";
            // 
            // panelmove
            // 
            this.panelmove.BackColor = System.Drawing.Color.Transparent;
            this.panelmove.Image = global::QL_KhachSan.Properties.Resources.move_96px;
            this.panelmove.Location = new System.Drawing.Point(1215, 5);
            this.panelmove.Name = "panelmove";
            this.panelmove.Size = new System.Drawing.Size(45, 43);
            this.panelmove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelmove.TabIndex = 1;
            this.panelmove.TabStop = false;
            this.panelmove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelmove_MouseDown);
            this.panelmove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelmove_MouseMove);
            this.panelmove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelmove_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelNV
            // 
            this.panelNV.Controls.Add(this.panel6);
            this.panelNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNV.Location = new System.Drawing.Point(283, 54);
            this.panelNV.Name = "panelNV";
            this.panelNV.Size = new System.Drawing.Size(1279, 801);
            this.panelNV.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.panel6.Controls.Add(this.lbDSNV);
            this.panel6.Controls.Add(this.lbDSTK);
            this.panel6.Location = new System.Drawing.Point(-1, 321);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(9, 92);
            this.panel6.TabIndex = 8;
            this.panel6.Visible = false;
            // 
            // lbDSNV
            // 
            this.lbDSNV.AutoSize = true;
            this.lbDSNV.BackColor = System.Drawing.Color.Transparent;
            this.lbDSNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSNV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDSNV.Location = new System.Drawing.Point(17, 52);
            this.lbDSNV.Name = "lbDSNV";
            this.lbDSNV.Size = new System.Drawing.Size(300, 31);
            this.lbDSNV.TabIndex = 0;
            this.lbDSNV.Text = "Danh Sách Nhân Viên";
            this.lbDSNV.Click += new System.EventHandler(this.lbDSNV_Click);
            // 
            // lbDSTK
            // 
            this.lbDSTK.AutoSize = true;
            this.lbDSTK.BackColor = System.Drawing.Color.Transparent;
            this.lbDSTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDSTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSTK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDSTK.Location = new System.Drawing.Point(17, 11);
            this.lbDSTK.Name = "lbDSTK";
            this.lbDSTK.Size = new System.Drawing.Size(297, 31);
            this.lbDSTK.TabIndex = 0;
            this.lbDSTK.Text = "Danh Sách Tài Khoản";
            this.lbDSTK.Click += new System.EventHandler(this.lbDSTK_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1562, 855);
            this.Controls.Add(this.panelNV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí tài khoản";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelmove)).EndInit();
            this.panelNV.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse botron;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private System.Windows.Forms.Panel sidepanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        private Bunifu.Framework.UI.BunifuFlatButton btnDanhSach;
        private System.Windows.Forms.Label lbAvatarName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnSetting;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox panelmove;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTime;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbDate;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private System.Windows.Forms.Panel panelNV;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbDSNV;
        private System.Windows.Forms.Label lbDSTK;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer2;
    }
}