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
    public partial class FormHomeAdmin : Form
    {
        FormAdmin fAdmin;

        public FormHomeAdmin(FormAdmin _fAdmin)
        {
            InitializeComponent();
            fAdmin = _fAdmin;
        }
    }
}
