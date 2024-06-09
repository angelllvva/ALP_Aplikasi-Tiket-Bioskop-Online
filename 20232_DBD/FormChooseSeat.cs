using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Renci.SshNet;

namespace _20232_DBD
{
    public partial class FormChooseSeat : Form
    {
        FormMain fMain;

        List<Button> buttonList = new List<Button>();

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;

        string _tanggal;
        string _judulFILM;
        string _jam;
        string _id;
        string _time;
        string _pboxConfirmOrder;
        string _idPengguna;
        int count;

        DataTable _dtOrderConfirm = new DataTable();
        DataTable _dt_seat = new DataTable();
        List<String> listSeat = new List<String>();
        List<string> listSeatCheck = new List<string>();
        DataTable dt_idTransaksi;

        public FormChooseSeat(FormMain _fMain, MySqlConnection conForm)
        {
            InitializeComponent();
            sqlConnect = conForm;
            fMain = _fMain;
            _tanggal = fMain.tanggal;
            _judulFILM = fMain.judulFilm;
            _jam = fMain.jam;
            _id = fMain.id;
            _dtOrderConfirm = fMain.dt_orderConfirm;
            _time = fMain.time;
            _pboxConfirmOrder = fMain.picturename;
            _dt_seat = fMain.dt_seat;
            _idPengguna = fMain.idPengguna;
        }

        private void pBox_backChooseSeat_Click(object sender, EventArgs e)
        {
            fMain.closeChildForm();
        }

        private void FormChooseSeat_Load(object sender, EventArgs e)
        {
            pnl_orderConfirmation.Visible = false;

            // Set lokasi button Seat
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Button buttonbaru = new Button();
                    if (i == 0)
                    {
                        buttonbaru.Text = "E" + (j + 1).ToString();
                    }
                    else if (i == 1)
                    {
                        buttonbaru.Text = "D" + (j + 1).ToString();
                    }
                    else if (i == 2)
                    {
                        buttonbaru.Text = "C" + (j + 1).ToString();
                    }
                    else if (i == 3)
                    {
                        buttonbaru.Text = "B" + (j + 1).ToString();
                    }
                    if (i == 4)
                    {
                        buttonbaru.Text = "A" + (j + 1).ToString();
                    }

                    buttonbaru.Size = new Size(40, 40);
                    if (j == 2)
                    {
                        buttonbaru.Location = new Point((j * 40) + 50, 70 + (i * 40));
                    }
                    else if (j > 2 && j < 10)
                    {
                        buttonbaru.Location = new Point((j * 40) + 50, 70 + (i * 40));
                    }
                    else if (j == 10)
                    {
                        buttonbaru.Location = new Point((j * 40) + 70, 70 + (i * 40));
                    }
                    else if (j > 10)
                    {
                        buttonbaru.Location = new Point((j * 40) + 70, 70 + (i * 40));
                    }
                    else
                    {
                        buttonbaru.Location = new Point((j * 40) + 30, 70 + (i * 40));
                    }

                    buttonbaru.BackColor = Color.LimeGreen;
                    buttonbaru.Tag = "Green";
                    buttonbaru.Click += new EventHandler(buttonClicksEvent);
                    buttonList.Add(buttonbaru);
                    this.Controls.Add(buttonbaru);
                }
            }

            for (int i = 0; i < _dt_seat.Rows.Count; i++)
            {
                listSeatCheck.Add(_dt_seat.Rows[i][0].ToString());
            }

            for (int i = 0; i < buttonList.Count; i++)
            {
                if (listSeatCheck.Contains(buttonList[i].Text.ToString()))
                {
                    buttonList[i].Enabled = false;
                    buttonList[i].BackColor = Color.FromArgb(163, 174, 186);
                    buttonList[i].Tag = "Unavailable";
                }
            }

            // Label isi Confirm Order
            lb_filmNameOrderConfirmation.Text = _dtOrderConfirm.Rows[0][0].ToString();
            lb_date.Text = _tanggal.ToString();
            lb_time.Text = _time;
            lb_studio.Text = _dtOrderConfirm.Rows[0][3].ToString();
        }

        public void buttonClicksEvent(object sender, EventArgs e)
        {
            // Set tanda seat
            Button btn = (Button)sender;

            if (btn.Tag == "Green")
            {
                btn.BackColor = Color.Yellow;
                btn.Tag = "Yellow";
            }
            else if (btn.Tag == "Yellow")
            {
                btn.BackColor = Color.LimeGreen;
                btn.Tag = "Green";
            }
            else if (btn.Tag == "Unavailable")
            {
                MessageBox.Show("This seat is taken");
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            //Nampilin Posterr
            System.Drawing.Bitmap image = Properties.Resources.ResourceManager.GetObject($"{_pboxConfirmOrder}") as System.Drawing.Bitmap;
            pBox_filmPosterOrderConfirmation.Image = image;

            //masukan seat dipilih dan total harga ke order confirm
            for (int i = 0; i < buttonList.Count; i++)
            {
                if (buttonList[i].Tag == "Yellow")
                {
                    listSeat.Add(buttonList[i].Text.ToString());
                }
            }
            for (int i = 0; i < buttonList.Count; i++)
            {
                if (buttonList[i].Tag == "Green")
                {
                    listSeat.Remove(buttonList[i].Text.ToString());
                }
            }

            string tampilseat = string.Join(",", listSeat);
            lb_seats.Text = tampilseat;
            lb_ticketPrice.Text = listSeat.Count.ToString() + " X  25.000";
            int total = listSeat.Count * 25000;
            lb_total.Text = "Rp. " + total.ToString();

            if (listSeat.Count == 0)
            {
                MessageBox.Show("Please choose a seat first");
            }
            else if (listSeat.Count > 0)
            {
                pnl_orderConfirmation.Visible = true;
            }
        }

        private void btn_payNow_Click(object sender, EventArgs e)
        {
            // Cek metode bayar
            string methodSelected = "";
            if (rBtn_gopay.Checked == false && rBtn_qris.Checked == false && rBtn_shopeePay.Checked == false && rBtn_transferBank.Checked == false && rBtn_ovo.Checked == false)
            {
                MessageBox.Show("Please choose one of the payment method");
            }
            else
            {
                // Membuat ID Transaksi
                string idTransaksi = "";

                // Singkatan metode bayar
                if (rBtn_transferBank.Checked == true)
                {
                    idTransaksi = "TF";
                    methodSelected = rBtn_transferBank.Text;
                }
                else if (rBtn_gopay.Checked == true)
                {
                    idTransaksi = "GP";
                    methodSelected = rBtn_gopay.Text;
                }
                else if (rBtn_qris.Checked == true)
                {
                    idTransaksi = "QR";
                    methodSelected = rBtn_qris.Text;
                }
                else if (rBtn_shopeePay.Checked == true)
                {
                    idTransaksi = "SP";
                    methodSelected = rBtn_shopeePay.Text;
                }
                else if (rBtn_ovo.Checked == true)
                {
                    idTransaksi = "OV";
                    methodSelected = rBtn_ovo.Text;
                }

                // Tanggal
                string[] splitTanggal = new string[3];
                splitTanggal[0] = _tanggal.Substring(0, 4); //tahun
                splitTanggal[1] = _tanggal.Substring(5, 2); //bulan
                splitTanggal[2] = _tanggal.Substring(8, 2); //tanggal
                idTransaksi += splitTanggal[2] + splitTanggal[1] + splitTanggal[0].Substring(2, 2);

                // Cek nomor urut
                dt_idTransaksi = new DataTable();
                sqlQuery = $"SELECT SUBSTRING(id_transaksi_booking,1,8) FROM TRANSAKSI_BOOKING";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dt_idTransaksi);

                count = 1;
                for (int i = 0; i < dt_idTransaksi.Rows.Count; i++)
                {
                    if (dt_idTransaksi.Rows[i][0].ToString() == idTransaksi)
                    {
                        count++;
                    }
                }

                if (count < 10)
                {
                    idTransaksi += $"00{count}";
                }
                else if (count > 9 && count < 100)
                {
                    idTransaksi += $"0{count}";
                }
                else
                {
                    idTransaksi += count;
                }

                // Memasukkan transaksi ke database
                sqlQuery = $"INSERT INTO TRANSAKSI_BOOKING VALUES ('{idTransaksi}', '{_idPengguna}', '{_id}', '{methodSelected}', '{listSeat.Count}', 'Berhasil', '0')";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                sqlConnect.Open();

                MessageBox.Show("Payment Complete");

                // Update status kursi di database
                for (int i = 0; i < listSeat.Count; i++)
                {
                    sqlQuery = $@"UPDATE KURSI 
                                    SET status_kursi = 1 
                                    WHERE id_jadwal_tayang = '{_id}' AND nomor_kursi = '{listSeat[i]}'";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();

                    sqlConnect.Close();
                    sqlConnect.Open();
                }

                this.Close();
            }
        }

        private void pBox_backOrderConfirmation_Click(object sender, EventArgs e)
        {
            listSeat.Clear();
            pnl_orderConfirmation.Visible = false;
        }
    }
}
