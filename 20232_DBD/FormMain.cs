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
    public partial class FormMain : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;

        string user = FormLogin.username_login;
        int count = 0;
        public static string idPengguna;

        DataTable dt_pengguna;
        DataTable dt_judulFilm;
        DataTable dt_informasiFilm;
        DataTable dt_riwayatTransaksi;
        DataTable dt_profilUser;

        public FormMain(MySqlConnection conForm)
        {
            InitializeComponent();
            sqlConnect = conForm;

            tBox_phoneNumber.KeyPress += new KeyPressEventHandler(tBox_phoneNumber_KeyPress);
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            // Cek username yang login dan mengambil data nama user dari database
            sqlQuery = "SELECT id_pengguna, username_pengguna, nama_pengguna, email_pengguna FROM PENGGUNA";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_pengguna = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_pengguna);

            for (int i = 0; i < dt_pengguna.Rows.Count; i++)
            {
                if (user == dt_pengguna.Rows[i][1].ToString())
                {
                    lb_user.Text = dt_pengguna.Rows[i][2].ToString();
                    idPengguna = dt_pengguna.Rows[i][0].ToString();
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

            // Menampilkan gambar film default (pertama kali muncul) saat form dibuka
            System.Drawing.Bitmap image = Properties.Resources.ResourceManager.GetObject($"{dt_judulFilm.Rows[0][0].ToString()}") as System.Drawing.Bitmap;
            pBox_filmPoster.Image = image;
        }

        private void btn_kanan_Click(object sender, EventArgs e)
        {
            // Button next
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
            // Button previous
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

        private void btn_more_Click(object sender, EventArgs e)
        {
            pnl_more.Visible = true;
            pnl_history.Visible = false;
            pnl_profile.Visible = false;

            // Menampilkan gambar poster film yang dipilih
            System.Drawing.Bitmap image = Properties.Resources.ResourceManager.GetObject($"{lb_filmName.Text}") as System.Drawing.Bitmap;
            pBox_filmPosterInformation.Image = image;

            // Query untuk menampilkan informasi film berdasarkan judul film yang dipilih
            sqlQuery = $"SELECT judul_film, genre_film, CONCAT(durasi_film, ' menit'), sutradara_film, deskripsi_film FROM FILM WHERE judul_film = '{lb_filmName.Text}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_informasiFilm = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_informasiFilm);

            // Memasukkan informasi film ke masing-masing label
            lb_filmNameInformation.Text = dt_informasiFilm.Rows[0][0].ToString();
            lb_genreText.Text = dt_informasiFilm.Rows[0][1].ToString();
            lb_durationText.Text = dt_informasiFilm.Rows[0][2].ToString();
            lb_directorText.Text = dt_informasiFilm.Rows[0][3].ToString();
            lb_descriptionText.Text = dt_informasiFilm.Rows[0][4].ToString();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_more.Visible = false;
            pnl_history.Visible = true;
            pnl_profile.Visible = false;

            // Query untuk menampilkan riwayat transaksi pengguna berdasarkan ID pengguna
            sqlQuery = $@"SELECT DISTINCT t.id_transaksi_booking AS 'Order ID', f.judul_film AS 'Judul Film',
                                          CONCAT(DAY(j.tanggal_jadwal_tayang), ' ', MONTHNAME(j.tanggal_jadwal_tayang),
                                          ' ', YEAR(j.tanggal_jadwal_tayang)) AS 'Tanggal Tayang', CONCAT('Rp. ', k.harga_kursi 
                                          * t.jumlah_tiket_transaksi_booking) AS 'Total', t.status_pemesanan_transaksi_booking AS 'Status'
                          FROM TRANSAKSI_BOOKING t
                          JOIN JADWAL_TAYANG j
                             ON j.id_jadwal_tayang = t.id_jadwal_tayang
                          JOIN FILM f 
                             ON f.id_film = j.id_film
                          JOIN KURSI k
                             ON k.id_jadwal_tayang = j.id_jadwal_tayang
                          WHERE id_pengguna = '{idPengguna}'";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_riwayatTransaksi = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_riwayatTransaksi);

            dgv_transactionHistory.DataSource = dt_riwayatTransaksi;
            dgv_transactionHistory.ClearSelection();

            // Membuat lebar kolom data grid view menyesuaikan dengan lebar data grid view secara keseluruhan
            dgv_transactionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgv_transactionHistory_DoubleClick(object sender, EventArgs e)
        {
            // Menampilkan detail transaksi
            FormTransactionDetail fTransactionDetail = new FormTransactionDetail(sqlConnect);
            fTransactionDetail.ShowDialog();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_more.Visible = false;
            pnl_history.Visible = false;
            pnl_profile.Visible = true;
            pnl_editProfile.Visible = false;

            //Mengambil data milik user yang sedang login
            sqlQuery = $@"SELECT username_pengguna, nama_pengguna, email_pengguna, nomor_telepon_pengguna
                          FROM PENGGUNA
                          WHERE id_pengguna = '{idPengguna}'";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_profilUser = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_profilUser);

            //Menampilkan data user
            tBox_username.Text = dt_profilUser.Rows[0][0].ToString();
            tBox_name.Text = dt_profilUser.Rows[0][1].ToString();
            tBox_email.Text = dt_profilUser.Rows[0][2].ToString();
            tBox_phoneNumber.Text = dt_profilUser.Rows[0][3].ToString();
        }

        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            // Membuka akses edit
            tBox_name.Enabled = true;
            tBox_email.Enabled = true;
            tBox_phoneNumber.Enabled = true;

            pnl_editProfile.Visible = true;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            // Pengecekan apakah ada email yang sama di dalam database
            int countEmail = 0;
            for (int i = 0; i < dt_pengguna.Rows.Count; i++)
            {
                if (tBox_email.Text == dt_pengguna.Rows[i][3].ToString())
                {
                    countEmail++;
                    break;
                }
            }

            // Pengecekan agar setiap textbox tidak kosong
            if (tBox_username.Text == string.Empty || tBox_email.Text == string.Empty || tBox_phoneNumber.Text == string.Empty)
            {
                MessageBox.Show("Please fill all field");
            }
            else if (countEmail != 0)
            {
                MessageBox.Show("Please choose another email");
            }
            else
            {
                //Memastikan pengeditan
                DialogResult dr = MessageBox.Show("Do you want to save all changes?", "Confirm", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    //Update data pengguna di database
                    sqlQuery = $@"UPDATE PENGGUNA
                                  SET nama_pengguna = UPPER('{tBox_name.Text}'),
                                      email_pengguna = LOWER('{tBox_email.Text}'),
                                      nomor_telepon_pengguna = '{tBox_phoneNumber.Text}'
                                  WHERE id_pengguna = '{idPengguna}'";

                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    tBox_name.Enabled = false;
                    tBox_email.Enabled = false;
                    tBox_phoneNumber.Enabled = false;

                    pnl_editProfile.Visible = false;
                }
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //Mengembalikan ke data lama pengguna (sebelum edit)
            tBox_username.Text = dt_profilUser.Rows[0][0].ToString();
            tBox_name.Text = dt_profilUser.Rows[0][1].ToString();
            tBox_email.Text = dt_profilUser.Rows[0][2].ToString();
            tBox_phoneNumber.Text = dt_profilUser.Rows[0][3].ToString();

            tBox_username.Enabled = false;
            tBox_email.Enabled = false;
            tBox_phoneNumber.Enabled = false;

            pnl_editProfile.Visible = false;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_more.Visible = false;
            pnl_history.Visible = false;
            pnl_profile.Visible = false;
        }

        private void pBox_backFilmInformation_Click(object sender, EventArgs e)
        {
            pnl_more.Visible = false;
            pnl_history.Visible = false;
            pnl_profile.Visible = false;
        }

        private void pBox_backHistory_Click(object sender, EventArgs e)
        {
            pnl_more.Visible = false;
            pnl_history.Visible = false;
            pnl_profile.Visible = false;
        }

        private void tBox_phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter adalah angka
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Jika karakter bukan angka, batalkan input
                e.Handled = true;
            }
        }
    }
}