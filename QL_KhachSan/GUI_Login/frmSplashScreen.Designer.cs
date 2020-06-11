namespace QL_KhachSan
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.circle = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 717);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1437, 31);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Violet;
            this.panel2.Location = new System.Drawing.Point(0, 717);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 31);
            this.panel2.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 35;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 642);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đang khởi chạy ...";
            // 
            // circle
            // 
            this.circle.animated = true;
            this.circle.animationIterval = 20;
            this.circle.animationSpeed = 20;
            this.circle.BackColor = System.Drawing.Color.Transparent;
            this.circle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circle.BackgroundImage")));
            this.circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.circle.ForeColor = System.Drawing.Color.Magenta;
            this.circle.LabelVisible = true;
            this.circle.LineProgressThickness = 8;
            this.circle.LineThickness = 5;
            this.circle.Location = new System.Drawing.Point(1108, 106);
            this.circle.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.circle.MaxValue = 600;
            this.circle.Name = "circle";
            this.circle.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circle.ProgressColor = System.Drawing.Color.Magenta;
            this.circle.Size = new System.Drawing.Size(201, 201);
            this.circle.TabIndex = 3;
            this.circle.Value = 0;
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BackgroundImage = global::QL_KhachSan.Properties.Resources.splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1437, 748);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khởi tạo chương trình";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circle;
    }
}