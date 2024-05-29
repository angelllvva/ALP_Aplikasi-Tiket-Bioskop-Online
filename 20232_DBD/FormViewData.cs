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

namespace _20232_DBD
{
    public partial class FormViewData : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;

        string sqlQuery;
        DataTable dt_pengguna;

        public FormViewData(MySqlConnection conForm)
        {
            InitializeComponent();
            sqlConnect = conForm;
        }

        private void FormViewData_Load(object sender, EventArgs e)
        {
            dt_pengguna = new DataTable();
            sqlQuery = "SELECT * FROM PENGGUNA";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_pengguna);
            dataGridView1.DataSource = dt_pengguna;
        }
    }
}
