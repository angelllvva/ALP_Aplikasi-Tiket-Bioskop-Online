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

namespace _20232_DBD
{
    
    public partial class FormLogin : Form
    {
        public MySqlConnection myConn;
        public SshClient client;
        public FormLogin()
        {
            InitializeComponent();
        }

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
            client.AddForwardedPort(forwardedPortLocal);
            forwardedPortLocal.Start();

            myConn = new MySqlConnection("SERVER=127.0.0.1;PORT=3306;UID=indramar_group9;PASSWORD=1ffl6]?A9uyx;DATABASE=indramar_20232_dbd_9");
            myConn.Open();

            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            FormViewData fView = new FormViewData(myConn);
            fView.ShowDialog();
        }
    }
}
