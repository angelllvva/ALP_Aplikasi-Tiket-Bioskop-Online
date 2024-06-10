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
    public partial class FormFilmAdmin : Form
    {
        FormAdmin fAdmin;

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;

        DataTable dt_ongoingFilm;
        DataTable dt_upcomingFilm;

        public FormFilmAdmin(FormAdmin _fAdmin, MySqlConnection _sqlConnect)
        {
            InitializeComponent();
            fAdmin = _fAdmin;
            sqlConnect = _sqlConnect;
        }

        private void FormFilmAdmin_Load(object sender, EventArgs e)
        {
            // Mengambil tanggal hari ini
            DateTime today = DateTime.Today;
            string tanggalOnGoing = today.ToString("yyyy-MM-dd");

            // Mengambil tanggal 4 hari setelah hari ini
            today = today.AddDays(4);
            string tanggalOnGoingTerakhir = today.ToString("yyyy-MM-dd");

            // Menampilkan data film yang masih ongoing
            sqlQuery = $@"SELECT id_film AS 'Film ID', judul_film AS 'Film Name', genre_film AS 'Genre', durasi_film AS 'Duration', start_date_film AS 'Start Date', end_date_film AS 'End Date'
                            FROM FILM
                            WHERE end_date_film >= '{tanggalOnGoing}' && end_date_film <= '{tanggalOnGoingTerakhir}'";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_ongoingFilm = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_ongoingFilm);

            dgv_ongoingFilm.DataSource = dt_ongoingFilm;
            dgv_ongoingFilm.ClearSelection();
            dgv_ongoingFilm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Mengambil tanggal 5 hari setelah hari ini
            DateTime hariIni = DateTime.Today;
            hariIni = hariIni.AddDays(5);
            string tanggalUpComing = today.ToString("yyyy-MM-dd");

            // Menampilkan data film yang upcoming
            sqlQuery = $@"SELECT id_film AS 'Film ID', judul_film AS 'Film Name', genre_film AS 'Genre', durasi_film AS 'Duration', start_date_film AS 'Start Date', end_date_film AS 'End Date'
                            FROM FILM
                            WHERE end_date_film >= '{tanggalUpComing}'";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_upcomingFilm = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_upcomingFilm);

            dgv_upcomingFilm.DataSource = dt_upcomingFilm;
            dgv_upcomingFilm.ClearSelection();
            dgv_upcomingFilm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
