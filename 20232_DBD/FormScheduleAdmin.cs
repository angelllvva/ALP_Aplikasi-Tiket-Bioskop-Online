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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _20232_DBD
{
    public partial class FormScheduleAdmin : Form
    {
        FormAdmin fAdmin;

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;

        DataTable dtJadwal;
        DataTable dtStudio;
        DataTable dtFilm;
        DateTime tanggalTayang;
        TimeSpan jamTayang;
        string idJadwal;

        public FormScheduleAdmin(FormAdmin _fAdmin, MySqlConnection _sqlConnect)
        {
            InitializeComponent();
            fAdmin = _fAdmin;
            sqlConnect = _sqlConnect;
        }

        private void FormScheduleAdmin_Load(object sender, EventArgs e)
        {
            //Isi DGV
            dtJadwal = new DataTable();
            sqlQuery = $"SELECT j.id_jadwal_tayang AS 'ID Jadwal Tayang', " +
                $" f.judul_film AS 'Judul Film', s.nama_studio AS 'Studio', " +
                $"j.tanggal_jadwal_tayang AS 'Tanggal Tayang', " +
                $"j.jam_jadwal_tayang AS 'Jam Tayang' " +
                $"FROM JADWAL_TAYANG j " +
                $"JOIN FILM f ON f.id_film = j.id_film " +
                $"JOIN STUDIO s ON s.id_studio = j.id_studio " +
                $"ORDER BY 4, 2;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtJadwal);
            dgv_schedule.DataSource = dtJadwal;

            //Isi Combo Box Studio
            dtStudio = new DataTable();
            sqlQuery = $"SELECT id_studio, nama_studio FROM STUDIO;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtStudio);
            cmb_studio.DataSource = dtStudio;
            cmb_studio.ValueMember = "id_studio";
            cmb_studio.DisplayMember = "nama_studio";

            //Isi Combo Box Film
            dtFilm = new DataTable();
            sqlQuery = $"SELECT id_film, judul_film FROM FILM;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtFilm);
            cmb_filmTitle.DataSource = dtFilm;
            cmb_filmTitle.ValueMember = "id_film";
            cmb_filmTitle.DisplayMember = "judul_film";

            //Mengosongkan text box, combo box, set DTP
            tBox_idSchedule.Text = string.Empty;
            cmb_studio.SelectedIndex = -1;
            cmb_filmTitle.SelectedIndex = -1;
            date_startAt.Value = DateTime.Now;
            date_timeStart.Value = DateTime.Now;
            date_timeStart.Format = DateTimePickerFormat.Time;
            date_timeStart.ShowUpDown = true;

            SetIDJadwal();
        }

        void SetIDJadwal()
        {
            //Membuat ID Jadwal Tayang
            idJadwal = "";
            tanggalTayang = date_startAt.Value.Date;
            jamTayang = date_timeStart.Value.TimeOfDay;
            string tanggalID = tanggalTayang.ToString("ddMMyy");
            string jamID = jamTayang.ToString().Substring(0, 2) + jamTayang.ToString().Substring(3, 2);
            if (cmb_studio.SelectedIndex != -1 && cmb_filmTitle.SelectedIndex != -1)
            {
                idJadwal = cmb_studio.SelectedValue.ToString().Substring(1, 2)
                    + cmb_filmTitle.SelectedValue.ToString() + tanggalID + jamID;
                tBox_idSchedule.Text = idJadwal;
            }
        }

        private void cmb_filmTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetIDJadwal();
        }

        private void cmb_studio_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetIDJadwal();
        }

        private void date_startAt_ValueChanged(object sender, EventArgs e)
        {
            SetIDJadwal();
        }

        private void date_TimeStart_ValueChanged(object sender, EventArgs e)
        {
            SetIDJadwal();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool scheduleExisted = false;
            for (int i = 0; i < dtJadwal.Rows.Count; i++)
            {
                if (idJadwal == dtJadwal.Rows[i][0].ToString())
                {
                    scheduleExisted = true;
                    break;
                }
            }

            if (scheduleExisted)
            {
                MessageBox.Show("This Schedule Already Existed");
            }
            else
            {
                if (cmb_studio.SelectedIndex == -1 && cmb_filmTitle.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Fill All Field First");
                }
                else
                {

                    //Mengubah format tanggal dan jam
                    string tanggal = tanggalTayang.ToString("yyyy-MM-dd");
                    string jam = jamTayang.ToString().Substring(0, 8);

                    //Memasukkan jadwal baru ke database
                    sqlQuery = $"INSERT INTO JADWAL_TAYANG VALUES ('{idJadwal}', '{cmb_filmTitle.SelectedValue}', '{cmb_studio.SelectedValue}', '{tanggal}', '{jam}', '0');";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();

                    //Memasukkan data kursi untuk jadwal tayang baru
                    sqlQuery = $"INSERT INTO KURSI VALUES ('{idJadwal}', 'A1', '0', '25000', '0'),('{idJadwal}', 'A2', '0', '25000', '0'),('{idJadwal}', 'A3', '0', '25000', '0'),('{idJadwal}', 'A4', '0', '25000', '0'),('{idJadwal}', 'A5', '0', '25000', '0'),('{idJadwal}', 'A6', '0', '25000', '0'),('{idJadwal}', 'A7', '0', '25000', '0'),('{idJadwal}', 'A8', '0', '25000', '0'),('{idJadwal}', 'A9', '0', '25000', '0'),('{idJadwal}', 'A10', '0', '25000', '0'),('{idJadwal}', 'A11', '0', '25000', '0'),('{idJadwal}', 'A12', '0', '25000', '0'),('{idJadwal}', 'B1', '0', '25000', '0'),('{idJadwal}', 'B2', '0', '25000', '0'),('{idJadwal}', 'B3', '0', '25000', '0'),('{idJadwal}', 'B4', '0', '25000', '0'),('{idJadwal}', 'B5', '0', '25000', '0'),('{idJadwal}', 'B6', '0', '25000', '0'),('{idJadwal}', 'B7', '0', '25000', '0'),('{idJadwal}', 'B8', '0', '25000', '0'),('{idJadwal}', 'B9', '0', '25000', '0'),('{idJadwal}', 'B10', '0', '25000', '0'),('{idJadwal}', 'B11', '0', '25000', '0'),('{idJadwal}', 'B12', '0', '25000', '0'),('{idJadwal}', 'C1', '0', '25000', '0'),('{idJadwal}', 'C2', '0', '25000', '0'),('{idJadwal}', 'C3', '0', '25000', '0'),('{idJadwal}', 'C4', '0', '25000', '0'),('{idJadwal}', 'C5', '0', '25000', '0'),('{idJadwal}', 'C6', '0', '25000', '0'),('{idJadwal}', 'C7', '0', '25000', '0'),('{idJadwal}', 'C8', '0', '25000', '0'),('{idJadwal}', 'C9', '0', '25000', '0'),('{idJadwal}', 'C10', '0', '25000', '0'),('{idJadwal}', 'C11', '0', '25000', '0'),('{idJadwal}', 'C12', '0', '25000', '0'),('{idJadwal}', 'D1', '0', '25000', '0'),('{idJadwal}', 'D2', '0', '25000', '0'),('{idJadwal}', 'D3', '0', '25000', '0'),('{idJadwal}', 'D4', '0', '25000', '0'),('{idJadwal}', 'D5', '0', '25000', '0'),('{idJadwal}', 'D6', '0', '25000', '0'),('{idJadwal}', 'D7', '0', '25000', '0'),('{idJadwal}', 'D8', '0', '25000', '0'),('{idJadwal}', 'D9', '0', '25000', '0'),('{idJadwal}', 'D10', '0', '25000', '0'),('{idJadwal}', 'D11', '0', '25000', '0'),('{idJadwal}', 'D12', '0', '25000', '0'),('{idJadwal}', 'E1', '0', '25000', '0'),('{idJadwal}', 'E2', '0', '25000', '0'),('{idJadwal}', 'E3', '0', '25000', '0'),('{idJadwal}', 'E4', '0', '25000', '0'),('{idJadwal}', 'E5', '0', '25000', '0'),('{idJadwal}', 'E6', '0', '25000', '0'),('{idJadwal}', 'E7', '0', '25000', '0'),('{idJadwal}', 'E8', '0', '25000', '0'),('{idJadwal}', 'E9', '0', '25000', '0'),('{idJadwal}', 'E10', '0', '25000', '0'),('{idJadwal}', 'E11', '0', '25000', '0'),('{idJadwal}', 'E12', '0', '25000', '0');\r\n";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Schedule Added");

                    tBox_idSchedule.Text = string.Empty;
                    cmb_studio.SelectedIndex = -1;
                    cmb_filmTitle.SelectedIndex = -1;
                    date_startAt.Value = DateTime.Now;
                    date_timeStart.Value = DateTime.Now;
                    date_timeStart.Format = DateTimePickerFormat.Time;
                    date_timeStart.ShowUpDown = true;

                    dtJadwal = new DataTable();
                    sqlQuery = $"SELECT j.id_jadwal_tayang AS 'ID Jadwal Tayang', " +
                        $" f.judul_film AS 'Judul Film', s.nama_studio AS 'Studio', " +
                        $"j.tanggal_jadwal_tayang AS 'Tanggal Tayang', " +
                        $"j.jam_jadwal_tayang AS 'Jam Tayang' " +
                        $"FROM JADWAL_TAYANG j " +
                        $"JOIN FILM f ON f.id_film = j.id_film " +
                        $"JOIN STUDIO s ON s.id_studio = j.id_studio " +
                        $"ORDER BY 4, 2;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dtJadwal);
                    dgv_schedule.DataSource = dtJadwal;
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgv_schedule.CurrentRow;

            //set status delete jadi 1
            sqlQuery = $"UPDATE JADWAL_TAYANG SET status_del = 1 WHERE id_jadwal_tayang = '{selectedRow.Cells[0].Value}'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();

            sqlQuery = $"UPDATE KURSI SET status_del = 1 WHERE id_jadwal_tayang = '{selectedRow.Cells[0].Value}'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();

            dgv_schedule.Rows.Remove(selectedRow);
        }
    }
}
