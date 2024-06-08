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
    public partial class FormChooseSeat : Form
    {
        FormMain fMain;

        public FormChooseSeat(FormMain _fMain)
        {
            InitializeComponent();
            fMain = _fMain;
        }

        private void pBox_backChooseSeat_Click(object sender, EventArgs e)
        {
            fMain.closeChildForm();
        }
    }
}
