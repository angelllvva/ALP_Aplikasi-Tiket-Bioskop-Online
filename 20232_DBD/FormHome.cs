using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20232_DBD
{
    public partial class FormHome : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;

        string user = FormLogin.username_login;
        int count = 0;

        DataTable dt_pengguna;
        DataTable dt_judulFilm;

        public FormHome(MySqlConnection conForm)
        {
            InitializeComponent();
            sqlConnect = conForm;
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            // Cek username yang login dan mengambil data nama user dari database
            sqlQuery = "SELECT username_pengguna, nama_pengguna FROM PENGGUNA";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_pengguna = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_pengguna);

            for (int i = 0; i < dt_pengguna.Rows.Count; i++)
            {
                if (user == dt_pengguna.Rows[i][0].ToString())
                {
                    lb_user.Text = dt_pengguna.Rows[i][1].ToString();
                    break;
                }
            }

            // Mengambil data judul film untuk dimasukkan ke label film name
            sqlQuery = "SELECT judul_film FROM FILM";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_judulFilm = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_judulFilm);

            lb_filmName.Text = dt_judulFilm.Rows[0][0].ToString();
            System.Drawing.Bitmap image = Properties.Resources.ResourceManager.GetObject($"{dt_judulFilm.Rows[0][0].ToString()}") as System.Drawing.Bitmap;
            pBox_filmPoster.Image = image;
        }

        private void btn_kanan_Click(object sender, EventArgs e)
        {
            if (count >= dt_judulFilm.Rows.Count - 1)
            {
                lb_filmName.Text = dt_judulFilm.Rows[dt_judulFilm.Rows.Count - 1][0].ToString();
                
                System.Drawing.Bitmap image = Properties.Resources.ResourceManager.GetObject($"{lb_filmName.Text}") as System.Drawing.Bitmap;
                pBox_filmPoster.Image = image;
            }
            else
            {
                count++;
                lb_filmName.Text = dt_judulFilm.Rows[count][0].ToString();

                System.Drawing.Bitmap image = Properties.Resources.ResourceManager.GetObject($"{lb_filmName.Text}") as System.Drawing.Bitmap;
                pBox_filmPoster.Image = image;
            }
        }

        private void btn_kiri_Click(object sender, EventArgs e)
        {
            if (count <= 0)
            {
                lb_filmName.Text = dt_judulFilm.Rows[0][0].ToString();

                System.Drawing.Bitmap image = Properties.Resources.ResourceManager.GetObject($"{lb_filmName.Text}") as System.Drawing.Bitmap;
                pBox_filmPoster.Image = image;
            }
            else
            {
                count--;
                lb_filmName.Text = dt_judulFilm.Rows[count][0].ToString();

                System.Drawing.Bitmap image = Properties.Resources.ResourceManager.GetObject($"{lb_filmName.Text}") as System.Drawing.Bitmap;
                pBox_filmPoster.Image = image;
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kembali ke menu Login
            this.Close();
        }
    }
}