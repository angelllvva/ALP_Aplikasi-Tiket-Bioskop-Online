using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Renci.SshNet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _20232_DBD
{

    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public MySqlConnection myConn;
        public SshClient client;

        public static string username_login;

        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;

        DataTable dt_pengguna;
        int tampung;

        private void FormLogin_Load(object sender, EventArgs e)
        {
            string lokasi_id_rsa = "C:/TEMP/id_rsa";
            var key = new PrivateKeyFile(lokasi_id_rsa, "isb_mantap");
            var method = new PrivateKeyAuthenticationMethod("indramar", key);
            ConnectionInfo conn = new ConnectionInfo("indramaryati.xyz", 64000, "indramar", method);

            client = new SshClient(conn);
            client.Connect();

            // Connector/Net can now connect to 127.0.0.1:3306 to connect to the remote MySQL host.
            ForwardedPortLocal forwardedPortLocal = new ForwardedPortLocal("127.0.0.1", 3306, "127.0.0.1", 3306);
            forwardedPortLocal.Stop();
            client.AddForwardedPort(forwardedPortLocal);
            forwardedPortLocal.Start();

            myConn = new MySqlConnection("SERVER=127.0.0.1;PORT=3306;UID=indramar_group9;PASSWORD=1ffl6]?A9uyx;DATABASE=indramar_20232_dbd_9");
            myConn.Open();

            // Membuat teks yang diinput pada textbox menjadi password character
            tBox_password.UseSystemPasswordChar = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            lb_usernameNotFound.Visible = false;
            lb_passwordIncorrect.Visible = false;

            // Mengambil data username dan password dari tabel PENGGUNA di DATABASE
            dt_pengguna = new DataTable();
            sqlQuery = "SELECT username_pengguna, password_pengguna FROM PENGGUNA";
            sqlCommand = new MySqlCommand(sqlQuery, myConn);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_pengguna);

            // Pengecekan apakah inputan username dan password sudah tersimpan dan ada pada database
            int countUsername = 0;
            for (int i = 0; i < dt_pengguna.Rows.Count; i++)
            {
                if (tBox_username.Text == dt_pengguna.Rows[i][0].ToString())
                {
                    countUsername++;
                    tampung = i;
                    break;
                }
            }

            if (tBox_username.Text == "" && tBox_password.Text == "")
            {
                MessageBox.Show("Input your username & password");
            }
            else if (countUsername == 0)
            {
                lb_usernameNotFound.Visible = true;
                lb_passwordIncorrect.Visible = false;

                tBox_username.Text = "";
                tBox_password.Text = "";
            }
            else if (tBox_password.Text != dt_pengguna.Rows[tampung][1].ToString())
            {
                lb_usernameNotFound.Visible = false;
                lb_passwordIncorrect.Visible = true;

                tBox_password.Text = "";
            }
            else
            {
                username_login = tBox_username.Text;

                tBox_username.Text = "";
                tBox_password.Text = "";

                // Masuk ke menu Home
                FormMain fHome = new FormMain(myConn);
                fHome.ShowDialog();
            }
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            tBox_username.Text = "";
            tBox_password.Text = "";

            // Masuk ke menu Sign Up
            FormSignUp fSignUp = new FormSignUp(myConn);
            fSignUp.ShowDialog();
        }
    }
}