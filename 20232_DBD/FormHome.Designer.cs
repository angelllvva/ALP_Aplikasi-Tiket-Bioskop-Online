namespace _20232_DBD
{
    partial class FormHome
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
            this.btn_kiri = new System.Windows.Forms.Button();
            this.btn_kanan = new System.Windows.Forms.Button();
            this.btn_more = new System.Windows.Forms.Button();
            this.lb_filmName = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_hello = new System.Windows.Forms.Label();
            this.lb_nowShowing = new System.Windows.Forms.Label();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_home = new System.Windows.Forms.MenuStrip();
            this.pBox_filmPoster = new System.Windows.Forms.PictureBox();
            this.menuStrip_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_filmPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kiri
            // 
            this.btn_kiri.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_kiri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kiri.ForeColor = System.Drawing.Color.Black;
            this.btn_kiri.Location = new System.Drawing.Point(29, 256);
            this.btn_kiri.Name = "btn_kiri";
            this.btn_kiri.Size = new System.Drawing.Size(91, 35);
            this.btn_kiri.TabIndex = 36;
            this.btn_kiri.Text = "<<";
            this.btn_kiri.UseVisualStyleBackColor = false;
            this.btn_kiri.Click += new System.EventHandler(this.btn_kiri_Click);
            // 
            // btn_kanan
            // 
            this.btn_kanan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_kanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kanan.ForeColor = System.Drawing.Color.Black;
            this.btn_kanan.Location = new System.Drawing.Point(744, 256);
            this.btn_kanan.Name = "btn_kanan";
            this.btn_kanan.Size = new System.Drawing.Size(91, 35);
            this.btn_kanan.TabIndex = 35;
            this.btn_kanan.Text = ">>";
            this.btn_kanan.UseVisualStyleBackColor = false;
            this.btn_kanan.Click += new System.EventHandler(this.btn_kanan_Click);
            // 
            // btn_more
            // 
            this.btn_more.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_more.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_more.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btn_more.Location = new System.Drawing.Point(361, 458);
            this.btn_more.Name = "btn_more";
            this.btn_more.Size = new System.Drawing.Size(132, 35);
            this.btn_more.TabIndex = 34;
            this.btn_more.Text = "More";
            this.btn_more.UseVisualStyleBackColor = false;
            // 
            // lb_filmName
            // 
            this.lb_filmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_filmName.Location = new System.Drawing.Point(278, 429);
            this.lb_filmName.Name = "lb_filmName";
            this.lb_filmName.Size = new System.Drawing.Size(298, 25);
            this.lb_filmName.TabIndex = 33;
            this.lb_filmName.Text = "Film Name";
            this.lb_filmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.Location = new System.Drawing.Point(84, 50);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(119, 25);
            this.lb_user.TabIndex = 31;
            this.lb_user.Text = "User Name";
            // 
            // lb_hello
            // 
            this.lb_hello.AutoSize = true;
            this.lb_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hello.Location = new System.Drawing.Point(24, 50);
            this.lb_hello.Name = "lb_hello";
            this.lb_hello.Size = new System.Drawing.Size(61, 25);
            this.lb_hello.TabIndex = 30;
            this.lb_hello.Text = "Hello,";
            // 
            // lb_nowShowing
            // 
            this.lb_nowShowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nowShowing.Location = new System.Drawing.Point(318, 82);
            this.lb_nowShowing.Name = "lb_nowShowing";
            this.lb_nowShowing.Size = new System.Drawing.Size(225, 31);
            this.lb_nowShowing.TabIndex = 29;
            this.lb_nowShowing.Text = "Now Showing";
            this.lb_nowShowing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.NavajoWhite;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(73, 32);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyToolStripMenuItem.ForeColor = System.Drawing.Color.NavajoWhite;
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(82, 32);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileToolStripMenuItem.ForeColor = System.Drawing.Color.NavajoWhite;
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(77, 32);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.NavajoWhite;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(90, 32);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // menuStrip_home
            // 
            this.menuStrip_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuStrip_home.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip_home.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_home.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip_home.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_home.Name = "menuStrip_home";
            this.menuStrip_home.Size = new System.Drawing.Size(869, 30);
            this.menuStrip_home.TabIndex = 28;
            this.menuStrip_home.Text = "menuStrip1";
            // 
            // pBox_filmPoster
            // 
            this.pBox_filmPoster.Location = new System.Drawing.Point(318, 120);
            this.pBox_filmPoster.Name = "pBox_filmPoster";
            this.pBox_filmPoster.Size = new System.Drawing.Size(225, 300);
            this.pBox_filmPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_filmPoster.TabIndex = 32;
            this.pBox_filmPoster.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 518);
            this.Controls.Add(this.menuStrip_home);
            this.Controls.Add(this.btn_kiri);
            this.Controls.Add(this.btn_kanan);
            this.Controls.Add(this.btn_more);
            this.Controls.Add(this.lb_filmName);
            this.Controls.Add(this.pBox_filmPoster);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.lb_hello);
            this.Controls.Add(this.lb_nowShowing);
            this.MaximumSize = new System.Drawing.Size(891, 574);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.menuStrip_home.ResumeLayout(false);
            this.menuStrip_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_filmPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_kiri;
        private System.Windows.Forms.Button btn_kanan;
        private System.Windows.Forms.Button btn_more;
        private System.Windows.Forms.Label lb_filmName;
        private System.Windows.Forms.PictureBox pBox_filmPoster;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_hello;
        private System.Windows.Forms.Label lb_nowShowing;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip_home;
    }
}