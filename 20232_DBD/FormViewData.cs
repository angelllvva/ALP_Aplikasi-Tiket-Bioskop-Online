﻿using System;
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

        public FormViewData(MySqlConnection conForm)
        {
            InitializeComponent();
            sqlConnect = conForm;
        }
    }
}
