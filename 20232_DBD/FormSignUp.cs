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
        DataTable dt_IDPengguna1SukuKata;
        DataTable dt_IDPenggunaLebihDari1SukuKata;

        string idPengguna;

        public FormSignUp(MySqlConnection conForm)
        {
            InitializeComponent();
            sqlConnect = conForm;

            tBox_firstName.KeyPress += new KeyPressEventHandler(tBox_firstName_KeyPress);
            tBox_lastName.KeyPress += new KeyPressEventHandler(tBox_lastName_KeyPress);
            tBox_username.KeyPress += new KeyPressEventHandler(tBox_username_KeyPress);
            tBox_phoneNumber.KeyPress += new KeyPressEventHandler(tBox_phoneNumber_KeyPress);

            lb_login.MouseEnter += new EventHandler(lb_login_MouseEnter);
            lb_login.MouseLeave += new EventHandler(lb_login_MouseLeave);

            sqlQuery = "SELECT * FROM PENGGUNA";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            dt_pengguna = new DataTable();
            sqlDataAdapter.Fill(dt_pengguna);
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            tBox_password.UseSystemPasswordChar = true;
        }

        private void lb_login_Click(object sender, EventArgs e)
        {
            // Kembali ke menu Login
            this.Hide();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            // Pengecekan apakah ada email yang sama di dalam database
            int countEmail = 0;
            for (int i = 0; i < dt_pengguna.Rows.Count; i++)
            {
                if (tBox_email.Text == dt_pengguna.Rows[i][5].ToString())
                {
                    countEmail++;
                    break;
                }
            }

            // Pengecekan apakah ada username yang sama di dalam database
            int countUsername = 0;
            for (int i = 0; i < dt_pengguna.Rows.Count; i++)
            {
                if (tBox_username.Text == dt_pengguna.Rows[i][2].ToString())
                {
                    countUsername++;
                    break;
                }
            }
            
            //Pengecekan apakah password berisi minimal 8 karakter dan maksimal 16 karakter
            bool lengthPassword = false;

            if (tBox_password.Text.Length < 8 || tBox_password.Text.Length > 16)
            {
                lengthPassword = true;
            }

            //Pengecekan apakah password berisi kombinasi antara huruf, angka, dan simbol
            bool hasLetter = false;
            bool hasDigit = false;
            bool hasSymbol = false;

            foreach (char c in tBox_password.Text)
            {
                if (char.IsLetter(c))
                {
                    hasLetter = true;
                }
                else if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
                else if (!char.IsLetterOrDigit(c))
                {
                    hasSymbol = true;
                }
            }

            if (countEmail != 0)
            {
                MessageBox.Show("Please choose another email");
            }
            else if (countUsername != 0)
            {
                MessageBox.Show("Please choose another username");
            }
            else if (lengthPassword == true)
            {
                MessageBox.Show("Password must be at least 8 characters and maximum 16 characters");
            }
            else if (hasLetter == false || hasDigit == false || hasSymbol == false)
            {
                MessageBox.Show("Password must contains letter, number and symbol");
            }
            else
            {
                if (tBox_firstName.Text != "" && tBox_email.Text != "" && tBox_username.Text != "" && tBox_password.Text != "" && tBox_phoneNumber.Text != "")
                {
                    // Pengecekan apakah nama pengguna 1 suku kata atau lebih dari 1 suku kata dan membuat ID Pengguna serta Nama Pengguna
                    string gabungNama = tBox_firstName.Text.ToUpper() + " " + tBox_lastName.Text.ToUpper();
                    string[] pisahNama = gabungNama.Split(' ');

                    if (tBox_lastName.Text == "")
                    {
                        string idPengguna1SukuKata = pisahNama[0].Substring(0, 2);

                        sqlQuery = $"SELECT COUNT(id_pengguna) FROM PENGGUNA WHERE id_pengguna LIKE '{idPengguna1SukuKata}%'";
                        dt_IDPengguna1SukuKata = new DataTable();
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlDataAdapter.Fill(dt_IDPengguna1SukuKata);

                        int idPengguna1SukuKataTerakhir = Convert.ToInt32(dt_IDPengguna1SukuKata.Rows[0][0]) + 1;

                        if (idPengguna1SukuKataTerakhir < 10)
                        {
                            idPengguna = $"{idPengguna1SukuKata}00{idPengguna1SukuKataTerakhir}";
                        }
                        else if (idPengguna1SukuKataTerakhir < 100)
                        {
                            idPengguna = $"{idPengguna1SukuKata}0{idPengguna1SukuKataTerakhir}";
                        }
                        else
                        {
                            idPengguna = $"{idPengguna1SukuKata}{idPengguna1SukuKataTerakhir}";
                        }
                    }
                    else
                    {
                        string idPenggunaLebihDari1SukuKata = pisahNama[0].Substring(0, 1) + pisahNama[1].Substring(0, 1);

                        sqlQuery = $"SELECT COUNT(id_pengguna) FROM PENGGUNA WHERE id_pengguna LIKE '{idPenggunaLebihDari1SukuKata}%'";
                        dt_IDPenggunaLebihDari1SukuKata = new DataTable();
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlDataAdapter.Fill(dt_IDPenggunaLebihDari1SukuKata);

                        int idPenggunaLebihDari1SukuKataTerakhir = Convert.ToInt32(dt_IDPenggunaLebihDari1SukuKata.Rows[0][0]) + 1;

                        if (idPenggunaLebihDari1SukuKataTerakhir < 10)
                        {
                            idPengguna = $"{idPenggunaLebihDari1SukuKata}00{idPenggunaLebihDari1SukuKataTerakhir}";
                        }
                        else if (idPenggunaLebihDari1SukuKataTerakhir < 100)
                        {
                            idPengguna = $"{idPenggunaLebihDari1SukuKata}0{idPenggunaLebihDari1SukuKataTerakhir}";
                        }
                        else
                        {
                            idPengguna = $"{idPenggunaLebihDari1SukuKata}{idPenggunaLebihDari1SukuKataTerakhir}";
                        }
                    }

                    // Memasukkan data pengguna ke dalam database
                    sqlQuery = $"INSERT INTO PENGGUNA VALUES ('{idPengguna}', '{gabungNama}', '{tBox_username.Text}', '{tBox_password.Text}', '{tBox_phoneNumber.Text}', '{tBox_email.Text}', '0')";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    // Kembali ke Menu Login
                    this.Hide();

                    FormLogin fLogin = new FormLogin();
                    fLogin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please input all the starred fields");
                }
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

        private void lb_login_MouseEnter(object sender, EventArgs e)
        {
            lb_login.ForeColor = Color.White;
            lb_garis.ForeColor = Color.White;
        }

        private void lb_login_MouseLeave(object sender, EventArgs e)
        {
            lb_login.ForeColor = Color.NavajoWhite;
            lb_garis.ForeColor = Color.NavajoWhite;
        }
    }
}