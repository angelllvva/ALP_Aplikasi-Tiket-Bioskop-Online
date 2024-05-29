
namespace _20232_DBD
{
    partial class FormLogin
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
            this.lb_easyTix = new System.Windows.Forms.Label();
            this.lb_team9 = new System.Windows.Forms.Label();
            this.lb_tagline = new System.Windows.Forms.Label();
            this.pBox_square = new System.Windows.Forms.PictureBox();
            this.pBox_ticket = new System.Windows.Forms.PictureBox();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.tBox_username = new System.Windows.Forms.TextBox();
            this.tBox_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_signUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_square)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_ticket)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_easyTix
            // 
            this.lb_easyTix.AutoSize = true;
            this.lb_easyTix.Font = new System.Drawing.Font("Nunito Sans Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_easyTix.ForeColor = System.Drawing.Color.Transparent;
            this.lb_easyTix.Location = new System.Drawing.Point(40, 22);
            this.lb_easyTix.Name = "lb_easyTix";
            this.lb_easyTix.Size = new System.Drawing.Size(249, 81);
            this.lb_easyTix.TabIndex = 0;
            this.lb_easyTix.Text = "easyTix";
            // 
            // lb_team9
            // 
            this.lb_team9.AutoSize = true;
            this.lb_team9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_team9.ForeColor = System.Drawing.Color.Transparent;
            this.lb_team9.Location = new System.Drawing.Point(50, 103);
            this.lb_team9.Name = "lb_team9";
            this.lb_team9.Size = new System.Drawing.Size(97, 22);
            this.lb_team9.TabIndex = 1;
            this.lb_team9.Text = "By Team 9";
            // 
            // lb_tagline
            // 
            this.lb_tagline.AutoSize = true;
            this.lb_tagline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tagline.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lb_tagline.Location = new System.Drawing.Point(39, 401);
            this.lb_tagline.Name = "lb_tagline";
            this.lb_tagline.Size = new System.Drawing.Size(253, 20);
            this.lb_tagline.TabIndex = 3;
            this.lb_tagline.Text = "Easy way to book your movie ticket";
            // 
            // pBox_square
            // 
            this.pBox_square.Image = global::_20232_DBD.Properties.Resources.Background_Login_Page;
            this.pBox_square.Location = new System.Drawing.Point(344, 42);
            this.pBox_square.Name = "pBox_square";
            this.pBox_square.Size = new System.Drawing.Size(345, 379);
            this.pBox_square.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_square.TabIndex = 4;
            this.pBox_square.TabStop = false;
            // 
            // pBox_ticket
            // 
            this.pBox_ticket.Image = global::_20232_DBD.Properties.Resources.Logo_Tiket;
            this.pBox_ticket.Location = new System.Drawing.Point(54, 150);
            this.pBox_ticket.Name = "pBox_ticket";
            this.pBox_ticket.Size = new System.Drawing.Size(220, 220);
            this.pBox_ticket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_ticket.TabIndex = 2;
            this.pBox_ticket.TabStop = false;
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lb_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_welcome.Location = new System.Drawing.Point(409, 80);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(207, 46);
            this.lb_welcome.TabIndex = 5;
            this.lb_welcome.Text = "Welcome!";
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_login.Location = new System.Drawing.Point(425, 128);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(173, 20);
            this.lb_login.TabIndex = 6;
            this.lb_login.Text = "Login into your account";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_username.Location = new System.Drawing.Point(380, 184);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(83, 20);
            this.lb_username.TabIndex = 7;
            this.lb_username.Text = "Username";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_password.Location = new System.Drawing.Point(380, 231);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(78, 20);
            this.lb_password.TabIndex = 8;
            this.lb_password.Text = "Password";
            // 
            // tBox_username
            // 
            this.tBox_username.Location = new System.Drawing.Point(481, 174);
            this.tBox_username.Name = "tBox_username";
            this.tBox_username.Size = new System.Drawing.Size(161, 35);
            this.tBox_username.TabIndex = 9;
            // 
            // tBox_password
            // 
            this.tBox_password.Location = new System.Drawing.Point(481, 221);
            this.tBox_password.Name = "tBox_password";
            this.tBox_password.Size = new System.Drawing.Size(161, 35);
            this.tBox_password.TabIndex = 10;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(444, 286);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(132, 35);
            this.btn_login.TabIndex = 11;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_signUp
            // 
            this.btn_signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signUp.Location = new System.Drawing.Point(444, 336);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(132, 35);
            this.btn_signUp.TabIndex = 12;
            this.btn_signUp.Text = "Sign Up";
            this.btn_signUp.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(741, 470);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tBox_password);
            this.Controls.Add(this.tBox_username);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.lb_welcome);
            this.Controls.Add(this.pBox_square);
            this.Controls.Add(this.lb_tagline);
            this.Controls.Add(this.pBox_ticket);
            this.Controls.Add(this.lb_team9);
            this.Controls.Add(this.lb_easyTix);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(763, 526);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "easyTix";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_square)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_ticket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_easyTix;
        private System.Windows.Forms.Label lb_team9;
        private System.Windows.Forms.PictureBox pBox_ticket;
        private System.Windows.Forms.Label lb_tagline;
        private System.Windows.Forms.PictureBox pBox_square;
        private System.Windows.Forms.Label lb_welcome;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tBox_username;
        private System.Windows.Forms.TextBox tBox_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_signUp;
    }
}

