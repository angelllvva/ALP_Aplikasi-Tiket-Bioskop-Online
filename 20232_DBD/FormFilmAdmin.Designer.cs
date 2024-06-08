namespace _20232_DBD
{
    partial class FormFilmAdmin
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
            this.lb_film = new System.Windows.Forms.Label();
            this.lb_line = new System.Windows.Forms.Label();
            this.lb_ongoingFilmList = new System.Windows.Forms.Label();
            this.dgv_ongoingFilm = new System.Windows.Forms.DataGridView();
            this.dgv_upcomingFilm = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ongoingFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_upcomingFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_film
            // 
            this.lb_film.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_film.Location = new System.Drawing.Point(12, 48);
            this.lb_film.Name = "lb_film";
            this.lb_film.Size = new System.Drawing.Size(850, 31);
            this.lb_film.TabIndex = 54;
            this.lb_film.Text = "Film List";
            this.lb_film.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_line
            // 
            this.lb_line.BackColor = System.Drawing.SystemColors.WindowText;
            this.lb_line.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_line.Location = new System.Drawing.Point(36, 121);
            this.lb_line.Name = "lb_line";
            this.lb_line.Size = new System.Drawing.Size(803, 2);
            this.lb_line.TabIndex = 59;
            this.lb_line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_ongoingFilmList
            // 
            this.lb_ongoingFilmList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_ongoingFilmList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ongoingFilmList.Location = new System.Drawing.Point(36, 94);
            this.lb_ongoingFilmList.Name = "lb_ongoingFilmList";
            this.lb_ongoingFilmList.Size = new System.Drawing.Size(799, 25);
            this.lb_ongoingFilmList.TabIndex = 58;
            this.lb_ongoingFilmList.Text = "Ongoing Films";
            this.lb_ongoingFilmList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_ongoingFilm
            // 
            this.dgv_ongoingFilm.AllowUserToAddRows = false;
            this.dgv_ongoingFilm.AllowUserToDeleteRows = false;
            this.dgv_ongoingFilm.AllowUserToResizeColumns = false;
            this.dgv_ongoingFilm.AllowUserToResizeRows = false;
            this.dgv_ongoingFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ongoingFilm.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_ongoingFilm.ColumnHeadersHeight = 34;
            this.dgv_ongoingFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_ongoingFilm.Location = new System.Drawing.Point(36, 133);
            this.dgv_ongoingFilm.MultiSelect = false;
            this.dgv_ongoingFilm.Name = "dgv_ongoingFilm";
            this.dgv_ongoingFilm.ReadOnly = true;
            this.dgv_ongoingFilm.RowHeadersVisible = false;
            this.dgv_ongoingFilm.RowHeadersWidth = 62;
            this.dgv_ongoingFilm.RowTemplate.Height = 28;
            this.dgv_ongoingFilm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ongoingFilm.Size = new System.Drawing.Size(803, 146);
            this.dgv_ongoingFilm.TabIndex = 232;
            // 
            // dgv_upcomingFilm
            // 
            this.dgv_upcomingFilm.AllowUserToAddRows = false;
            this.dgv_upcomingFilm.AllowUserToDeleteRows = false;
            this.dgv_upcomingFilm.AllowUserToResizeColumns = false;
            this.dgv_upcomingFilm.AllowUserToResizeRows = false;
            this.dgv_upcomingFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_upcomingFilm.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_upcomingFilm.ColumnHeadersHeight = 34;
            this.dgv_upcomingFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_upcomingFilm.Location = new System.Drawing.Point(36, 329);
            this.dgv_upcomingFilm.MultiSelect = false;
            this.dgv_upcomingFilm.Name = "dgv_upcomingFilm";
            this.dgv_upcomingFilm.ReadOnly = true;
            this.dgv_upcomingFilm.RowHeadersVisible = false;
            this.dgv_upcomingFilm.RowHeadersWidth = 62;
            this.dgv_upcomingFilm.RowTemplate.Height = 28;
            this.dgv_upcomingFilm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_upcomingFilm.Size = new System.Drawing.Size(803, 133);
            this.dgv_upcomingFilm.TabIndex = 233;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(803, 2);
            this.label1.TabIndex = 235;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(799, 25);
            this.label2.TabIndex = 234;
            this.label2.Text = "Upcoming Films";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormFilmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_upcomingFilm);
            this.Controls.Add(this.dgv_ongoingFilm);
            this.Controls.Add(this.lb_line);
            this.Controls.Add(this.lb_ongoingFilmList);
            this.Controls.Add(this.lb_film);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFilmAdmin";
            this.Text = "FormFilmAdmin";
            this.Load += new System.EventHandler(this.FormFilmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ongoingFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_upcomingFilm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_film;
        private System.Windows.Forms.Label lb_line;
        private System.Windows.Forms.Label lb_ongoingFilmList;
        private System.Windows.Forms.DataGridView dgv_ongoingFilm;
        private System.Windows.Forms.DataGridView dgv_upcomingFilm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}