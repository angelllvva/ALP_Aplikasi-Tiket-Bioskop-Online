using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
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
        public string idPengguna { get; set; }
        public static string idUser;
        string aktor;
        public static int indexRow;

        //kirim variable ke form choose seat
        public string tanggal { get; set; }
        public string jam { get; set; }
        public string judulFilm { get; set; }
        public string id { get; set; }
        public string picturename { get; set; }


        public DataTable dt_orderConfirm { get; set; }
        public DataTable dt_idJadwal { get; set; }

        DataTable dt_pengguna;
        DataTable dt_judulFilm;
        DataTable dt_informasiFilm;
        DataTable dt_aktorFilm;
        DataTable dt_riwayatTransaksi;
        DataTable dt_profilUser;
        DataTable dt_jamTayang;
        public DataTable dt_seat { get; set; }

        List<string> listJam;

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

            idUser = idPengguna;

            // Mengambil data judul film untuk dimasukkan ke label film name
            DateTime today = DateTime.Today;
            string tanggalHariini = today.ToString("yyyy-MM-dd");
            today = today.AddDays(4);
            string tanggalOnGoingTerakhir = today.ToString("yyyy-MM-dd");

            sqlQuery = $"SELECT judul_film FROM FILM WHERE end_date_film >= '{tanggalHariini}' && end_date_film <= '{tanggalOnGoingTerakhir}'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_judulFilm = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_judulFilm);

            lb_filmName.Text = dt_judulFilm.Rows[0][0].ToString();

            // Menampilkan gambar film default (pertama kali muncul) saat form dibuka
            pBox_filmPoster.Image = new Bitmap($"E:\\uni\\ALP_Aplikasi Tiket Bioskop\\20232_DBD\\Resources\\{dt_judulFilm.Rows[0][0].ToString()}.jpg");
        }

        private void btn_kanan_Click(object sender, EventArgs e)
        {
            // Button next
            if (count >= dt_judulFilm.Rows.Count - 1)
            {
                lb_filmName.Text = dt_judulFilm.Rows[dt_judulFilm.Rows.Count - 1][0].ToString();
                
                pBox_filmPoster.Image = new Bitmap($"E:\\uni\\ALP_Aplikasi Tiket Bioskop\\20232_DBD\\Resources\\{lb_filmName.Text}.jpg");
            }
            else
            {
                count++;
                lb_filmName.Text = dt_judulFilm.Rows[count][0].ToString();

                pBox_filmPoster.Image = new Bitmap($"E:\\uni\\ALP_Aplikasi Tiket Bioskop\\20232_DBD\\Resources\\{lb_filmName.Text}.jpg");
            }
        }

        private void btn_kiri_Click(object sender, EventArgs e)
        {
            // Button previous
            if (count <= 0)
            {
                lb_filmName.Text = dt_judulFilm.Rows[0][0].ToString();

                pBox_filmPoster.Image = new Bitmap($"E:\\uni\\ALP_Aplikasi Tiket Bioskop\\20232_DBD\\Resources\\{lb_filmName.Text}.jpg");
            }
            else
            {
                count--;
                lb_filmName.Text = dt_judulFilm.Rows[count][0].ToString();

                pBox_filmPoster.Image = new Bitmap($"E:\\uni\\ALP_Aplikasi Tiket Bioskop\\20232_DBD\\Resources\\{lb_filmName.Text}.jpg");
            }
        }

        private void btn_more_Click(object sender, EventArgs e)
        {
            pnl_more.Visible = true;
            pnl_filmSchedule.Visible = false;
            pnl_history.Visible = false;
            pnl_profile.Visible = false;
            pnl_chooseSeat.Visible = false;

            // Menampilkan gambar poster film yang dipilih
            pBox_filmPosterInformation.Image = new Bitmap($"E:\\uni\\ALP_Aplikasi Tiket Bioskop\\20232_DBD\\Resources\\{lb_filmName.Text}.jpg");
            //ambil string label untuk ConfiirmOrder
            picturename = lb_filmName.Text;

            // Query untuk menampilkan informasi film berdasarkan judul film yang dipilih
            sqlQuery = $"SELECT judul_film, genre_film, CONCAT(durasi_film, ' menit'), sutradara_film, deskripsi_film FROM FILM WHERE judul_film = '{lb_filmName.Text}'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_informasiFilm = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_informasiFilm);

            // Query untuk menampilkan nama aktor yang memainkan film
            sqlQuery = $@"SELECT f.judul_film, a.nama_aktor, mf.peran_memerankan_film
                          FROM MEMERANKAN_FILM mf
                          JOIN FILM f
                            ON mf.id_film = f.id_film
                          JOIN AKTOR a
                            ON a.id_aktor = mf.id_aktor
                          WHERE f.judul_film = '{dt_informasiFilm.Rows[0][0].ToString()}'";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_aktorFilm = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_aktorFilm);

            // Mengecek apakah jumlah cast lebih dari 1. Jika Ya, beri koma untuk memisahkan antar cast
            for (int i = 0; i < dt_aktorFilm.Rows.Count; i++)
            {
                if (i == 0)
                {
                    aktor = dt_aktorFilm.Rows[i][1].ToString() + " as " + dt_aktorFilm.Rows[i][2].ToString();
                }
                else
                {
                    aktor += @", 
" + dt_aktorFilm.Rows[i][1].ToString() + " as " + dt_aktorFilm.Rows[i][2].ToString();
                }
            }

            // Memasukkan informasi film ke masing-masing label
            lb_filmNameInformation.Text = dt_informasiFilm.Rows[0][0].ToString();
            lb_genreText.Text = dt_informasiFilm.Rows[0][1].ToString();
            lb_durationText.Text = dt_informasiFilm.Rows[0][2].ToString();
            lb_castText.Text = aktor;
            lb_directorText.Text = dt_informasiFilm.Rows[0][3].ToString();
            lb_descriptionText.Text = dt_informasiFilm.Rows[0][4].ToString();
        }

        private void btn_buyTicket_Click(object sender, EventArgs e)
        {
            // Set warna default masing-masing button tanggal schedule
            btn_today.BackColor = Color.FromArgb(0, 0, 64);
            btn_today.ForeColor = Color.NavajoWhite;
            lb_dateToday.ForeColor = Color.NavajoWhite;
            lb_dateToday.BackColor = Color.FromArgb(0, 0, 64);

            btn_nextDay.BackColor = Color.NavajoWhite;
            btn_nextDay.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNextDay.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNextDay.BackColor = Color.NavajoWhite;

            btn_next2Day.BackColor = Color.NavajoWhite;
            btn_next2Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext2Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext2Day.BackColor = Color.NavajoWhite;

            btn_next3Day.BackColor = Color.NavajoWhite;
            btn_next3Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext3Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext3Day.BackColor = Color.NavajoWhite;

            btn_next4Day.BackColor = Color.NavajoWhite;
            btn_next4Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext4Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext4Day.BackColor = Color.NavajoWhite;

            // Memunculkan jadwal tayang film yang dipilih
            pnl_more.Visible = false;
            pnl_filmSchedule.Visible = true;
            pnl_history.Visible = false;
            pnl_profile.Visible = false;
            pnl_chooseSeat.Visible = false;

            lb_filmNameSchedule.Text = lb_filmNameInformation.Text;

            pBox_filmPosterSchedule.Image = new Bitmap($"E:\\uni\\ALP_Aplikasi Tiket Bioskop\\20232_DBD\\Resources\\{lb_filmNameSchedule.Text}.jpg");

            DateTime today = DateTime.Today;

            // Membuat tanggal berdasarkan tanggal hari ini
            lb_dateToday.Text = today.ToString("dd MMM");
            today = today.AddDays(1);
            lb_dateNextDay.Text = today.ToString("dd MMM");
            today = today.AddDays(1);
            lb_dateNext2Day.Text = today.ToString("dd MMM");
            today = today.AddDays(1);
            lb_dateNext3Day.Text = today.ToString("dd MMM");
            today = today.AddDays(1);
            lb_dateNext4Day.Text = today.ToString("dd MMM");

            // Membuat nama hari berdasarkan hari ini
            btn_nextDay.Text = today.AddDays(1).DayOfWeek.ToString().ToUpper().Substring(0, 3);
            btn_next2Day.Text = today.AddDays(2).DayOfWeek.ToString().ToUpper().Substring(0, 3);
            btn_next3Day.Text = today.AddDays(3).DayOfWeek.ToString().ToUpper().Substring(0, 3);
            btn_next4Day.Text = today.AddDays(4).DayOfWeek.ToString().ToUpper().Substring(0, 3);

            // Mengubah format tanggal dari 'dd MMM' menjadi 'yyyy-MM-dd'
            // Parse string ke DateTime dengan format yang sesuai
            DateTime parsedDate = DateTime.ParseExact(lb_dateToday.Text, "dd MMM", CultureInfo.InvariantCulture);

            // Menambahkan tahun yang diinginkan, misalkan 2024
            parsedDate = new DateTime(2024, parsedDate.Month, parsedDate.Day);

            // Mengubah format DateTime ke 'yyyy-MM-dd'
            tanggal = parsedDate.ToString("yyyy-MM-dd");

            jadwalTayang(lb_filmNameSchedule.Text, tanggal);
        }

        private void btn_today_Click(object sender, EventArgs e)
        {
            btn_today.BackColor = Color.FromArgb(0, 0, 64);
            btn_today.ForeColor = Color.NavajoWhite;
            lb_dateToday.ForeColor = Color.NavajoWhite;
            lb_dateToday.BackColor = Color.FromArgb(0, 0, 64);

            btn_nextDay.BackColor = Color.NavajoWhite;
            btn_nextDay.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNextDay.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNextDay.BackColor = Color.NavajoWhite;

            btn_next2Day.BackColor = Color.NavajoWhite;
            btn_next2Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext2Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext2Day.BackColor = Color.NavajoWhite;

            btn_next3Day.BackColor = Color.NavajoWhite;
            btn_next3Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext3Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext3Day.BackColor = Color.NavajoWhite;

            btn_next4Day.BackColor = Color.NavajoWhite;
            btn_next4Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext4Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext4Day.BackColor = Color.NavajoWhite;

            // Mengubah format tanggal dari 'dd MMM' menjadi 'yyyy-MM-dd'
            // Parse string ke DateTime dengan format yang sesuai
            DateTime parsedDate = DateTime.ParseExact(lb_dateToday.Text, "dd MMM", CultureInfo.InvariantCulture);

            // Menambahkan tahun yang diinginkan, misalkan 2024
            parsedDate = new DateTime(2024, parsedDate.Month, parsedDate.Day);

            // Mengubah format DateTime ke 'yyyy-MM-dd'
            tanggal = parsedDate.ToString("yyyy-MM-dd");

            jadwalTayang(lb_filmNameSchedule.Text, tanggal);
        }

        private void btn_nextDay_Click(object sender, EventArgs e)
        {
            btn_today.BackColor = Color.NavajoWhite;
            btn_today.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateToday.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateToday.BackColor = Color.NavajoWhite;

            btn_nextDay.BackColor = Color.FromArgb(0, 0, 64);
            btn_nextDay.ForeColor = Color.NavajoWhite;
            lb_dateNextDay.ForeColor = Color.NavajoWhite;
            lb_dateNextDay.BackColor = Color.FromArgb(0, 0, 64);

            btn_next2Day.BackColor = Color.NavajoWhite;
            btn_next2Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext2Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext2Day.BackColor = Color.NavajoWhite;

            btn_next3Day.BackColor = Color.NavajoWhite;
            btn_next3Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext3Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext3Day.BackColor = Color.NavajoWhite;

            btn_next4Day.BackColor = Color.NavajoWhite;
            btn_next4Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext4Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext4Day.BackColor = Color.NavajoWhite;

            // Mengubah format tanggal dari 'dd MMM' menjadi 'yyyy-MM-dd'
            // Parse string ke DateTime dengan format yang sesuai
            DateTime parsedDate = DateTime.ParseExact(lb_dateNextDay.Text, "dd MMM", CultureInfo.InvariantCulture);

            // Menambahkan tahun yang diinginkan, misalkan 2024
            parsedDate = new DateTime(2024, parsedDate.Month, parsedDate.Day);

            // Mengubah format DateTime ke 'yyyy-MM-dd'
            tanggal = parsedDate.ToString("yyyy-MM-dd");

            jadwalTayang(lb_filmNameSchedule.Text, tanggal);
        }

        private void btn_next2Day_Click(object sender, EventArgs e)
        {
            btn_today.BackColor = Color.NavajoWhite;
            btn_today.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateToday.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateToday.BackColor = Color.NavajoWhite;

            btn_nextDay.BackColor = Color.NavajoWhite;
            btn_nextDay.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNextDay.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNextDay.BackColor = Color.NavajoWhite;

            btn_next2Day.BackColor = Color.FromArgb(0, 0, 64);
            btn_next2Day.ForeColor = Color.NavajoWhite;
            lb_dateNext2Day.ForeColor = Color.NavajoWhite;
            lb_dateNext2Day.BackColor = Color.FromArgb(0, 0, 64);

            btn_next3Day.BackColor = Color.NavajoWhite;
            btn_next3Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext3Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext3Day.BackColor = Color.NavajoWhite;

            btn_next4Day.BackColor = Color.NavajoWhite;
            btn_next4Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext4Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext4Day.BackColor = Color.NavajoWhite;

            // Mengubah format tanggal dari 'dd MMM' menjadi 'yyyy-MM-dd'
            // Parse string ke DateTime dengan format yang sesuai
            DateTime parsedDate = DateTime.ParseExact(lb_dateNext2Day.Text, "dd MMM", CultureInfo.InvariantCulture);

            // Menambahkan tahun yang diinginkan, misalkan 2024
            parsedDate = new DateTime(2024, parsedDate.Month, parsedDate.Day);

            // Mengubah format DateTime ke 'yyyy-MM-dd'
            tanggal = parsedDate.ToString("yyyy-MM-dd");

            jadwalTayang(lb_filmNameSchedule.Text, tanggal);
        }

        private void btn_next3Day_Click(object sender, EventArgs e)
        {
            btn_today.BackColor = Color.NavajoWhite;
            btn_today.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateToday.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateToday.BackColor = Color.NavajoWhite;

            btn_nextDay.BackColor = Color.NavajoWhite;
            btn_nextDay.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNextDay.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNextDay.BackColor = Color.NavajoWhite;

            btn_next2Day.BackColor = Color.NavajoWhite;
            btn_next2Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext2Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext2Day.BackColor = Color.NavajoWhite;

            btn_next3Day.BackColor = Color.FromArgb(0, 0, 64);
            btn_next3Day.ForeColor = Color.NavajoWhite;
            lb_dateNext3Day.ForeColor = Color.NavajoWhite;
            lb_dateNext3Day.BackColor = Color.FromArgb(0, 0, 64);

            btn_next4Day.BackColor = Color.NavajoWhite;
            btn_next4Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext4Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext4Day.BackColor = Color.NavajoWhite;

            // Mengubah format tanggal dari 'dd MMM' menjadi 'yyyy-MM-dd'
            // Parse string ke DateTime dengan format yang sesuai
            DateTime parsedDate = DateTime.ParseExact(lb_dateNext3Day.Text, "dd MMM", CultureInfo.InvariantCulture);

            // Menambahkan tahun yang diinginkan, misalkan 2024
            parsedDate = new DateTime(2024, parsedDate.Month, parsedDate.Day);

            // Mengubah format DateTime ke 'yyyy-MM-dd'
            tanggal = parsedDate.ToString("yyyy-MM-dd");

            jadwalTayang(lb_filmNameSchedule.Text, tanggal);
        }

        private void btn_next4Day_Click(object sender, EventArgs e)
        {
            btn_today.BackColor = Color.NavajoWhite;
            btn_today.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateToday.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateToday.BackColor = Color.NavajoWhite;

            btn_nextDay.BackColor = Color.NavajoWhite;
            btn_nextDay.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNextDay.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNextDay.BackColor = Color.NavajoWhite;

            btn_next2Day.BackColor = Color.NavajoWhite;
            btn_next2Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext2Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext2Day.BackColor = Color.NavajoWhite;

            btn_next3Day.BackColor = Color.NavajoWhite;
            btn_next3Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext3Day.ForeColor = Color.FromArgb(0, 0, 64);
            lb_dateNext3Day.BackColor = Color.NavajoWhite;

            btn_next4Day.BackColor = Color.FromArgb(0, 0, 64);
            btn_next4Day.ForeColor = Color.NavajoWhite;
            lb_dateNext4Day.ForeColor = Color.NavajoWhite;
            lb_dateNext4Day.BackColor = Color.FromArgb(0, 0, 64);

            // Mengubah format tanggal dari 'dd MMM' menjadi 'yyyy-MM-dd'
            // Parse string ke DateTime dengan format yang sesuai
            DateTime parsedDate = DateTime.ParseExact(lb_dateNext4Day.Text, "dd MMM", CultureInfo.InvariantCulture);

            // Menambahkan tahun yang diinginkan, misalkan 2024
            parsedDate = new DateTime(2024, parsedDate.Month, parsedDate.Day);

            // Mengubah format DateTime ke 'yyyy-MM-dd'
            tanggal = parsedDate.ToString("yyyy-MM-dd");

            jadwalTayang(lb_filmNameSchedule.Text, tanggal);
        }

        // Method untuk memanggil jam tayang berdasarkan judul film dan tanggal
        public void jadwalTayang(string judulFilm, string tanggal)
        {
            // Query untuk menampilkan jadwal tayang dari masing-masing film
            sqlQuery = $@"SELECT f.judul_film, jt.tanggal_jadwal_tayang, jt.jam_jadwal_tayang
                          FROM FILM f, JADWAL_TAYANG jt
                          WHERE f.id_film = jt.id_film && f.judul_film = '{judulFilm}' && jt.tanggal_jadwal_tayang = '{tanggal}' && jt.status_del = 0
                          ORDER BY 2, 3";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_jamTayang = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_jamTayang);

            // Mengambil semua button film schedule yang ada di dalam form Designer
            Button[] buttons = new Button[10] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10 };

            // Mendistribusikan data dari data table ke dalam masing-masing button
            listJam = new List<string>();
            for (int i = 0; i < buttons.Length; i++)
            {
                if (i < dt_jamTayang.Rows.Count)
                {
                    buttons[i].Visible = true;
                    buttons[i].Text = dt_jamTayang.Rows[i][2].ToString().Substring(0, 5);

                    //ambil variable jam
                    listJam.Add(dt_jamTayang.Rows[i][2].ToString());
                }
                else
                {
                    buttons[i].Visible = false;
                }
            }
        }

        void AmbilIdJadwal(string judulFilm, string tanggal, int indexJam)
        {
            //  Query untuk mengambil id_jadwal_tayang 
            jam = listJam[indexJam];
            sqlQuery = $@"SELECT id_jadwal_tayang, judul_film 
                            FROM JADWAL_TAYANG jt, FILM f
                            WHERE f.id_film = jt.id_film && f.judul_film = '{judulFilm}' && 
                            jt.tanggal_jadwal_tayang = '{tanggal}' && jt.jam_jadwal_tayang = '{jam}'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_idJadwal = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_idJadwal);

            for (int i = 0; i < dt_idJadwal.Rows.Count; i++)
            {
                id = dt_idJadwal.Rows[i][0].ToString();
            }

            //Cek kursi yang sudah penuh dari jadwal tayang
            sqlQuery = $@"SELECT nomor_kursi, status_kursi 
                            FROM KURSI 
                            LEFT JOIN JADWAL_TAYANG on JADWAL_TAYANG.id_jadwal_tayang = KURSI.id_jadwal_tayang
                            WHERE JADWAL_TAYANG.id_jadwal_tayang = '{id}' && KURSI.status_kursi = '1'";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_seat = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_seat);

            // Query untuk mengambil data orderan sebagai dasar Confirm Order
            sqlQuery = $@"SELECT judul_film, tanggal_jadwal_tayang, jam_jadwal_tayang, nama_studio 
                            FROM STUDIO
                            LEFT JOIN JADWAL_TAYANG 
                                ON JADWAL_TAYANG.id_studio = STUDIO.id_studio
                            LEFT JOIN FILM 
                                ON FILM.id_film = JADWAL_TAYANG.id_film
                            WHERE JADWAL_TAYANG.id_jadwal_tayang = '{id}'";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_orderConfirm = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_orderConfirm);
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_more.Visible = false;
            pnl_filmSchedule.Visible = false;
            pnl_history.Visible = true;
            pnl_profile.Visible = false;
            pnl_chooseSeat.Visible = false;

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
                          WHERE id_pengguna = '{idPengguna}'
                          ORDER BY j.tanggal_jadwal_tayang";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_riwayatTransaksi = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_riwayatTransaksi);

            dgv_transactionHistory.DataSource = dt_riwayatTransaksi;
            dgv_transactionHistory.ClearSelection();

            // Membuat lebar kolom data grid view menyesuaikan dengan lebar data grid view secara keseluruhan
            dgv_transactionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_more.Visible = false;
            pnl_filmSchedule.Visible = false;
            pnl_history.Visible = false;
            pnl_profile.Visible = true;
            pnl_editProfile.Visible = false;
            pnl_chooseSeat.Visible = false;

            // Mengambil data milik user yang sedang login
            sqlQuery = $@"SELECT username_pengguna, nama_pengguna, email_pengguna, nomor_telepon_pengguna
                          FROM PENGGUNA
                          WHERE id_pengguna = '{idPengguna}'";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_profilUser = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_profilUser);

            // Menampilkan data user
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
                // Memastikan pengeditan
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
                    sqlConnect.Open();

                    tBox_name.Enabled = false;
                    tBox_email.Enabled = false;
                    tBox_phoneNumber.Enabled = false;

                    pnl_editProfile.Visible = false;
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            // Mengembalikan ke data lama pengguna (sebelum edit)
            tBox_username.Text = dt_profilUser.Rows[0][0].ToString();
            tBox_name.Text = dt_profilUser.Rows[0][1].ToString();
            tBox_email.Text = dt_profilUser.Rows[0][2].ToString();
            tBox_phoneNumber.Text = dt_profilUser.Rows[0][3].ToString();

            tBox_name.Enabled = false;
            tBox_email.Enabled = false;
            tBox_phoneNumber.Enabled = false;

            pnl_editProfile.Visible = false;
        }


        public void closeChildForm()
        {
            foreach (Control c in pnl_chooseSeat.Controls)
            {
                if (c is Form)
                {
                    this.pnl_chooseSeat.Controls.Remove(c);
                }
            }
            pnl_chooseSeat.Visible = false;
        }

        public string time { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            AmbilIdJadwal(lb_filmNameSchedule.Text, tanggal, 0);
            time = button1.Text;
            FormChooseSeat fChooseSeat = new FormChooseSeat(this, sqlConnect);
            fChooseSeat.MdiParent = this;
            this.pnl_chooseSeat.Controls.Add(fChooseSeat);
            fChooseSeat.Show();
            pnl_chooseSeat.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AmbilIdJadwal(lb_filmNameSchedule.Text, tanggal, 1);
            time = button2.Text;
            FormChooseSeat fChooseSeat = new FormChooseSeat(this, sqlConnect);
            fChooseSeat.MdiParent = this;
            this.pnl_chooseSeat.Controls.Add(fChooseSeat);
            fChooseSeat.Show();
            pnl_chooseSeat.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            AmbilIdJadwal(lb_filmNameSchedule.Text, tanggal, 2);
            time = button3.Text;
            FormChooseSeat fChooseSeat = new FormChooseSeat(this, sqlConnect);
            fChooseSeat.MdiParent = this;
            this.pnl_chooseSeat.Controls.Add(fChooseSeat);
            fChooseSeat.Show();
            pnl_chooseSeat.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AmbilIdJadwal(lb_filmNameSchedule.Text, tanggal, 3);
            time = button4.Text;
            FormChooseSeat fChooseSeat = new FormChooseSeat(this, sqlConnect);
            fChooseSeat.MdiParent = this;
            this.pnl_chooseSeat.Controls.Add(fChooseSeat);
            fChooseSeat.Show();
            pnl_chooseSeat.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AmbilIdJadwal(lb_filmNameSchedule.Text, tanggal, 4);
            time = button5.Text;
            FormChooseSeat fChooseSeat = new FormChooseSeat(this, sqlConnect);
            fChooseSeat.MdiParent = this;
            this.pnl_chooseSeat.Controls.Add(fChooseSeat);
            fChooseSeat.Show();
            pnl_chooseSeat.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AmbilIdJadwal(lb_filmNameSchedule.Text, tanggal, 5);
            time = button6.Text;
            FormChooseSeat fChooseSeat = new FormChooseSeat(this, sqlConnect);
            fChooseSeat.MdiParent = this;
            this.pnl_chooseSeat.Controls.Add(fChooseSeat);
            fChooseSeat.Show();
            pnl_chooseSeat.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AmbilIdJadwal(lb_filmNameSchedule.Text, tanggal, 6);
            time = button7.Text;
            FormChooseSeat fChooseSeat = new FormChooseSeat(this, sqlConnect);
            fChooseSeat.MdiParent = this;
            this.pnl_chooseSeat.Controls.Add(fChooseSeat);
            fChooseSeat.Show();
            pnl_chooseSeat.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AmbilIdJadwal(lb_filmNameSchedule.Text, tanggal, 7);
            time = button8.Text;
            FormChooseSeat fChooseSeat = new FormChooseSeat(this, sqlConnect);
            fChooseSeat.MdiParent = this;
            this.pnl_chooseSeat.Controls.Add(fChooseSeat);
            fChooseSeat.Show();
            pnl_chooseSeat.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AmbilIdJadwal(lb_filmNameSchedule.Text, tanggal, 8);
            time = button9.Text;
            FormChooseSeat fChooseSeat = new FormChooseSeat(this, sqlConnect);
            fChooseSeat.MdiParent = this;
            this.pnl_chooseSeat.Controls.Add(fChooseSeat);
            fChooseSeat.Show();
            pnl_chooseSeat.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AmbilIdJadwal(lb_filmNameSchedule.Text, tanggal, 9);
            time = button10.Text;
            FormChooseSeat fChooseSeat = new FormChooseSeat(this, sqlConnect);
            fChooseSeat.MdiParent = this;
            this.pnl_chooseSeat.Controls.Add(fChooseSeat);
            fChooseSeat.Show();
            pnl_chooseSeat.Visible = true;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kembali ke menu Login
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_home.Visible = true;
            pnl_more.Visible = false;
            pnl_filmSchedule.Visible = false;
            pnl_history.Visible = false;
            pnl_profile.Visible = false;
            pnl_chooseSeat.Visible = false;
        }

        private void pBox_backFilmInformation_Click(object sender, EventArgs e)
        {
            pnl_home.Visible = true;
            pnl_more.Visible = false;
            pnl_filmSchedule.Visible = false;
            pnl_history.Visible = false;
            pnl_profile.Visible = false;
            pnl_chooseSeat.Visible = false;
        }

        private void pBox_backFilmSchedule_Click(object sender, EventArgs e)
        {
            pnl_more.Visible = true;
            pnl_filmSchedule.Visible = false;
            pnl_history.Visible = false;
            pnl_profile.Visible = false;
            pnl_chooseSeat.Visible = false;
        }

        private void pBox_backChooseSeat_Click(object sender, EventArgs e)
        {
            pnl_home.Visible = false;
            pnl_more.Visible = false;
            pnl_filmSchedule.Visible = true;
            pnl_history.Visible = false;
            pnl_profile.Visible = false;
            pnl_chooseSeat.Visible = false;
        }

        private void pBox_backHistory_Click(object sender, EventArgs e)
        {
            pnl_home.Visible = true;
            pnl_more.Visible = false;
            pnl_filmSchedule.Visible = false;
            pnl_history.Visible = false;
            pnl_profile.Visible = false;
            pnl_chooseSeat.Visible = false;
        }

        private void pBox_backProfile_Click(object sender, EventArgs e)
        {
            pnl_home.Visible = true;
            pnl_more.Visible = false;
            pnl_filmSchedule.Visible = false;
            pnl_history.Visible = false;
            pnl_profile.Visible = false;
            pnl_chooseSeat.Visible = false;

            tBox_name.Enabled = false;
            tBox_email.Enabled = false;
            tBox_phoneNumber.Enabled = false;
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