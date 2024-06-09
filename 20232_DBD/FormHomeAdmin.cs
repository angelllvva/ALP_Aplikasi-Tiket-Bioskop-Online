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
    public partial class FormHomeAdmin : Form
    {
        FormAdmin fAdmin;

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;

        DataTable dt_film;
        DataTable dt_pengguna;
        DataTable dt_tiket;
        DataTable dt_pendapatan;
        DataTable dt_overview;

        public FormHomeAdmin(FormAdmin _fAdmin, MySqlConnection _sqlConnect)
        {
            InitializeComponent();
            fAdmin = _fAdmin;
            sqlConnect = _sqlConnect;
        }

        private void FormHomeAdmin_Load(object sender, EventArgs e)
        {
            // Mengambil tanggal hari ini
            DateTime today = DateTime.Today;
            string tanggalOnGoing = today.ToString("yyyy-MM-dd");

            // Mengambil data total film yang ongoing maupun upcoming
            sqlQuery = $@"SELECT COUNT(id_film) AS 'Total Film'
                            FROM FILM
                            WHERE end_date_film >= '{tanggalOnGoing}'";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_film = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_film);

            lb_numFilms.Text = dt_film.Rows[0][0].ToString();
            
            // Mengambil data total pengguna
            sqlQuery = $@"SELECT COUNT(id_pengguna) AS 'Total Pengguna'
                            FROM PENGGUNA";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_pengguna = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_pengguna);

            lb_numUsers.Text = dt_pengguna.Rows[0][0].ToString();

            // Mengambil data total tiket yang berhasil terjual
            sqlQuery = $@"SELECT status_pemesanan_transaksi_booking AS Status, SUM(jumlah_tiket_transaksi_booking) AS 'Jumlah Tiket'
                            FROM TRANSAKSI_BOOKING
                            WHERE status_pemesanan_transaksi_booking = 'Berhasil'";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_tiket = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_tiket);

            lb_numTicketsSold.Text = dt_tiket.Rows[0][1].ToString();

            // Mengambil data total pendapatan dari penjualan tiket yang berhasil terjual
            sqlQuery = $@"SELECT CONCAT('Rp ', FORMAT(SUM(SQ.Total), '######')) AS Pendapatan
                            FROM(SELECT k.id_jadwal_tayang AS id_jadwal_tayang, (k.harga_kursi * COUNT(k.nomor_kursi)) AS 'Total', t.status_pemesanan_transaksi_booking AS 'Status'
                                    FROM KURSI k, TRANSAKSI_BOOKING t
                                    WHERE k.id_jadwal_tayang = t.id_jadwal_tayang
                                    GROUP BY 1
                                    HAVING status_pemesanan_transaksi_booking = 'Berhasil') as SQ";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_pendapatan = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_pendapatan);

            lb_numIncome.Text = dt_pendapatan.Rows[0][0].ToString();

            // Memasukkan data ke dgv overview
            sqlQuery = @"SELECT SQ.id_film AS 'Film ID', SQ.judul_film AS 'Film Name', CONCAT('Rp ', FORMAT(SUM(SQ.Total), '######')) AS 'Total Income',
IF(SUM(SQ.Total) = (SELECT MAX(SQ3.Total)
FROM (SELECT SQ2.id_film, SUM(SQ2.Total) AS 'Total'
FROM (SELECT jt.id_film, f.judul_film, (k.harga_kursi * COUNT(k.nomor_kursi)) AS 'Total', t.status_pemesanan_transaksi_booking AS 'Status'
		FROM KURSI k
		JOIN TRANSAKSI_BOOKING t ON k.id_jadwal_tayang = t.id_jadwal_tayang
		JOIN JADWAL_TAYANG jt ON k.id_jadwal_tayang = jt.id_jadwal_tayang
		JOIN FILM f ON jt.id_film = f.id_film
		GROUP BY k.id_jadwal_tayang
		HAVING status_pemesanan_transaksi_booking = 'Berhasil') AS SQ2
GROUP BY 1) AS SQ3), '*', ' ') AS 'Most Income',
IF(SUM(SQ.Total) = (SELECT MIN(SQ3.Total)
FROM (SELECT SQ2.id_film, SUM(SQ2.Total) AS 'Total'
FROM (SELECT jt.id_film, f.judul_film, (k.harga_kursi * COUNT(k.nomor_kursi)) AS 'Total', t.status_pemesanan_transaksi_booking AS 'Status'
		FROM KURSI k
		JOIN TRANSAKSI_BOOKING t ON k.id_jadwal_tayang = t.id_jadwal_tayang
		JOIN JADWAL_TAYANG jt ON k.id_jadwal_tayang = jt.id_jadwal_tayang
		JOIN FILM f ON jt.id_film = f.id_film
		GROUP BY k.id_jadwal_tayang
		HAVING status_pemesanan_transaksi_booking = 'Berhasil') AS SQ2
GROUP BY 1) AS SQ3), '*', ' ') AS 'Least Income'
FROM (SELECT jt.id_film, f.judul_film, (k.harga_kursi * COUNT(k.nomor_kursi)) AS 'Total', t.status_pemesanan_transaksi_booking AS 'Status'
		FROM KURSI k
		JOIN TRANSAKSI_BOOKING t ON k.id_jadwal_tayang = t.id_jadwal_tayang
		JOIN JADWAL_TAYANG jt ON k.id_jadwal_tayang = jt.id_jadwal_tayang
		JOIN FILM f ON jt.id_film = f.id_film
		GROUP BY k.id_jadwal_tayang
		HAVING status_pemesanan_transaksi_booking = 'Berhasil') AS SQ
GROUP BY 1
ORDER BY 1 ASC";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_overview = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_overview);

            dgv_home.DataSource = dt_overview;
            dgv_home.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
