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
    public partial class FormAddFilmAdmin : Form
    {
        FormAdmin fAdmin;

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;

        DataTable dt_cast;
        DataTable dt_idFilm1SukuKata;
        DataTable dt_idFilmLebihDari1SukuKata;

        string idFilm;

        public FormAddFilmAdmin(FormAdmin _fAdmin, MySqlConnection _sqlConnect)
        {
            InitializeComponent();
            fAdmin = _fAdmin;
            sqlConnect = _sqlConnect;

            tBox_filmName.KeyPress += new KeyPressEventHandler(tBox_filmName_KeyPress);
            tBox_duration.KeyPress += new KeyPressEventHandler(tBox_duration_KeyPress);
            tBox_director.KeyPress += new KeyPressEventHandler(tBox_director_KeyPress);
            tBox_castName.KeyPress += new KeyPressEventHandler(tBox_castName_KeyPress);
            tBox_castCharacter.KeyPress += new KeyPressEventHandler(tBox_castCharacter_KeyPress);
        }

        private void FormAddFilmAdmin_Load(object sender, EventArgs e)
        {
            cmb_genre.Text = "";

            dt_cast = new DataTable();
            dt_cast.Columns.Add("Cast Name");
            dt_cast.Columns.Add("Cast Role");

            dgv_cast.DataSource = dt_cast;
            dgv_cast.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Ambil start date yang dipilih
            DateTime startDate = date_startDate.Value;

            // Ambil end date yang dipilih
            DateTime endDate = date_endDate.Value;

            // Ambil tanggal hari ini tanpa waktu (hanya tanggal saja)
            DateTime today = DateTime.Today;

            if (tBox_filmName.Text == "" || cmb_genre.Text == "" || tBox_duration.Text == "" || tBox_director.Text == "" || tBox_description.Text == "" || dgv_cast.Rows.Count == 0)
            {
                MessageBox.Show("Please input all the fields");
            }
            else if (startDate < today || endDate < startDate)
            {
                MessageBox.Show("Invalid Date");
            }
            else if (pBox_filmPoster.Image == null)
            {
                MessageBox.Show("Please select the film poster");
            }
            else if (tBox_filmName.Text != "" && cmb_genre.Text != "" && tBox_duration.Text != "" && tBox_director.Text != "" && tBox_description.Text != "" && startDate >= today && endDate >= startDate && dgv_cast.Rows.Count != 0 && pBox_filmPoster.Image != null)
            {
                // Pengecekan apakah judul film 1 suku kata atau lebih dari 1 suku kata dan membuat ID Film
                string[] filmName = tBox_filmName.Text.Split(' ');

                if (filmName.Length == 1)
                {
                    string idFilm1SukuKata = filmName[0].Substring(0, 2);

                    sqlQuery = $"SELECT COUNT(id_film) FROM FILM WHERE id_film LIKE '{idFilm1SukuKata}%'";
                    dt_idFilm1SukuKata = new DataTable();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dt_idFilm1SukuKata);

                    int idFilm1SukuKataTerakhir = Convert.ToInt32(dt_idFilm1SukuKata.Rows[0][0]) + 1;

                    if (idFilm1SukuKataTerakhir < 10)
                    {
                        idFilm = $"{idFilm1SukuKata}00{idFilm1SukuKataTerakhir}";
                    }
                    else if (idFilm1SukuKataTerakhir < 100)
                    {
                        idFilm = $"{idFilm1SukuKata}0{idFilm1SukuKataTerakhir}";
                    }
                    else
                    {
                        idFilm = $"{idFilm1SukuKata}{idFilm1SukuKataTerakhir}";
                    }
                }
                else
                {
                    string idFilmLebihDari1SukuKata = filmName[0].Substring(0, 1) + filmName[1].Substring(0, 1);

                    sqlQuery = $"SELECT COUNT(id_film) FROM FILM WHERE id_film LIKE '{idFilmLebihDari1SukuKata}%'";
                    dt_idFilmLebihDari1SukuKata = new DataTable();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dt_idFilmLebihDari1SukuKata);

                    int idFilmLebihDari1SukuKataTerakhir = Convert.ToInt32(dt_idFilmLebihDari1SukuKata.Rows[0][0]) + 1;

                    if (idFilmLebihDari1SukuKataTerakhir < 10)
                    {
                        idFilm = $"{idFilmLebihDari1SukuKata}00{idFilmLebihDari1SukuKataTerakhir}";
                    }
                    else if (idFilmLebihDari1SukuKataTerakhir < 100)
                    {
                        idFilm = $"{idFilmLebihDari1SukuKata}0{idFilmLebihDari1SukuKataTerakhir}";
                    }
                    else
                    {
                        idFilm = $"{idFilmLebihDari1SukuKata}{idFilmLebihDari1SukuKataTerakhir}";
                    }
                }

                string start_date = startDate.ToString("yyyy-MM-dd");
                string end_date = endDate.ToString("yyyy-MM-dd");

                //sqlQuery = $@"INSERT INTO FILM VALUES ('{idFilm.ToUpper()}', '{tBox_filmName.Text.ToUpper()}', '{cmb_genre.Text}', '{tBox_duration.Text}', '{tBox_director.Text}', '{tBox_description.Text}', '{start_date}', '{end_date}', 0);";
                //sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                //sqlCommand.ExecuteNonQuery();
                //sqlConnect.Close();
                //sqlConnect.Open();

                MessageBox.Show("Succesfully added film");

                // Reset semua teks
                tBox_filmName.Text = "";
                cmb_genre.Text = "";
                tBox_duration.Text = "";
                tBox_director.Text = "";
                tBox_description.Text = "";

                date_startDate.Value = today;
                date_endDate.Value = today;

                tBox_castName.Text = "";
                tBox_castCharacter.Text = "";

                dt_cast.Clear();
                dgv_cast.DataSource = dt_cast;

                pBox_filmPoster.Image = null;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            tBox_filmName.Text = "";
            cmb_genre.Text = "";
            tBox_duration.Text = "";
            tBox_director.Text = "";
            tBox_description.Text = "";

            DateTime today = DateTime.Today;
            date_startDate.Value = today;
            date_endDate.Value = today;

            tBox_castName.Text = "";
            tBox_castCharacter.Text = "";

            dt_cast.Clear();
            dgv_cast.Rows.Clear();

            pBox_filmPoster.Image = null;
        }

        private void date_startDate_ValueChanged(object sender, EventArgs e)
        {
            // Ambil tanggal yang dipilih
            DateTime selectedDate = date_startDate.Value;

            // Ambil tanggal hari ini tanpa waktu (hanya tanggal saja)
            DateTime today = DateTime.Today;
            string tanggal = today.ToString("yyyy-MM-dd");

            // Periksa apakah tanggal yang dipilih lebih kecil daripada tanggal hari ini
            if (selectedDate < today)
            {
                // Tampilkan pesan peringatan
                MessageBox.Show($"Date must not be before {tanggal}");

                // Atur kembali nilai DateTimePicker ke tanggal hari ini
                date_startDate.Value = today;
            }
            else
            {
                date_endDate.Value = date_startDate.Value;
            }
        }

        private void date_endDate_ValueChanged(object sender, EventArgs e)
        {
            // Ambil tanggal yang dipilih
            DateTime selectedDate = date_endDate.Value;

            // Ambil tanggal hari ini tanpa waktu (hanya tanggal saja)
            DateTime startDate = date_startDate.Value;
            string tanggal = startDate.ToString("yyyy-MM-dd");

            // Periksa apakah tanggal yang dipilih lebih kecil daripada tanggal hari ini
            if (selectedDate < startDate)
            {
                // Tampilkan pesan peringatan
                MessageBox.Show($"Date must not be before {tanggal}");

                // Atur kembali nilai DateTimePicker ke tanggal start date
                date_endDate.Value = date_startDate.Value;
            }
        }

        private void btn_addCast_Click(object sender, EventArgs e)
        {
            if (tBox_castName.Text != "" && tBox_castCharacter.Text != "")
            {
                int count = 0;
                for (int i = 0; i < dt_cast.Rows.Count; i++)
                {
                    if (tBox_castCharacter.Text.Contains(dt_cast.Rows[i][1].ToString()))
                    {
                        count++;
                        break;
                    }
                }

                if (count != 0)
                {
                    MessageBox.Show("Input cannot be the same");
                    tBox_castCharacter.Text = "";
                }
                else
                {
                    // Menambahkan cast ke data table
                    dt_cast.Rows.Add(tBox_castName.Text, tBox_castCharacter.Text);

                    tBox_castName.Text = "";
                    tBox_castCharacter.Text = "";

                    dgv_cast.DataSource = dt_cast;
                    dgv_cast.ClearSelection();
                }
            }
        }

        private void btn_deleteCast_Click(object sender, EventArgs e)
        {
            // Menghapus salah satu row dgv & data table
            if (dt_cast.Rows.Count != 0)
            {
                dgv_cast.ClearSelection();

                DataGridViewRow currentRow = dgv_cast.CurrentRow;
                int indexRemove = 0;

                if (dgv_cast.Rows.Count != 0)
                {
                    for (int i = 0; i < dt_cast.Rows.Count; i++)
                    {
                        if (dt_cast.Rows[i][0].ToString().Contains(currentRow.Cells[0].Value.ToString()))
                        {
                            indexRemove = i;
                        }
                    }

                    dt_cast.Rows.RemoveAt(indexRemove);
                }

                dgv_cast.DataSource = dt_cast;
                dgv_cast.ClearSelection();
            }
        }

        private void btn_selectPoster_Click(object sender, EventArgs e)
        {
            if (tBox_filmName.Text == "")
            {
                MessageBox.Show("Please input the film name first");
            }
            else
            {
                pnl_filmPoster.Visible = true;
                pBox_filmPoster.Visible = false;
                lb_filmNameExtend.Text = tBox_filmName.Text.ToUpper();
            }
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            // Membuat dan mengkonfigurasi OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg)|*.jpg";
            openFileDialog.ShowDialog();

            // Memuat gambar ke picture box
            pBox_filmPoster.Image = new Bitmap(openFileDialog.FileName);
            pBox_filmPoster.Visible = true;
        }
        
        private void btn_save_Click(object sender, EventArgs e)
        {
            // Menyimpan gambar ke resource

            // Kembali ke add film
            pnl_filmPoster.Visible = false;
        }

        private void tBox_filmName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter adalah huruf
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Jika karakter bukan huruf, batalkan input
                e.Handled = true;
            }
        }

        private void tBox_duration_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter adalah angka
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Jika karakter bukan angka, batalkan input
                e.Handled = true;
            }
        }

        private void tBox_director_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter adalah huruf
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Jika karakter bukan huruf, batalkan input
                e.Handled = true;
            }
        }

        private void tBox_castName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter adalah huruf
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Jika karakter bukan huruf, batalkan input
                e.Handled = true;
            }
        }

        private void tBox_castCharacter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter adalah huruf
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Jika karakter bukan huruf, batalkan input
                e.Handled = true;
            }
        }
    }
}
