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
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_line = new System.Windows.Forms.Label();
            this.lb_userList = new System.Windows.Forms.Label();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.lb_admin = new System.Windows.Forms.Label();
            this.lb_hello = new System.Windows.Forms.Label();
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
            this.lb_line.Location = new System.Drawing.Point(36, 109);
            this.lb_line.Name = "lb_line";
            this.lb_line.Size = new System.Drawing.Size(803, 2);
            this.lb_line.TabIndex = 63;
            this.lb_line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_userList
            // 
            this.lb_userList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_userList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userList.Location = new System.Drawing.Point(36, 81);
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
            this.dgv_user.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_user.ColumnHeadersHeight = 34;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_user.Location = new System.Drawing.Point(36, 124);
            this.dgv_user.MultiSelect = false;
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.ReadOnly = true;
            this.dgv_user.RowHeadersVisible = false;
            this.dgv_user.RowHeadersWidth = 62;
            this.dgv_user.RowTemplate.Height = 28;
            this.dgv_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_user.Size = new System.Drawing.Size(803, 337);
            this.dgv_user.TabIndex = 227;
            // 
            // lb_admin
            // 
            this.lb_admin.AutoSize = true;
            this.lb_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_admin.Location = new System.Drawing.Point(91, 24);
            this.lb_admin.Name = "lb_admin";
            this.lb_admin.Size = new System.Drawing.Size(73, 25);
            this.lb_admin.TabIndex = 241;
            this.lb_admin.Text = "Admin";
            // 
            // lb_hello
            // 
            this.lb_hello.AutoSize = true;
            this.lb_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hello.Location = new System.Drawing.Point(29, 24);
            this.lb_hello.Name = "lb_hello";
            this.lb_hello.Size = new System.Drawing.Size(61, 25);
            this.lb_hello.TabIndex = 240;
            this.lb_hello.Text = "Hello,";
            // 
            // FormUserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 491);
            this.Controls.Add(this.lb_admin);
            this.Controls.Add(this.lb_hello);
            this.Controls.Add(this.dgv_user);
            this.Controls.Add(this.lb_line);
            this.Controls.Add(this.lb_userList);
            this.Controls.Add(this.lb_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUserAdmin";
            this.Text = "FormUserAdmin";
            this.Load += new System.EventHandler(this.FormUserAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_line;
        private System.Windows.Forms.Label lb_userList;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.Label lb_admin;
        private System.Windows.Forms.Label lb_hello;
    }
}