namespace _20232_DBD
{
    partial class FormMain
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
            this.lb_filmName = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_hello = new System.Windows.Forms.Label();
            this.lb_nowShowing = new System.Windows.Forms.Label();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_home = new System.Windows.Forms.MenuStrip();
            this.btn_more = new System.Windows.Forms.Button();
            this.pBox_filmPoster = new System.Windows.Forms.PictureBox();
            this.pnl_more = new System.Windows.Forms.Panel();
            this.lb_filmInformation = new System.Windows.Forms.Label();
            this.pBox_backFilmInformation = new System.Windows.Forms.PictureBox();
            this.btn_buyTicket = new System.Windows.Forms.Button();
            this.lb_genreText = new System.Windows.Forms.Label();
            this.lb_durationText = new System.Windows.Forms.Label();
            this.lb_directorText = new System.Windows.Forms.Label();
            this.lb_descriptionText = new System.Windows.Forms.Label();
            this.lb_description = new System.Windows.Forms.Label();
            this.lb_director = new System.Windows.Forms.Label();
            this.lb_duration = new System.Windows.Forms.Label();
            this.lb_genre = new System.Windows.Forms.Label();
            this.lb_filmNameInformation = new System.Windows.Forms.Label();
            this.pBox_filmPosterInformation = new System.Windows.Forms.PictureBox();
            this.pBox_backHistory = new System.Windows.Forms.PictureBox();
            this.lb_transactionHistory = new System.Windows.Forms.Label();
            this.dgv_transactionHistory = new System.Windows.Forms.DataGridView();
            this.lb_doubleClick = new System.Windows.Forms.Label();
            this.pnl_history = new System.Windows.Forms.Panel();
            this.menuStrip_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_filmPoster)).BeginInit();
            this.pnl_more.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_backFilmInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_filmPosterInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_backHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transactionHistory)).BeginInit();
            this.pnl_history.SuspendLayout();
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
            // lb_filmName
            // 
            this.lb_filmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_filmName.Location = new System.Drawing.Point(220, 428);
            this.lb_filmName.Name = "lb_filmName";
            this.lb_filmName.Size = new System.Drawing.Size(419, 26);
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
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyToolStripMenuItem.ForeColor = System.Drawing.Color.NavajoWhite;
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(82, 26);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileToolStripMenuItem.ForeColor = System.Drawing.Color.NavajoWhite;
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.NavajoWhite;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(90, 26);
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
            this.menuStrip_home.Size = new System.Drawing.Size(869, 36);
            this.menuStrip_home.TabIndex = 28;
            this.menuStrip_home.Text = "menuStrip1";
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
            this.btn_more.Click += new System.EventHandler(this.btn_more_Click);
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
            // pnl_more
            // 
            this.pnl_more.Controls.Add(this.lb_filmInformation);
            this.pnl_more.Controls.Add(this.pBox_backFilmInformation);
            this.pnl_more.Controls.Add(this.btn_buyTicket);
            this.pnl_more.Controls.Add(this.lb_genreText);
            this.pnl_more.Controls.Add(this.lb_durationText);
            this.pnl_more.Controls.Add(this.lb_directorText);
            this.pnl_more.Controls.Add(this.lb_descriptionText);
            this.pnl_more.Controls.Add(this.lb_description);
            this.pnl_more.Controls.Add(this.lb_director);
            this.pnl_more.Controls.Add(this.lb_duration);
            this.pnl_more.Controls.Add(this.lb_genre);
            this.pnl_more.Controls.Add(this.lb_filmNameInformation);
            this.pnl_more.Controls.Add(this.pBox_filmPosterInformation);
            this.pnl_more.Location = new System.Drawing.Point(0, 39);
            this.pnl_more.Name = "pnl_more";
            this.pnl_more.Size = new System.Drawing.Size(869, 480);
            this.pnl_more.TabIndex = 39;
            this.pnl_more.Visible = false;
            // 
            // lb_filmInformation
            // 
            this.lb_filmInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_filmInformation.Location = new System.Drawing.Point(78, 10);
            this.lb_filmInformation.Name = "lb_filmInformation";
            this.lb_filmInformation.Size = new System.Drawing.Size(225, 31);
            this.lb_filmInformation.TabIndex = 45;
            this.lb_filmInformation.Text = "Film Information";
            this.lb_filmInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pBox_backFilmInformation
            // 
            this.pBox_backFilmInformation.Image = global::_20232_DBD.Properties.Resources.Arrow_1;
            this.pBox_backFilmInformation.Location = new System.Drawing.Point(29, 14);
            this.pBox_backFilmInformation.Name = "pBox_backFilmInformation";
            this.pBox_backFilmInformation.Size = new System.Drawing.Size(29, 23);
            this.pBox_backFilmInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_backFilmInformation.TabIndex = 44;
            this.pBox_backFilmInformation.TabStop = false;
            this.pBox_backFilmInformation.Click += new System.EventHandler(this.pBox_backFilmInformation_Click);
            // 
            // btn_buyTicket
            // 
            this.btn_buyTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_buyTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buyTicket.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btn_buyTicket.Location = new System.Drawing.Point(361, 420);
            this.btn_buyTicket.Name = "btn_buyTicket";
            this.btn_buyTicket.Size = new System.Drawing.Size(132, 35);
            this.btn_buyTicket.TabIndex = 43;
            this.btn_buyTicket.Text = "Buy Ticket";
            this.btn_buyTicket.UseVisualStyleBackColor = false;
            // 
            // lb_genreText
            // 
            this.lb_genreText.AutoSize = true;
            this.lb_genreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_genreText.Location = new System.Drawing.Point(408, 90);
            this.lb_genreText.Name = "lb_genreText";
            this.lb_genreText.Size = new System.Drawing.Size(88, 20);
            this.lb_genreText.TabIndex = 42;
            this.lb_genreText.Text = "Genre Text";
            this.lb_genreText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_durationText
            // 
            this.lb_durationText.AutoSize = true;
            this.lb_durationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_durationText.Location = new System.Drawing.Point(424, 115);
            this.lb_durationText.Name = "lb_durationText";
            this.lb_durationText.Size = new System.Drawing.Size(104, 20);
            this.lb_durationText.TabIndex = 41;
            this.lb_durationText.Text = "Duration Text";
            this.lb_durationText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_directorText
            // 
            this.lb_directorText.AutoSize = true;
            this.lb_directorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_directorText.Location = new System.Drawing.Point(419, 141);
            this.lb_directorText.Name = "lb_directorText";
            this.lb_directorText.Size = new System.Drawing.Size(99, 20);
            this.lb_directorText.TabIndex = 40;
            this.lb_directorText.Text = "Director Text";
            this.lb_directorText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_descriptionText
            // 
            this.lb_descriptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_descriptionText.Location = new System.Drawing.Point(340, 191);
            this.lb_descriptionText.Name = "lb_descriptionText";
            this.lb_descriptionText.Size = new System.Drawing.Size(495, 169);
            this.lb_descriptionText.TabIndex = 39;
            this.lb_descriptionText.Text = "Description Text";
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_description.Location = new System.Drawing.Point(340, 166);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(97, 20);
            this.lb_description.TabIndex = 38;
            this.lb_description.Text = "Description :";
            this.lb_description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_director
            // 
            this.lb_director.AutoSize = true;
            this.lb_director.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_director.Location = new System.Drawing.Point(340, 141);
            this.lb_director.Name = "lb_director";
            this.lb_director.Size = new System.Drawing.Size(73, 20);
            this.lb_director.TabIndex = 37;
            this.lb_director.Text = "Director :";
            this.lb_director.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_duration
            // 
            this.lb_duration.AutoSize = true;
            this.lb_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_duration.Location = new System.Drawing.Point(340, 115);
            this.lb_duration.Name = "lb_duration";
            this.lb_duration.Size = new System.Drawing.Size(78, 20);
            this.lb_duration.TabIndex = 36;
            this.lb_duration.Text = "Duration :";
            this.lb_duration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_genre
            // 
            this.lb_genre.AutoSize = true;
            this.lb_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_genre.Location = new System.Drawing.Point(340, 90);
            this.lb_genre.Name = "lb_genre";
            this.lb_genre.Size = new System.Drawing.Size(62, 20);
            this.lb_genre.TabIndex = 35;
            this.lb_genre.Text = "Genre :";
            this.lb_genre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_filmNameInformation
            // 
            this.lb_filmNameInformation.AutoSize = true;
            this.lb_filmNameInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_filmNameInformation.Location = new System.Drawing.Point(340, 56);
            this.lb_filmNameInformation.Name = "lb_filmNameInformation";
            this.lb_filmNameInformation.Size = new System.Drawing.Size(114, 22);
            this.lb_filmNameInformation.TabIndex = 34;
            this.lb_filmNameInformation.Text = "FILM NAME";
            this.lb_filmNameInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pBox_filmPosterInformation
            // 
            this.pBox_filmPosterInformation.Location = new System.Drawing.Point(83, 60);
            this.pBox_filmPosterInformation.Name = "pBox_filmPosterInformation";
            this.pBox_filmPosterInformation.Size = new System.Drawing.Size(225, 300);
            this.pBox_filmPosterInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_filmPosterInformation.TabIndex = 33;
            this.pBox_filmPosterInformation.TabStop = false;
            // 
            // pBox_backHistory
            // 
            this.pBox_backHistory.Image = global::_20232_DBD.Properties.Resources.Arrow_1;
            this.pBox_backHistory.Location = new System.Drawing.Point(39, 40);
            this.pBox_backHistory.Name = "pBox_backHistory";
            this.pBox_backHistory.Size = new System.Drawing.Size(29, 23);
            this.pBox_backHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_backHistory.TabIndex = 48;
            this.pBox_backHistory.TabStop = false;
            this.pBox_backHistory.Click += new System.EventHandler(this.pBox_backHistory_Click);
            // 
            // lb_transactionHistory
            // 
            this.lb_transactionHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_transactionHistory.Location = new System.Drawing.Point(88, 36);
            this.lb_transactionHistory.Name = "lb_transactionHistory";
            this.lb_transactionHistory.Size = new System.Drawing.Size(269, 31);
            this.lb_transactionHistory.TabIndex = 49;
            this.lb_transactionHistory.Text = "Transaction History";
            this.lb_transactionHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_transactionHistory
            // 
            this.dgv_transactionHistory.AllowUserToAddRows = false;
            this.dgv_transactionHistory.AllowUserToDeleteRows = false;
            this.dgv_transactionHistory.AllowUserToResizeColumns = false;
            this.dgv_transactionHistory.AllowUserToResizeRows = false;
            this.dgv_transactionHistory.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_transactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transactionHistory.Location = new System.Drawing.Point(93, 80);
            this.dgv_transactionHistory.Name = "dgv_transactionHistory";
            this.dgv_transactionHistory.RowHeadersWidth = 62;
            this.dgv_transactionHistory.RowTemplate.Height = 28;
            this.dgv_transactionHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_transactionHistory.Size = new System.Drawing.Size(752, 379);
            this.dgv_transactionHistory.TabIndex = 50;
            this.dgv_transactionHistory.DoubleClick += new System.EventHandler(this.dgv_transactionHistory_DoubleClick);
            // 
            // lb_doubleClick
            // 
            this.lb_doubleClick.AutoSize = true;
            this.lb_doubleClick.Location = new System.Drawing.Point(89, 466);
            this.lb_doubleClick.Name = "lb_doubleClick";
            this.lb_doubleClick.Size = new System.Drawing.Size(278, 20);
            this.lb_doubleClick.TabIndex = 51;
            this.lb_doubleClick.Text = "*Double Click on a Row to See Details";
            // 
            // pnl_history
            // 
            this.pnl_history.Controls.Add(this.lb_doubleClick);
            this.pnl_history.Controls.Add(this.dgv_transactionHistory);
            this.pnl_history.Controls.Add(this.lb_transactionHistory);
            this.pnl_history.Controls.Add(this.pBox_backHistory);
            this.pnl_history.Location = new System.Drawing.Point(-10, 12);
            this.pnl_history.Name = "pnl_history";
            this.pnl_history.Size = new System.Drawing.Size(900, 530);
            this.pnl_history.TabIndex = 48;
            this.pnl_history.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 518);
            this.Controls.Add(this.menuStrip_home);
            this.Controls.Add(this.pnl_history);
            this.Controls.Add(this.pnl_more);
            this.Controls.Add(this.btn_kiri);
            this.Controls.Add(this.btn_kanan);
            this.Controls.Add(this.btn_more);
            this.Controls.Add(this.lb_filmName);
            this.Controls.Add(this.pBox_filmPoster);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.lb_hello);
            this.Controls.Add(this.lb_nowShowing);
            this.MaximumSize = new System.Drawing.Size(891, 574);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.menuStrip_home.ResumeLayout(false);
            this.menuStrip_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_filmPoster)).EndInit();
            this.pnl_more.ResumeLayout(false);
            this.pnl_more.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_backFilmInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_filmPosterInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_backHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transactionHistory)).EndInit();
            this.pnl_history.ResumeLayout(false);
            this.pnl_history.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_kiri;
        private System.Windows.Forms.Button btn_kanan;
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
        private System.Windows.Forms.Button btn_more;
        private System.Windows.Forms.Panel pnl_more;
        private System.Windows.Forms.Label lb_filmInformation;
        private System.Windows.Forms.PictureBox pBox_backFilmInformation;
        private System.Windows.Forms.Button btn_buyTicket;
        private System.Windows.Forms.Label lb_genreText;
        private System.Windows.Forms.Label lb_durationText;
        private System.Windows.Forms.Label lb_directorText;
        private System.Windows.Forms.Label lb_descriptionText;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.Label lb_director;
        private System.Windows.Forms.Label lb_duration;
        private System.Windows.Forms.Label lb_genre;
        private System.Windows.Forms.Label lb_filmNameInformation;
        private System.Windows.Forms.PictureBox pBox_filmPosterInformation;
        private System.Windows.Forms.PictureBox pBox_backHistory;
        private System.Windows.Forms.Label lb_transactionHistory;
        private System.Windows.Forms.DataGridView dgv_transactionHistory;
        private System.Windows.Forms.Label lb_doubleClick;
        private System.Windows.Forms.Panel pnl_history;
    }
}