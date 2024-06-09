namespace _20232_DBD
{
    partial class FormTransactionsAdmin
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
            this.lb_transactions = new System.Windows.Forms.Label();
            this.lb_line = new System.Windows.Forms.Label();
            this.lb_transactionsList = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_numCanceled = new System.Windows.Forms.Panel();
            this.lb_numCanceled = new System.Windows.Forms.Label();
            this.lb_canceled = new System.Windows.Forms.Label();
            this.pnl_numDelayed = new System.Windows.Forms.Panel();
            this.lb_numDelayed = new System.Windows.Forms.Label();
            this.lb_delayed = new System.Windows.Forms.Label();
            this.pnl_numSucceed = new System.Windows.Forms.Panel();
            this.lb_numSucceed = new System.Windows.Forms.Label();
            this.lb_succeed = new System.Windows.Forms.Label();
            this.dgv_transactions = new System.Windows.Forms.DataGridView();
            this.lb_admin = new System.Windows.Forms.Label();
            this.lb_hello = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.pnl_numCanceled.SuspendLayout();
            this.pnl_numDelayed.SuspendLayout();
            this.pnl_numSucceed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transactions)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_transactions
            // 
            this.lb_transactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_transactions.Location = new System.Drawing.Point(12, 48);
            this.lb_transactions.Name = "lb_transactions";
            this.lb_transactions.Size = new System.Drawing.Size(850, 31);
            this.lb_transactions.TabIndex = 60;
            this.lb_transactions.Text = "Transactions";
            this.lb_transactions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_line
            // 
            this.lb_line.BackColor = System.Drawing.SystemColors.WindowText;
            this.lb_line.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_line.Location = new System.Drawing.Point(34, 219);
            this.lb_line.Name = "lb_line";
            this.lb_line.Size = new System.Drawing.Size(803, 2);
            this.lb_line.TabIndex = 64;
            this.lb_line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_transactionsList
            // 
            this.lb_transactionsList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_transactionsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_transactionsList.Location = new System.Drawing.Point(34, 192);
            this.lb_transactionsList.Name = "lb_transactionsList";
            this.lb_transactionsList.Size = new System.Drawing.Size(799, 25);
            this.lb_transactionsList.TabIndex = 62;
            this.lb_transactionsList.Text = "Transactions List";
            this.lb_transactionsList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.pnl_numCanceled, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.pnl_numDelayed, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.pnl_numSucceed, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(34, 87);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(803, 103);
            this.tableLayoutPanel.TabIndex = 65;
            // 
            // pnl_numCanceled
            // 
            this.pnl_numCanceled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(194)))), ((int)(((byte)(159)))));
            this.pnl_numCanceled.Controls.Add(this.lb_numCanceled);
            this.pnl_numCanceled.Controls.Add(this.lb_canceled);
            this.pnl_numCanceled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_numCanceled.Location = new System.Drawing.Point(542, 0);
            this.pnl_numCanceled.Margin = new System.Windows.Forms.Padding(8, 0, 0, 8);
            this.pnl_numCanceled.Name = "pnl_numCanceled";
            this.pnl_numCanceled.Size = new System.Drawing.Size(261, 95);
            this.pnl_numCanceled.TabIndex = 2;
            // 
            // lb_numCanceled
            // 
            this.lb_numCanceled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numCanceled.ForeColor = System.Drawing.Color.White;
            this.lb_numCanceled.Location = new System.Drawing.Point(14, 14);
            this.lb_numCanceled.Name = "lb_numCanceled";
            this.lb_numCanceled.Size = new System.Drawing.Size(120, 31);
            this.lb_numCanceled.TabIndex = 39;
            this.lb_numCanceled.Text = "Num";
            this.lb_numCanceled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_canceled
            // 
            this.lb_canceled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_canceled.ForeColor = System.Drawing.Color.White;
            this.lb_canceled.Location = new System.Drawing.Point(15, 48);
            this.lb_canceled.Name = "lb_canceled";
            this.lb_canceled.Size = new System.Drawing.Size(132, 31);
            this.lb_canceled.TabIndex = 36;
            this.lb_canceled.Text = "Canceled";
            this.lb_canceled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_numDelayed
            // 
            this.pnl_numDelayed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(139)))), ((int)(((byte)(132)))));
            this.pnl_numDelayed.Controls.Add(this.lb_numDelayed);
            this.pnl_numDelayed.Controls.Add(this.lb_delayed);
            this.pnl_numDelayed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_numDelayed.Location = new System.Drawing.Point(275, 0);
            this.pnl_numDelayed.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnl_numDelayed.Name = "pnl_numDelayed";
            this.pnl_numDelayed.Size = new System.Drawing.Size(251, 95);
            this.pnl_numDelayed.TabIndex = 1;
            // 
            // lb_numDelayed
            // 
            this.lb_numDelayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numDelayed.ForeColor = System.Drawing.Color.White;
            this.lb_numDelayed.Location = new System.Drawing.Point(14, 14);
            this.lb_numDelayed.Name = "lb_numDelayed";
            this.lb_numDelayed.Size = new System.Drawing.Size(120, 31);
            this.lb_numDelayed.TabIndex = 38;
            this.lb_numDelayed.Text = "Num";
            this.lb_numDelayed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_delayed
            // 
            this.lb_delayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_delayed.ForeColor = System.Drawing.Color.White;
            this.lb_delayed.Location = new System.Drawing.Point(15, 48);
            this.lb_delayed.Name = "lb_delayed";
            this.lb_delayed.Size = new System.Drawing.Size(123, 31);
            this.lb_delayed.TabIndex = 36;
            this.lb_delayed.Text = "Delayed";
            this.lb_delayed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_numSucceed
            // 
            this.pnl_numSucceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.pnl_numSucceed.Controls.Add(this.lb_numSucceed);
            this.pnl_numSucceed.Controls.Add(this.lb_succeed);
            this.pnl_numSucceed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_numSucceed.Location = new System.Drawing.Point(0, 0);
            this.pnl_numSucceed.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.pnl_numSucceed.Name = "pnl_numSucceed";
            this.pnl_numSucceed.Size = new System.Drawing.Size(259, 95);
            this.pnl_numSucceed.TabIndex = 0;
            // 
            // lb_numSucceed
            // 
            this.lb_numSucceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numSucceed.ForeColor = System.Drawing.Color.White;
            this.lb_numSucceed.Location = new System.Drawing.Point(15, 14);
            this.lb_numSucceed.Name = "lb_numSucceed";
            this.lb_numSucceed.Size = new System.Drawing.Size(120, 31);
            this.lb_numSucceed.TabIndex = 37;
            this.lb_numSucceed.Text = "Num";
            this.lb_numSucceed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_succeed
            // 
            this.lb_succeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_succeed.ForeColor = System.Drawing.Color.White;
            this.lb_succeed.Location = new System.Drawing.Point(15, 48);
            this.lb_succeed.Name = "lb_succeed";
            this.lb_succeed.Size = new System.Drawing.Size(120, 31);
            this.lb_succeed.TabIndex = 36;
            this.lb_succeed.Text = "Succeed";
            this.lb_succeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_transactions
            // 
            this.dgv_transactions.AllowUserToAddRows = false;
            this.dgv_transactions.AllowUserToDeleteRows = false;
            this.dgv_transactions.AllowUserToResizeColumns = false;
            this.dgv_transactions.AllowUserToResizeRows = false;
            this.dgv_transactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_transactions.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_transactions.ColumnHeadersHeight = 34;
            this.dgv_transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_transactions.Location = new System.Drawing.Point(34, 235);
            this.dgv_transactions.MultiSelect = false;
            this.dgv_transactions.Name = "dgv_transactions";
            this.dgv_transactions.ReadOnly = true;
            this.dgv_transactions.RowHeadersVisible = false;
            this.dgv_transactions.RowHeadersWidth = 62;
            this.dgv_transactions.RowTemplate.Height = 28;
            this.dgv_transactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_transactions.Size = new System.Drawing.Size(803, 225);
            this.dgv_transactions.TabIndex = 230;
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
            // FormTransactionsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 491);
            this.Controls.Add(this.lb_admin);
            this.Controls.Add(this.lb_hello);
            this.Controls.Add(this.dgv_transactions);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.lb_transactions);
            this.Controls.Add(this.lb_line);
            this.Controls.Add(this.lb_transactionsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTransactionsAdmin";
            this.Text = "FormTransactionsAdmin";
            this.Load += new System.EventHandler(this.FormTransactionsAdmin_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.pnl_numCanceled.ResumeLayout(false);
            this.pnl_numDelayed.ResumeLayout(false);
            this.pnl_numSucceed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_transactions;
        private System.Windows.Forms.Label lb_line;
        private System.Windows.Forms.Label lb_transactionsList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel pnl_numCanceled;
        private System.Windows.Forms.Label lb_numCanceled;
        private System.Windows.Forms.Label lb_canceled;
        private System.Windows.Forms.Panel pnl_numDelayed;
        private System.Windows.Forms.Label lb_numDelayed;
        private System.Windows.Forms.Label lb_delayed;
        private System.Windows.Forms.Panel pnl_numSucceed;
        private System.Windows.Forms.Label lb_numSucceed;
        private System.Windows.Forms.Label lb_succeed;
        private System.Windows.Forms.DataGridView dgv_transactions;
        private System.Windows.Forms.Label lb_admin;
        private System.Windows.Forms.Label lb_hello;
    }
}