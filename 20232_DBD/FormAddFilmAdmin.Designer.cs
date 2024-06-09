namespace _20232_DBD
{
    partial class FormAddFilmAdmin
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
            this.lb_addFilm = new System.Windows.Forms.Label();
            this.date_endDate = new System.Windows.Forms.DateTimePicker();
            this.date_startDate = new System.Windows.Forms.DateTimePicker();
            this.tBox_castCharacter = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tBox_castName = new System.Windows.Forms.TextBox();
            this.lb_castName = new System.Windows.Forms.Label();
            this.tBox_description = new System.Windows.Forms.RichTextBox();
            this.tBox_director = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tBox_duration = new System.Windows.Forms.TextBox();
            this.tBox_filmName = new System.Windows.Forms.TextBox();
            this.lb_endDate = new System.Windows.Forms.Label();
            this.lb_startDate = new System.Windows.Forms.Label();
            this.lb_description = new System.Windows.Forms.Label();
            this.lb_director = new System.Windows.Forms.Label();
            this.lb_duration = new System.Windows.Forms.Label();
            this.lb_genre = new System.Windows.Forms.Label();
            this.btn_addFilm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_addCast = new System.Windows.Forms.Button();
            this.btn_deleteCast = new System.Windows.Forms.Button();
            this.dgv_cast = new System.Windows.Forms.DataGridView();
            this.lb_filmName = new System.Windows.Forms.Label();
            this.cmb_genre = new System.Windows.Forms.ComboBox();
            this.lb_admin = new System.Windows.Forms.Label();
            this.lb_hello = new System.Windows.Forms.Label();
            this.pnl_filmPoster = new System.Windows.Forms.Panel();
            this.btn_selectPoster = new System.Windows.Forms.Button();
            this.pBox_filmPoster = new System.Windows.Forms.PictureBox();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lb_selectFilmPoster = new System.Windows.Forms.Label();
            this.lb_filmNameExtend = new System.Windows.Forms.Label();
            this.pnl_filmPosterBG = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cast)).BeginInit();
            this.pnl_filmPoster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_filmPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_addFilm
            // 
            this.lb_addFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_addFilm.Location = new System.Drawing.Point(12, 48);
            this.lb_addFilm.Name = "lb_addFilm";
            this.lb_addFilm.Size = new System.Drawing.Size(850, 31);
            this.lb_addFilm.TabIndex = 55;
            this.lb_addFilm.Text = "Add Film";
            this.lb_addFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date_endDate
            // 
            this.date_endDate.Location = new System.Drawing.Point(505, 116);
            this.date_endDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.date_endDate.Name = "date_endDate";
            this.date_endDate.Size = new System.Drawing.Size(334, 26);
            this.date_endDate.TabIndex = 101;
            this.date_endDate.ValueChanged += new System.EventHandler(this.date_endDate_ValueChanged);
            // 
            // date_startDate
            // 
            this.date_startDate.Location = new System.Drawing.Point(505, 86);
            this.date_startDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.date_startDate.Name = "date_startDate";
            this.date_startDate.Size = new System.Drawing.Size(334, 26);
            this.date_startDate.TabIndex = 100;
            this.date_startDate.ValueChanged += new System.EventHandler(this.date_startDate_ValueChanged);
            // 
            // tBox_castCharacter
            // 
            this.tBox_castCharacter.Location = new System.Drawing.Point(694, 154);
            this.tBox_castCharacter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBox_castCharacter.Name = "tBox_castCharacter";
            this.tBox_castCharacter.Size = new System.Drawing.Size(145, 26);
            this.tBox_castCharacter.TabIndex = 97;
            this.tBox_castCharacter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_castCharacter_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(659, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 20);
            this.label11.TabIndex = 96;
            this.label11.Text = "as";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBox_castName
            // 
            this.tBox_castName.Location = new System.Drawing.Point(506, 154);
            this.tBox_castName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBox_castName.Name = "tBox_castName";
            this.tBox_castName.Size = new System.Drawing.Size(145, 26);
            this.tBox_castName.TabIndex = 95;
            this.tBox_castName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_castName_KeyPress);
            // 
            // lb_castName
            // 
            this.lb_castName.AutoSize = true;
            this.lb_castName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_castName.Location = new System.Drawing.Point(389, 157);
            this.lb_castName.Name = "lb_castName";
            this.lb_castName.Size = new System.Drawing.Size(103, 20);
            this.lb_castName.TabIndex = 94;
            this.lb_castName.Text = "Cast Name :";
            this.lb_castName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBox_description
            // 
            this.tBox_description.Location = new System.Drawing.Point(40, 259);
            this.tBox_description.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBox_description.Name = "tBox_description";
            this.tBox_description.Size = new System.Drawing.Size(307, 160);
            this.tBox_description.TabIndex = 93;
            this.tBox_description.Text = "";
            // 
            // tBox_director
            // 
            this.tBox_director.Location = new System.Drawing.Point(149, 194);
            this.tBox_director.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBox_director.Name = "tBox_director";
            this.tBox_director.Size = new System.Drawing.Size(199, 26);
            this.tBox_director.TabIndex = 92;
            this.tBox_director.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_director_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(208, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 91;
            this.label9.Text = "minutes";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBox_duration
            // 
            this.tBox_duration.Location = new System.Drawing.Point(149, 158);
            this.tBox_duration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBox_duration.MaxLength = 3;
            this.tBox_duration.Name = "tBox_duration";
            this.tBox_duration.Size = new System.Drawing.Size(52, 26);
            this.tBox_duration.TabIndex = 90;
            this.tBox_duration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_duration_KeyPress);
            // 
            // tBox_filmName
            // 
            this.tBox_filmName.Location = new System.Drawing.Point(148, 86);
            this.tBox_filmName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBox_filmName.Name = "tBox_filmName";
            this.tBox_filmName.Size = new System.Drawing.Size(199, 26);
            this.tBox_filmName.TabIndex = 89;
            this.tBox_filmName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_filmName_KeyPress);
            // 
            // lb_endDate
            // 
            this.lb_endDate.AutoSize = true;
            this.lb_endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_endDate.Location = new System.Drawing.Point(389, 122);
            this.lb_endDate.Name = "lb_endDate";
            this.lb_endDate.Size = new System.Drawing.Size(94, 20);
            this.lb_endDate.TabIndex = 85;
            this.lb_endDate.Text = "End Date : ";
            this.lb_endDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_startDate
            // 
            this.lb_startDate.AutoSize = true;
            this.lb_startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_startDate.Location = new System.Drawing.Point(389, 89);
            this.lb_startDate.Name = "lb_startDate";
            this.lb_startDate.Size = new System.Drawing.Size(96, 20);
            this.lb_startDate.TabIndex = 84;
            this.lb_startDate.Text = "Start Date :";
            this.lb_startDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_description
            // 
            this.lb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_description.Location = new System.Drawing.Point(36, 226);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(111, 34);
            this.lb_description.TabIndex = 83;
            this.lb_description.Text = "Description :";
            this.lb_description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_director
            // 
            this.lb_director.AutoSize = true;
            this.lb_director.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_director.Location = new System.Drawing.Point(36, 197);
            this.lb_director.Name = "lb_director";
            this.lb_director.Size = new System.Drawing.Size(85, 20);
            this.lb_director.TabIndex = 82;
            this.lb_director.Text = "Director : ";
            this.lb_director.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_duration
            // 
            this.lb_duration.AutoSize = true;
            this.lb_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_duration.Location = new System.Drawing.Point(36, 160);
            this.lb_duration.Name = "lb_duration";
            this.lb_duration.Size = new System.Drawing.Size(83, 20);
            this.lb_duration.TabIndex = 81;
            this.lb_duration.Text = "Duration :";
            this.lb_duration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_genre
            // 
            this.lb_genre.AutoSize = true;
            this.lb_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_genre.Location = new System.Drawing.Point(36, 125);
            this.lb_genre.Name = "lb_genre";
            this.lb_genre.Size = new System.Drawing.Size(65, 20);
            this.lb_genre.TabIndex = 80;
            this.lb_genre.Text = "Genre :";
            this.lb_genre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_addFilm
            // 
            this.btn_addFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_addFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addFilm.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btn_addFilm.Location = new System.Drawing.Point(59, 427);
            this.btn_addFilm.Name = "btn_addFilm";
            this.btn_addFilm.Size = new System.Drawing.Size(132, 35);
            this.btn_addFilm.TabIndex = 229;
            this.btn_addFilm.Text = "Add Film";
            this.btn_addFilm.UseVisualStyleBackColor = false;
            this.btn_addFilm.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cancel.Location = new System.Drawing.Point(197, 427);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(132, 35);
            this.btn_cancel.TabIndex = 228;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_addCast
            // 
            this.btn_addCast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_addCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCast.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btn_addCast.Location = new System.Drawing.Point(707, 193);
            this.btn_addCast.Name = "btn_addCast";
            this.btn_addCast.Size = new System.Drawing.Size(132, 35);
            this.btn_addCast.TabIndex = 230;
            this.btn_addCast.Text = "Add Cast";
            this.btn_addCast.UseVisualStyleBackColor = false;
            this.btn_addCast.Click += new System.EventHandler(this.btn_addCast_Click);
            // 
            // btn_deleteCast
            // 
            this.btn_deleteCast.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_deleteCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteCast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_deleteCast.Location = new System.Drawing.Point(707, 234);
            this.btn_deleteCast.Name = "btn_deleteCast";
            this.btn_deleteCast.Size = new System.Drawing.Size(132, 35);
            this.btn_deleteCast.TabIndex = 231;
            this.btn_deleteCast.Text = "Delete Cast";
            this.btn_deleteCast.UseVisualStyleBackColor = false;
            this.btn_deleteCast.Click += new System.EventHandler(this.btn_deleteCast_Click);
            // 
            // dgv_cast
            // 
            this.dgv_cast.AllowUserToAddRows = false;
            this.dgv_cast.AllowUserToDeleteRows = false;
            this.dgv_cast.AllowUserToResizeColumns = false;
            this.dgv_cast.AllowUserToResizeRows = false;
            this.dgv_cast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_cast.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_cast.ColumnHeadersHeight = 34;
            this.dgv_cast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_cast.Location = new System.Drawing.Point(393, 194);
            this.dgv_cast.MultiSelect = false;
            this.dgv_cast.Name = "dgv_cast";
            this.dgv_cast.ReadOnly = true;
            this.dgv_cast.RowHeadersVisible = false;
            this.dgv_cast.RowHeadersWidth = 62;
            this.dgv_cast.RowTemplate.Height = 28;
            this.dgv_cast.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cast.Size = new System.Drawing.Size(293, 268);
            this.dgv_cast.TabIndex = 235;
            // 
            // lb_filmName
            // 
            this.lb_filmName.AutoSize = true;
            this.lb_filmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_filmName.Location = new System.Drawing.Point(36, 89);
            this.lb_filmName.Name = "lb_filmName";
            this.lb_filmName.Size = new System.Drawing.Size(100, 20);
            this.lb_filmName.TabIndex = 236;
            this.lb_filmName.Text = "Film Name :";
            this.lb_filmName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_genre
            // 
            this.cmb_genre.FormattingEnabled = true;
            this.cmb_genre.Items.AddRange(new object[] {
            "Drama",
            "Komedi",
            "Petualangan",
            "Aksi",
            "Horor",
            "Sci-fi",
            "Thriller",
            "Dokumenter"});
            this.cmb_genre.Location = new System.Drawing.Point(149, 122);
            this.cmb_genre.Name = "cmb_genre";
            this.cmb_genre.Size = new System.Drawing.Size(198, 28);
            this.cmb_genre.TabIndex = 237;
            // 
            // lb_admin
            // 
            this.lb_admin.AutoSize = true;
            this.lb_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_admin.Location = new System.Drawing.Point(91, 24);
            this.lb_admin.Name = "lb_admin";
            this.lb_admin.Size = new System.Drawing.Size(73, 25);
            this.lb_admin.TabIndex = 239;
            this.lb_admin.Text = "Admin";
            // 
            // lb_hello
            // 
            this.lb_hello.AutoSize = true;
            this.lb_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hello.Location = new System.Drawing.Point(29, 24);
            this.lb_hello.Name = "lb_hello";
            this.lb_hello.Size = new System.Drawing.Size(61, 25);
            this.lb_hello.TabIndex = 238;
            this.lb_hello.Text = "Hello,";
            // 
            // pnl_filmPoster
            // 
            this.pnl_filmPoster.Controls.Add(this.pBox_filmPoster);
            this.pnl_filmPoster.Controls.Add(this.pnl_filmPosterBG);
            this.pnl_filmPoster.Controls.Add(this.lb_filmNameExtend);
            this.pnl_filmPoster.Controls.Add(this.lb_selectFilmPoster);
            this.pnl_filmPoster.Controls.Add(this.btn_save);
            this.pnl_filmPoster.Controls.Add(this.btn_openFile);
            this.pnl_filmPoster.Location = new System.Drawing.Point(-2, -1);
            this.pnl_filmPoster.Name = "pnl_filmPoster";
            this.pnl_filmPoster.Size = new System.Drawing.Size(879, 497);
            this.pnl_filmPoster.TabIndex = 240;
            this.pnl_filmPoster.Visible = false;
            // 
            // btn_selectPoster
            // 
            this.btn_selectPoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_selectPoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectPoster.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btn_selectPoster.Location = new System.Drawing.Point(707, 427);
            this.btn_selectPoster.Name = "btn_selectPoster";
            this.btn_selectPoster.Size = new System.Drawing.Size(132, 35);
            this.btn_selectPoster.TabIndex = 241;
            this.btn_selectPoster.Text = "Select Poster";
            this.btn_selectPoster.UseVisualStyleBackColor = false;
            this.btn_selectPoster.Click += new System.EventHandler(this.btn_selectPoster_Click);
            // 
            // pBox_filmPoster
            // 
            this.pBox_filmPoster.Location = new System.Drawing.Point(225, 88);
            this.pBox_filmPoster.Name = "pBox_filmPoster";
            this.pBox_filmPoster.Size = new System.Drawing.Size(225, 300);
            this.pBox_filmPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_filmPoster.TabIndex = 0;
            this.pBox_filmPoster.TabStop = false;
            this.pBox_filmPoster.Visible = false;
            // 
            // btn_openFile
            // 
            this.btn_openFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_openFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openFile.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btn_openFile.Location = new System.Drawing.Point(481, 87);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(132, 35);
            this.btn_openFile.TabIndex = 242;
            this.btn_openFile.Text = "Open File";
            this.btn_openFile.UseVisualStyleBackColor = false;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_save.Location = new System.Drawing.Point(481, 128);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(132, 35);
            this.btn_save.TabIndex = 243;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lb_selectFilmPoster
            // 
            this.lb_selectFilmPoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_selectFilmPoster.Location = new System.Drawing.Point(14, 49);
            this.lb_selectFilmPoster.Name = "lb_selectFilmPoster";
            this.lb_selectFilmPoster.Size = new System.Drawing.Size(850, 31);
            this.lb_selectFilmPoster.TabIndex = 244;
            this.lb_selectFilmPoster.Text = "Select Film Poster";
            this.lb_selectFilmPoster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_filmNameExtend
            // 
            this.lb_filmNameExtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_filmNameExtend.Location = new System.Drawing.Point(221, 402);
            this.lb_filmNameExtend.Name = "lb_filmNameExtend";
            this.lb_filmNameExtend.Size = new System.Drawing.Size(229, 61);
            this.lb_filmNameExtend.TabIndex = 245;
            this.lb_filmNameExtend.Text = "FILM NAME";
            this.lb_filmNameExtend.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_filmPosterBG
            // 
            this.pnl_filmPosterBG.BackColor = System.Drawing.Color.GhostWhite;
            this.pnl_filmPosterBG.Location = new System.Drawing.Point(225, 88);
            this.pnl_filmPosterBG.Name = "pnl_filmPosterBG";
            this.pnl_filmPosterBG.Size = new System.Drawing.Size(225, 300);
            this.pnl_filmPosterBG.TabIndex = 246;
            // 
            // FormAddFilmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 491);
            this.Controls.Add(this.pnl_filmPoster);
            this.Controls.Add(this.btn_selectPoster);
            this.Controls.Add(this.lb_admin);
            this.Controls.Add(this.lb_hello);
            this.Controls.Add(this.cmb_genre);
            this.Controls.Add(this.lb_filmName);
            this.Controls.Add(this.dgv_cast);
            this.Controls.Add(this.btn_deleteCast);
            this.Controls.Add(this.btn_addCast);
            this.Controls.Add(this.btn_addFilm);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.date_endDate);
            this.Controls.Add(this.date_startDate);
            this.Controls.Add(this.tBox_castCharacter);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tBox_castName);
            this.Controls.Add(this.lb_castName);
            this.Controls.Add(this.tBox_description);
            this.Controls.Add(this.tBox_director);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tBox_duration);
            this.Controls.Add(this.tBox_filmName);
            this.Controls.Add(this.lb_endDate);
            this.Controls.Add(this.lb_startDate);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.lb_director);
            this.Controls.Add(this.lb_duration);
            this.Controls.Add(this.lb_genre);
            this.Controls.Add(this.lb_addFilm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddFilmAdmin";
            this.Text = "FormAddFilmAdmin";
            this.Load += new System.EventHandler(this.FormAddFilmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cast)).EndInit();
            this.pnl_filmPoster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_filmPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_addFilm;
        private System.Windows.Forms.DateTimePicker date_endDate;
        private System.Windows.Forms.DateTimePicker date_startDate;
        private System.Windows.Forms.TextBox tBox_castCharacter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tBox_castName;
        private System.Windows.Forms.Label lb_castName;
        private System.Windows.Forms.RichTextBox tBox_description;
        private System.Windows.Forms.TextBox tBox_director;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBox_duration;
        private System.Windows.Forms.TextBox tBox_filmName;
        private System.Windows.Forms.Label lb_endDate;
        private System.Windows.Forms.Label lb_startDate;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.Label lb_director;
        private System.Windows.Forms.Label lb_duration;
        private System.Windows.Forms.Label lb_genre;
        private System.Windows.Forms.Button btn_addFilm;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_addCast;
        private System.Windows.Forms.Button btn_deleteCast;
        private System.Windows.Forms.DataGridView dgv_cast;
        private System.Windows.Forms.Label lb_filmName;
        private System.Windows.Forms.ComboBox cmb_genre;
        private System.Windows.Forms.Label lb_admin;
        private System.Windows.Forms.Label lb_hello;
        private System.Windows.Forms.Panel pnl_filmPoster;
        private System.Windows.Forms.Button btn_selectPoster;
        private System.Windows.Forms.PictureBox pBox_filmPoster;
        private System.Windows.Forms.Label lb_selectFilmPoster;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.Label lb_filmNameExtend;
        private System.Windows.Forms.Panel pnl_filmPosterBG;
    }
}