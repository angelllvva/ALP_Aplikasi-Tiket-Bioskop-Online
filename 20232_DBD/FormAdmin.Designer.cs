namespace _20232_DBD
{
    partial class FormAdmin
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
            this.menuStrip_home = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_homeAdmin = new System.Windows.Forms.Panel();
            this.pnl_filmAdmin = new System.Windows.Forms.Panel();
            this.pnl_scheduleAdmin = new System.Windows.Forms.Panel();
            this.pnl_transactionsAdmin = new System.Windows.Forms.Panel();
            this.pnl_userAdmin = new System.Windows.Forms.Panel();
            this.pnl_addFilmAdmin = new System.Windows.Forms.Panel();
            this.menuStrip_home.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_home
            // 
            this.menuStrip_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuStrip_home.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip_home.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_home.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.filmToolStripMenuItem,
            this.addFilmToolStripMenuItem,
            this.scheduleToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.userToolStripMenuItem,
            this.logOutToolStripMenuItem1});
            this.menuStrip_home.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_home.Name = "menuStrip_home";
            this.menuStrip_home.Size = new System.Drawing.Size(869, 32);
            this.menuStrip_home.TabIndex = 29;
            this.menuStrip_home.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.NavajoWhite;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // filmToolStripMenuItem
            // 
            this.filmToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmToolStripMenuItem.ForeColor = System.Drawing.Color.NavajoWhite;
            this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            this.filmToolStripMenuItem.Size = new System.Drawing.Size(92, 26);
            this.filmToolStripMenuItem.Text = "Film List";
            this.filmToolStripMenuItem.Click += new System.EventHandler(this.filmToolStripMenuItem_Click);
            // 
            // addFilmToolStripMenuItem
            // 
            this.addFilmToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFilmToolStripMenuItem.ForeColor = System.Drawing.Color.NavajoWhite;
            this.addFilmToolStripMenuItem.Name = "addFilmToolStripMenuItem";
            this.addFilmToolStripMenuItem.Size = new System.Drawing.Size(96, 28);
            this.addFilmToolStripMenuItem.Text = "Add Film";
            this.addFilmToolStripMenuItem.Click += new System.EventHandler(this.addFilmToolStripMenuItem_Click);
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleToolStripMenuItem.ForeColor = System.Drawing.Color.NavajoWhite;
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(101, 26);
            this.scheduleToolStripMenuItem.Text = "Schedule";
            this.scheduleToolStripMenuItem.Click += new System.EventHandler(this.scheduleToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionsToolStripMenuItem.ForeColor = System.Drawing.Color.NavajoWhite;
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userToolStripMenuItem.ForeColor = System.Drawing.Color.NavajoWhite;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(90, 26);
            this.logOutToolStripMenuItem1.Text = "Log Out";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // pnl_homeAdmin
            // 
            this.pnl_homeAdmin.Location = new System.Drawing.Point(0, 27);
            this.pnl_homeAdmin.Name = "pnl_homeAdmin";
            this.pnl_homeAdmin.Size = new System.Drawing.Size(869, 495);
            this.pnl_homeAdmin.TabIndex = 32;
            this.pnl_homeAdmin.Visible = false;
            // 
            // pnl_filmAdmin
            // 
            this.pnl_filmAdmin.Location = new System.Drawing.Point(0, 27);
            this.pnl_filmAdmin.Name = "pnl_filmAdmin";
            this.pnl_filmAdmin.Size = new System.Drawing.Size(880, 495);
            this.pnl_filmAdmin.TabIndex = 34;
            this.pnl_filmAdmin.Visible = false;
            // 
            // pnl_scheduleAdmin
            // 
            this.pnl_scheduleAdmin.Location = new System.Drawing.Point(0, 27);
            this.pnl_scheduleAdmin.Name = "pnl_scheduleAdmin";
            this.pnl_scheduleAdmin.Size = new System.Drawing.Size(895, 507);
            this.pnl_scheduleAdmin.TabIndex = 35;
            this.pnl_scheduleAdmin.Visible = false;
            // 
            // pnl_transactionsAdmin
            // 
            this.pnl_transactionsAdmin.Location = new System.Drawing.Point(0, 27);
            this.pnl_transactionsAdmin.Name = "pnl_transactionsAdmin";
            this.pnl_transactionsAdmin.Size = new System.Drawing.Size(901, 512);
            this.pnl_transactionsAdmin.TabIndex = 36;
            // 
            // pnl_userAdmin
            // 
            this.pnl_userAdmin.Location = new System.Drawing.Point(0, 27);
            this.pnl_userAdmin.Name = "pnl_userAdmin";
            this.pnl_userAdmin.Size = new System.Drawing.Size(910, 526);
            this.pnl_userAdmin.TabIndex = 37;
            // 
            // pnl_addFilmAdmin
            // 
            this.pnl_addFilmAdmin.Location = new System.Drawing.Point(0, 27);
            this.pnl_addFilmAdmin.Name = "pnl_addFilmAdmin";
            this.pnl_addFilmAdmin.Size = new System.Drawing.Size(921, 673);
            this.pnl_addFilmAdmin.TabIndex = 39;
            this.pnl_addFilmAdmin.Visible = false;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 518);
            this.Controls.Add(this.menuStrip_home);
            this.Controls.Add(this.pnl_addFilmAdmin);
            this.Controls.Add(this.pnl_userAdmin);
            this.Controls.Add(this.pnl_transactionsAdmin);
            this.Controls.Add(this.pnl_scheduleAdmin);
            this.Controls.Add(this.pnl_filmAdmin);
            this.Controls.Add(this.pnl_homeAdmin);
            this.IsMdiContainer = true;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.menuStrip_home.ResumeLayout(false);
            this.menuStrip_home.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_home;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.Panel pnl_homeAdmin;
        private System.Windows.Forms.Panel pnl_filmAdmin;
        private System.Windows.Forms.Panel pnl_scheduleAdmin;
        private System.Windows.Forms.Panel pnl_transactionsAdmin;
        private System.Windows.Forms.Panel pnl_userAdmin;
        private System.Windows.Forms.ToolStripMenuItem addFilmToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_addFilmAdmin;
    }
}