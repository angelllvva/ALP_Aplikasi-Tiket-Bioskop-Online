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
    public partial class FormUserAdmin : Form
    {
        FormAdmin fAdmin;

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;

        DataTable dt_user;

        public FormUserAdmin(FormAdmin _fAdmin, MySqlConnection _sqlConnect)
        {
            InitializeComponent();
            fAdmin = _fAdmin;
            sqlConnect = _sqlConnect;
        }

        private void FormUserAdmin_Load(object sender, EventArgs e)
        {
            // Menampilkan user yang ada di dalam database
            sqlQuery = $@"SELECT id_pengguna AS 'User ID', username_pengguna AS 'Username', nama_pengguna AS 'Name', email_pengguna AS 'E-mail', nomor_telepon_pengguna AS 'Phone Number'
                            FROM PENGGUNA";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_user = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_user);

            dgv_user.DataSource = dt_user;
            dgv_user.ClearSelection();
            dgv_user.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
