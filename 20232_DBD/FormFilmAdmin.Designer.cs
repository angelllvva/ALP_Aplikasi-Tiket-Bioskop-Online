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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_film = new System.Windows.Forms.Label();
            this.lb_line = new System.Windows.Forms.Label();
            this.lb_filmList = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_film = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_film)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_film
            // 
            this.lb_film.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_film.Location = new System.Drawing.Point(12, 48);
            this.lb_film.Name = "lb_film";
            this.lb_film.Size = new System.Drawing.Size(850, 31);
            this.lb_film.TabIndex = 54;
            this.lb_film.Text = "Film";
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
            // lb_filmList
            // 
            this.lb_filmList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_filmList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_filmList.Location = new System.Drawing.Point(36, 94);
            this.lb_filmList.Name = "lb_filmList";
            this.lb_filmList.Size = new System.Drawing.Size(799, 25);
            this.lb_filmList.TabIndex = 58;
            this.lb_filmList.Text = "Film List";
            this.lb_filmList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_delete.Location = new System.Drawing.Point(707, 81);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(132, 35);
            this.btn_delete.TabIndex = 222;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btn_add.Location = new System.Drawing.Point(570, 81);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(132, 35);
            this.btn_add.TabIndex = 223;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // dgv_film
            // 
            this.dgv_film.AllowUserToAddRows = false;
            this.dgv_film.AllowUserToDeleteRows = false;
            this.dgv_film.AllowUserToResizeColumns = false;
            this.dgv_film.AllowUserToResizeRows = false;
            this.dgv_film.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_film.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.dgv_film.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_film.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_film.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_film.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_film.ColumnHeadersHeight = 50;
            this.dgv_film.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_film.EnableHeadersVisualStyles = false;
            this.dgv_film.GridColor = System.Drawing.Color.White;
            this.dgv_film.Location = new System.Drawing.Point(36, 136);
            this.dgv_film.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_film.MultiSelect = false;
            this.dgv_film.Name = "dgv_film";
            this.dgv_film.ReadOnly = true;
            this.dgv_film.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_film.RowHeadersVisible = false;
            this.dgv_film.RowHeadersWidth = 40;
            this.dgv_film.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_film.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgv_film.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.dgv_film.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_film.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_film.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_film.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_film.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_film.RowTemplate.DividerHeight = 3;
            this.dgv_film.RowTemplate.Height = 40;
            this.dgv_film.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_film.Size = new System.Drawing.Size(803, 326);
            this.dgv_film.TabIndex = 224;
            // 
            // FormFilmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 491);
            this.Controls.Add(this.dgv_film);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lb_line);
            this.Controls.Add(this.lb_filmList);
            this.Controls.Add(this.lb_film);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFilmAdmin";
            this.Text = "FormFilmAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_film)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_film;
        private System.Windows.Forms.Label lb_line;
        private System.Windows.Forms.Label lb_filmList;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_film;
    }
}