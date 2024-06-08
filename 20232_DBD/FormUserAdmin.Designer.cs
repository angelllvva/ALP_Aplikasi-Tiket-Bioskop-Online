namespace _20232_DBD
{
    partial class FormUserAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_line = new System.Windows.Forms.Label();
            this.lb_userList = new System.Windows.Forms.Label();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_user
            // 
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.Location = new System.Drawing.Point(12, 48);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(850, 31);
            this.lb_user.TabIndex = 61;
            this.lb_user.Text = "User";
            this.lb_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_line
            // 
            this.lb_line.BackColor = System.Drawing.SystemColors.WindowText;
            this.lb_line.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_line.Location = new System.Drawing.Point(36, 121);
            this.lb_line.Name = "lb_line";
            this.lb_line.Size = new System.Drawing.Size(803, 2);
            this.lb_line.TabIndex = 63;
            this.lb_line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_userList
            // 
            this.lb_userList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_userList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userList.Location = new System.Drawing.Point(36, 94);
            this.lb_userList.Name = "lb_userList";
            this.lb_userList.Size = new System.Drawing.Size(799, 25);
            this.lb_userList.TabIndex = 62;
            this.lb_userList.Text = "User List";
            this.lb_userList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_user
            // 
            this.dgv_user.AllowUserToAddRows = false;
            this.dgv_user.AllowUserToDeleteRows = false;
            this.dgv_user.AllowUserToResizeColumns = false;
            this.dgv_user.AllowUserToResizeRows = false;
            this.dgv_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_user.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.dgv_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_user.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_user.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_user.ColumnHeadersHeight = 50;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_user.EnableHeadersVisualStyles = false;
            this.dgv_user.GridColor = System.Drawing.Color.White;
            this.dgv_user.Location = new System.Drawing.Point(36, 136);
            this.dgv_user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_user.MultiSelect = false;
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.ReadOnly = true;
            this.dgv_user.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_user.RowHeadersVisible = false;
            this.dgv_user.RowHeadersWidth = 40;
            this.dgv_user.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_user.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgv_user.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.dgv_user.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_user.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_user.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_user.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_user.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_user.RowTemplate.DividerHeight = 3;
            this.dgv_user.RowTemplate.Height = 40;
            this.dgv_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_user.Size = new System.Drawing.Size(803, 326);
            this.dgv_user.TabIndex = 225;
            // 
            // FormUserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 491);
            this.Controls.Add(this.dgv_user);
            this.Controls.Add(this.lb_line);
            this.Controls.Add(this.lb_userList);
            this.Controls.Add(this.lb_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUserAdmin";
            this.Text = "FormUserAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_line;
        private System.Windows.Forms.Label lb_userList;
        private System.Windows.Forms.DataGridView dgv_user;
    }
}