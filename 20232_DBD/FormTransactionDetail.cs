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
    public partial class FormTransactionDetail : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;

        DataTable dt_kursi;
        DataTable dt_transaksi;
        string idPengguna = FormMain.idUser;
        string seats;
        int indexRow = FormMain.indexRow;

        public FormTransactionDetail(MySqlConnection conForm)
        {
            InitializeComponent();
            sqlConnect = conForm;
        }

        private void FormTransactionDetail_Load(object sender, EventArgs e)
        {
            // Query untuk menampilkan nomor kursi berdasarkan ID transaksi booking
            dt_kursi = new DataTable();
            sqlQuery = $@"SELECT t.id_transaksi_booking, k.nomor_kursi
                          FROM TRANSAKSI_BOOKING t
                          JOIN JADWAL_TAYANG j
                            ON j.id_jadwal_tayang = t.id_jadwal_tayang
                          JOIN KURSI k
                            ON k.id_jadwal_tayang = j.id_jadwal_tayang
                          WHERE id_pengguna = '{idPengguna}'";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_kursi);

            // Query untuk menampilkan transaksi booking
            sqlQuery = $@"SELECT DISTINCT t.id_transaksi_booking, f.judul_film,
                                          CONCAT(DAY(j.tanggal_jadwal_tayang), ' ', MONTHNAME(j.tanggal_jadwal_tayang),
                                          ' ', YEAR(j.tanggal_jadwal_tayang)) AS tgl_jadwal_tayang, DATE_FORMAT(j.jam_jadwal_tayang, '%H:%i') 
                                          AS jam_jadwal_tayang, s.nama_studio, CONCAT('Rp. ', k.harga_kursi * t.jumlah_tiket_transaksi_booking) 
                                          AS total, t.status_pemesanan_transaksi_booking AS status_pemesanan
                          FROM TRANSAKSI_BOOKING t
                          JOIN JADWAL_TAYANG j
                            ON j.id_jadwal_tayang = t.id_jadwal_tayang
                          JOIN FILM f
                            ON f.id_film = j.id_film
                          JOIN KURSI k
                            ON k.id_jadwal_tayang = j.id_jadwal_tayang
                          JOIN STUDIO s
                            ON s.id_studio = j.id_studio
                          WHERE id_pengguna = '{idPengguna}'";
            
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_transaksi = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_transaksi);

            // Mengecek apakah jumlah kursi lebih dari 1. Jika Ya, beri koma untuk memisahkan antar kursi
            for (int i = 0; i < dt_kursi.Rows.Count; i++)
            {
                if (i == 0)
                {
                    seats = dt_kursi.Rows[i][1].ToString();
                }
                else
                {
                    seats += ", " + dt_kursi.Rows[i][1].ToString();
                }
            }

            // Memasukkan masing-masing informasi ke dalam label
            lb_orderIDText.Text = dt_transaksi.Rows[indexRow][0].ToString();
            lb_filmNameText.Text = dt_transaksi.Rows[indexRow][1].ToString();
            lb_dateText.Text = dt_transaksi.Rows[indexRow][2].ToString();
            lb_timeText.Text = dt_transaksi.Rows[indexRow][3].ToString();
            lb_studioText.Text = dt_transaksi.Rows[indexRow][4].ToString();
            lb_seatsText.Text = seats;
            lb_totalPriceText.Text = dt_transaksi.Rows[indexRow][5].ToString();
            lb_statusText.Text = dt_transaksi.Rows[indexRow][6].ToString();
        }
    }
}
