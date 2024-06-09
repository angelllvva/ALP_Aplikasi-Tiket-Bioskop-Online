namespace _20232_DBD
{
    partial class FormScheduleAdmin
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
            this.lb_schedule = new System.Windows.Forms.Label();
            this.date_startAt = new System.Windows.Forms.DateTimePicker();
            this.lb_startAt = new System.Windows.Forms.Label();
            this.cmb_studio = new System.Windows.Forms.ComboBox();
            this.lb_studio = new System.Windows.Forms.Label();
            this.tBox_filmTitle = new System.Windows.Forms.TextBox();
            this.lb_filmTitle = new System.Windows.Forms.Label();
            this.tBox_idSchedule = new System.Windows.Forms.TextBox();
            this.lb_idSchedule = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lb_line = new System.Windows.Forms.Label();
            this.lb_scheduleList = new System.Windows.Forms.Label();
            this.dgv_schedule = new System.Windows.Forms.DataGridView();
            this.lb_admin = new System.Windows.Forms.Label();
            this.lb_hello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_schedule
            // 
            this.lb_schedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_schedule.Location = new System.Drawing.Point(12, 48);
            this.lb_schedule.Name = "lb_schedule";
            this.lb_schedule.Size = new System.Drawing.Size(850, 31);
            this.lb_schedule.TabIndex = 55;
            this.lb_schedule.Text = "Schedule";
            this.lb_schedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date_startAt
            // 
            this.date_startAt.Location = new System.Drawing.Point(535, 129);
            this.date_startAt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.date_startAt.Name = "date_startAt";
            this.date_startAt.Size = new System.Drawing.Size(300, 26);
            this.date_startAt.TabIndex = 73;
            // 
            // lb_startAt
            // 
            this.lb_startAt.AutoSize = true;
            this.lb_startAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_startAt.Location = new System.Drawing.Point(452, 132);
            this.lb_startAt.Name = "lb_startAt";
            this.lb_startAt.Size = new System.Drawing.Size(76, 20);
            this.lb_startAt.TabIndex = 72;
            this.lb_startAt.Text = "Start At :";
            this.lb_startAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_studio
            // 
            this.cmb_studio.FormattingEnabled = true;
            this.cmb_studio.Location = new System.Drawing.Point(535, 91);
            this.cmb_studio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_studio.Name = "cmb_studio";
            this.cmb_studio.Size = new System.Drawing.Size(167, 28);
            this.cmb_studio.TabIndex = 71;
            // 
            // lb_studio
            // 
            this.lb_studio.AutoSize = true;
            this.lb_studio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_studio.Location = new System.Drawing.Point(452, 94);
            this.lb_studio.Name = "lb_studio";
            this.lb_studio.Size = new System.Drawing.Size(66, 20);
            this.lb_studio.TabIndex = 70;
            this.lb_studio.Text = "Studio :";
            this.lb_studio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBox_filmTitle
            // 
            this.tBox_filmTitle.Location = new System.Drawing.Point(153, 129);
            this.tBox_filmTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBox_filmTitle.Name = "tBox_filmTitle";
            this.tBox_filmTitle.Size = new System.Drawing.Size(199, 26);
            this.tBox_filmTitle.TabIndex = 69;
            // 
            // lb_filmTitle
            // 
            this.lb_filmTitle.AutoSize = true;
            this.lb_filmTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_filmTitle.Location = new System.Drawing.Point(36, 132);
            this.lb_filmTitle.Name = "lb_filmTitle";
            this.lb_filmTitle.Size = new System.Drawing.Size(88, 20);
            this.lb_filmTitle.TabIndex = 68;
            this.lb_filmTitle.Text = "Film Title :";
            this.lb_filmTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBox_idSchedule
            // 
            this.tBox_idSchedule.Location = new System.Drawing.Point(153, 91);
            this.tBox_idSchedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBox_idSchedule.Name = "tBox_idSchedule";
            this.tBox_idSchedule.Size = new System.Drawing.Size(199, 26);
            this.tBox_idSchedule.TabIndex = 67;
            // 
            // lb_idSchedule
            // 
            this.lb_idSchedule.AutoSize = true;
            this.lb_idSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idSchedule.Location = new System.Drawing.Point(36, 94);
            this.lb_idSchedule.Name = "lb_idSchedule";
            this.lb_idSchedule.Size = new System.Drawing.Size(110, 20);
            this.lb_idSchedule.TabIndex = 66;
            this.lb_idSchedule.Text = "ID Schedule :";
            this.lb_idSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btn_add.Location = new System.Drawing.Point(568, 179);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(132, 35);
            this.btn_add.TabIndex = 227;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_delete.Location = new System.Drawing.Point(705, 179);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(132, 35);
            this.btn_delete.TabIndex = 226;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // lb_line
            // 
            this.lb_line.BackColor = System.Drawing.SystemColors.WindowText;
            this.lb_line.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_line.Location = new System.Drawing.Point(34, 219);
            this.lb_line.Name = "lb_line";
            this.lb_line.Size = new System.Drawing.Size(803, 2);
            this.lb_line.TabIndex = 225;
            this.lb_line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_scheduleList
            // 
            this.lb_scheduleList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_scheduleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_scheduleList.Location = new System.Drawing.Point(34, 192);
            this.lb_scheduleList.Name = "lb_scheduleList";
            this.lb_scheduleList.Size = new System.Drawing.Size(799, 25);
            this.lb_scheduleList.TabIndex = 224;
            this.lb_scheduleList.Text = "Schedule List";
            this.lb_scheduleList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_schedule
            // 
            this.dgv_schedule.AllowUserToAddRows = false;
            this.dgv_schedule.AllowUserToDeleteRows = false;
            this.dgv_schedule.AllowUserToResizeColumns = false;
            this.dgv_schedule.AllowUserToResizeRows = false;
            this.dgv_schedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_schedule.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_schedule.ColumnHeadersHeight = 34;
            this.dgv_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_schedule.Location = new System.Drawing.Point(34, 235);
            this.dgv_schedule.MultiSelect = false;
            this.dgv_schedule.Name = "dgv_schedule";
            this.dgv_schedule.ReadOnly = true;
            this.dgv_schedule.RowHeadersVisible = false;
            this.dgv_schedule.RowHeadersWidth = 62;
            this.dgv_schedule.RowTemplate.Height = 28;
            this.dgv_schedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_schedule.Size = new System.Drawing.Size(803, 225);
            this.dgv_schedule.TabIndex = 230;
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
            // FormScheduleAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 491);
            this.Controls.Add(this.lb_admin);
            this.Controls.Add(this.lb_hello);
            this.Controls.Add(this.dgv_schedule);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lb_line);
            this.Controls.Add(this.lb_scheduleList);
            this.Controls.Add(this.date_startAt);
            this.Controls.Add(this.lb_startAt);
            this.Controls.Add(this.cmb_studio);
            this.Controls.Add(this.lb_studio);
            this.Controls.Add(this.tBox_filmTitle);
            this.Controls.Add(this.lb_filmTitle);
            this.Controls.Add(this.tBox_idSchedule);
            this.Controls.Add(this.lb_idSchedule);
            this.Controls.Add(this.lb_schedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormScheduleAdmin";
            this.Text = "FormScheduleAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_schedule;
        private System.Windows.Forms.DateTimePicker date_startAt;
        private System.Windows.Forms.Label lb_startAt;
        private System.Windows.Forms.ComboBox cmb_studio;
        private System.Windows.Forms.Label lb_studio;
        private System.Windows.Forms.TextBox tBox_filmTitle;
        private System.Windows.Forms.Label lb_filmTitle;
        private System.Windows.Forms.TextBox tBox_idSchedule;
        private System.Windows.Forms.Label lb_idSchedule;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lb_line;
        private System.Windows.Forms.Label lb_scheduleList;
        private System.Windows.Forms.DataGridView dgv_schedule;
        private System.Windows.Forms.Label lb_admin;
        private System.Windows.Forms.Label lb_hello;
    }
}