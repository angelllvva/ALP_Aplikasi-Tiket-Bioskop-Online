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
    public partial class FormTransactionsAdmin : Form
    {
        FormAdmin fAdmin;

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;

        DataTable dt_jumlahTransaksi;
        DataTable dt_transaksi;

        public FormTransactionsAdmin(FormAdmin _fAdmin, MySqlConnection _sqlConnect)
        {
            InitializeComponent();
            fAdmin = _fAdmin;
            sqlConnect = _sqlConnect;
        }

        private void FormTransactionsAdmin_Load(object sender, EventArgs e)
        {
            sqlQuery = $@"SELECT status_pemesanan_transaksi_booking AS 'Status', COUNT(jumlah_tiket_transaksi_booking) AS 'Jumlah Transaksi'
                            FROM TRANSAKSI_BOOKING
                            GROUP BY 1";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_jumlahTransaksi = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_jumlahTransaksi);

            lb_numSucceed.Text = dt_jumlahTransaksi.Rows[0][1].ToString();
            lb_numDelayed.Text = dt_jumlahTransaksi.Rows[2][1].ToString();
            lb_numCanceled.Text = dt_jumlahTransaksi.Rows[1][1].ToString();

            sqlQuery = $@"SELECT id_transaksi_booking 'Booking ID',
                                 id_pengguna AS 'User ID', 
                                 metode_pembayaran_transaksi_booking AS 'Payment Method', 
                                 jumlah_tiket_transaksi_booking AS 'Total Ticket', 
                                 IF(status_pemesanan_transaksi_booking = 'Tertunda', 'Delayed', 
                                 IF(status_pemesanan_transaksi_booking = 'Berhasil', 'Succeed', 'Canceled')) AS 'Status'
                            FROM TRANSAKSI_BOOKING";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            dt_transaksi = new DataTable();
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt_transaksi);

            dgv_transactions.DataSource = dt_transaksi;
            dgv_transactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
