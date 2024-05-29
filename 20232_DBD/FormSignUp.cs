using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Renci.SshNet;

namespace _20232_DBD
{
    public partial class FormSignUp : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;

        DataTable dt_pengguna;

        public FormSignUp(MySqlConnection conForm)
        {
            InitializeComponent();
            sqlConnect = conForm;
            tBox_firstName.KeyPress += new KeyPressEventHandler(tBox_firstName_KeyPress);
            tBox_lastName.KeyPress += new KeyPressEventHandler(tBox_lastName_KeyPress);
            tBox_username.KeyPress += new KeyPressEventHandler(tBox_username_KeyPress);
            tBox_phoneNumber.KeyPress += new KeyPressEventHandler(tBox_phoneNumber_KeyPress);

            dt_pengguna = new DataTable();
            sqlQuery = "SELECT id_pengguna, username_pengguna FROM PENGGUNA";
            sqlCommand = new MySqlCommand(sqlQuery, conForm);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_pengguna);
            dataGridView1.DataSource = dt_pengguna;
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            tBox_password.UseSystemPasswordChar = true;
        }

        private void lb_login_Click(object sender, EventArgs e)
        {
            // Kembali ke Menu Login
            this.Hide();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            // Pengecekan apakah ada username yang sama di dalam database
            int countUsername = 0;
            for (int i = 0; i < dt_pengguna.Rows.Count; i++)
            {
                if (tBox_username.Text == dt_pengguna.Rows[i][1].ToString())
                {
                    countUsername++;
                    break;
                }
            }

            if (countUsername != 0)
            {
                MessageBox.Show("Please choose another username");
            }
            else
            {
                // Pengecekan apakah nama pengguna 1 suku kata atau lebih dari 1 suku kata
                string gabungNama = tBox_firstName.Text + " " + tBox_lastName.Text;
                string[] pisahNama = gabungNama.Split(' ');

                if (pisahNama.Count() == 1)
                {
                    // id_pengguna : 2 huruf pertama nama + 3 digit nomor urut
                    // Pengecekan id_pengguna
                }
                else
                {
                    // id_pengguna : 1 huruf kata pertama nama + 1 huruf kata kedua nama + 3 digit nomor urut
                    // Pengecekan id_pengguna
                }

                // QUERY INSERT INTO DATABASE
            }
        }

        private void tBox_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter adalah huruf
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Jika karakter bukan huruf, batalkan input
                e.Handled = true;
            }
        }

        private void tBox_lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter adalah huruf
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Jika karakter bukan huruf, batalkan input
                e.Handled = true;
            }
        }

        private void tBox_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter adalah huruf atau angka
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Jika karakter bukan huruf atau angka, batalkan input
                e.Handled = true;
            }
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