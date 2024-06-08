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
    public partial class FormFilmAdmin : Form
    {
        FormAdmin fAdmin;

        public FormFilmAdmin(FormAdmin _fAdmin)
        {
            InitializeComponent();
            fAdmin = _fAdmin;
        }
    }
}
