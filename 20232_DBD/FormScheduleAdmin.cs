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
    public partial class FormScheduleAdmin : Form
    {
        FormAdmin fAdmin;

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;

        public FormScheduleAdmin(FormAdmin _fAdmin, MySqlConnection _sqlConnect)
        {
            InitializeComponent();
            fAdmin = _fAdmin;
            sqlConnect = _sqlConnect;
        }
    }
}
