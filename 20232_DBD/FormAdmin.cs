using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20232_DBD
{
    public partial class FormAdmin : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;

        FormHomeAdmin fHomeAdmin;
        FormFilmAdmin fFilmAdmin;
        FormScheduleAdmin fScheduleAdmin;
        FormTransactionsAdmin fTransactionsAdmin;
        FormUserAdmin fUserAdmin;
        
        public FormAdmin(MySqlConnection conForm)
        {
            InitializeComponent();
            sqlConnect = conForm;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // Home page
            pnl_filmAdmin.Visible = false;
            pnl_scheduleAdmin.Visible = false;
            pnl_transactionsAdmin.Visible = false;
            pnl_userAdmin.Visible = false;

            fHomeAdmin = new FormHomeAdmin(this, sqlConnect);
            fHomeAdmin.MdiParent = this;
            this.pnl_homeAdmin.Controls.Add(fHomeAdmin);
            fHomeAdmin.Show();
            pnl_homeAdmin.Visible = true;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_filmAdmin.Visible = false;
            pnl_scheduleAdmin.Visible = false;
            pnl_transactionsAdmin.Visible = false;
            pnl_userAdmin.Visible = false;

            // Masuk ke form home admin
            childFormClose();
            if (fHomeAdmin == null || fHomeAdmin.IsDisposed)
            {
                fHomeAdmin = new FormHomeAdmin(this, sqlConnect);
                fHomeAdmin.MdiParent = this;
                this.pnl_homeAdmin.Controls.Add(fHomeAdmin);
                fHomeAdmin.Show();
            }
            pnl_homeAdmin.Visible = true;
        }

        private void filmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_homeAdmin.Visible = false;
            pnl_scheduleAdmin.Visible = false;
            pnl_transactionsAdmin.Visible = false;
            pnl_userAdmin.Visible = false;

            // Masuk ke form film admin
            childFormClose();
            if (fFilmAdmin == null || fFilmAdmin.IsDisposed)
            {
                fFilmAdmin = new FormFilmAdmin(this, sqlConnect);
                fFilmAdmin.MdiParent = this;
                this.pnl_filmAdmin.Controls.Add(fFilmAdmin);
                fFilmAdmin.Show();
            }
            pnl_filmAdmin.Visible = true;
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_homeAdmin.Visible = false;
            pnl_filmAdmin.Visible = false;
            pnl_transactionsAdmin.Visible = false;
            pnl_userAdmin.Visible = false;

            // Masuk ke form schedule admin
            childFormClose();
            if (fScheduleAdmin == null || fScheduleAdmin.IsDisposed)
            {
                fScheduleAdmin = new FormScheduleAdmin(this, sqlConnect);
                fScheduleAdmin.MdiParent = this;
                this.pnl_scheduleAdmin.Controls.Add(fScheduleAdmin);
                fScheduleAdmin.Show();
            }
            pnl_scheduleAdmin.Visible = true;
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_homeAdmin.Visible = false;
            pnl_filmAdmin.Visible = false;
            pnl_scheduleAdmin.Visible = false;
            pnl_userAdmin.Visible = false;

            // Masuk ke form transactions admin
            childFormClose();
            if (fTransactionsAdmin == null || fTransactionsAdmin.IsDisposed)
            {
                fTransactionsAdmin = new FormTransactionsAdmin(this, sqlConnect);
                fTransactionsAdmin.MdiParent = this;
                this.pnl_transactionsAdmin.Controls.Add(fTransactionsAdmin);
                fTransactionsAdmin.Show();
            }
            pnl_transactionsAdmin.Visible = true;
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_homeAdmin.Visible = false;
            pnl_filmAdmin.Visible = false;
            pnl_scheduleAdmin.Visible = false;
            pnl_transactionsAdmin.Visible = false;

            // Masuk ke form user admin
            childFormClose();
            if (fUserAdmin == null || fUserAdmin.IsDisposed)
            {
                fUserAdmin = new FormUserAdmin(this, sqlConnect);
                fUserAdmin.MdiParent = this;
                this.pnl_userAdmin.Controls.Add(fUserAdmin);
                fUserAdmin.Show();
            }
            pnl_userAdmin.Visible = true;
        }

        private void childFormClose()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Kembali ke halaman login
            this.Close();
        }
    }
}
