namespace QL_KhachSan
{
    partial class frmAddAcc
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
            this.txtPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPassRepeat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.showPASS = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbChucVu = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAccept = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.showPASS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtPass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtPass.BorderColorIdle = System.Drawing.Color.Magenta;
            this.txtPass.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPass.BorderThickness = 1;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass.isPassword = true;
            this.txtPass.Location = new System.Drawing.Point(53, 433);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(351, 44);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "pass";
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassRepeat
            // 
            this.txtPassRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtPassRepeat.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtPassRepeat.BorderColorIdle = System.Drawing.Color.Magenta;
            this.txtPassRepeat.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPassRepeat.BorderThickness = 1;
            this.txtPassRepeat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPassRepeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassRepeat.isPassword = true;
            this.txtPassRepeat.Location = new System.Drawing.Point(53, 293);
            this.txtPassRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassRepeat.Name = "txtPassRepeat";
            this.txtPassRepeat.Size = new System.Drawing.Size(351, 44);
            this.txtPassRepeat.TabIndex = 1;
            this.txtPassRepeat.Text = "PASS RE";
            this.txtPassRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(144, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số CMND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(47, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(47, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pass";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(47, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhập Lại Pass";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtTenDangNhap.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtTenDangNhap.BorderColorIdle = System.Drawing.Color.Magenta;
            this.txtTenDangNhap.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTenDangNhap.BorderThickness = 1;
            this.txtTenDangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenDangNhap.isPassword = false;
            this.txtTenDangNhap.Location = new System.Drawing.Point(53, 184);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(351, 44);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.Text = "PASS RE";
            this.txtTenDangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // showPASS
            // 
            this.showPASS.BackColor = System.Drawing.Color.Transparent;
            this.showPASS.Image = global::QL_KhachSan.Properties.Resources.eye__1_;
            this.showPASS.Location = new System.Drawing.Point(350, 344);
            this.showPASS.Name = "showPASS";
            this.showPASS.Size = new System.Drawing.Size(54, 45);
            this.showPASS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPASS.TabIndex = 5;
            this.showPASS.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(47, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 33);
            this.label5.TabIndex = 2;
            this.label5.Text = "Chức Vụ";
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.BackColor = System.Drawing.Color.Transparent;
            this.cbbChucVu.BorderRadius = 3;
            this.cbbChucVu.ForeColor = System.Drawing.Color.White;
            this.cbbChucVu.Items = new string[0];
            this.cbbChucVu.Location = new System.Drawing.Point(53, 567);
            this.cbbChucVu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.NomalColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbChucVu.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cbbChucVu.selectedIndex = -1;
            this.cbbChucVu.Size = new System.Drawing.Size(351, 43);
            this.cbbChucVu.TabIndex = 6;
            this.cbbChucVu.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            // 
            // txtCMND
            // 
            this.txtCMND.BackColor = System.Drawing.Color.DarkOrange;
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(105, 73);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(240, 39);
            this.txtCMND.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::QL_KhachSan.Properties.Resources.multiply_60px;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(244, 639);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 52);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 25;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Transparent;
            this.btnAccept.Image = global::QL_KhachSan.Properties.Resources.checkmark_96px;
            this.btnAccept.ImageActive = null;
            this.btnAccept.Location = new System.Drawing.Point(114, 639);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(76, 52);
            this.btnAccept.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAccept.TabIndex = 14;
            this.btnAccept.TabStop = false;
            this.btnAccept.Zoom = 25;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // frmAddAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(460, 721);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.cbbChucVu);
            this.Controls.Add(this.showPASS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.txtPassRepeat);
            this.Controls.Add(this.txtPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "r";
            this.Load += new System.EventHandler(this.frmAddAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showPASS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPass;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPassRepeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTenDangNhap;
        private System.Windows.Forms.PictureBox showPASS;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDropdown cbbChucVu;
        private System.Windows.Forms.TextBox txtCMND;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnAccept;
    }
}