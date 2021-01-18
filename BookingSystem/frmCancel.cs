using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem
{
    public partial class frmCancel : Form
    {
        public frmCancel()
        {
            InitializeComponent();
        }

        private void frmCancel_Load(object sender, EventArgs e)
        {

        }

        String Orno = "";
        public void RetrieveDetail(String OrNo)
        {
            try{

                Orno = OrNo;
                Database db = new Database();
                db.conn.Open();
                String query = "SELECT c.Name, c.ContactNo, c.Email, bs.`Date`, bs.`Time`, bs.Screen "+
                               "FROM tblcustomer c INNER JOIN tblbookedseats bs ON c.customerID = bs.customerID " +
                                "WHERE(bs.ORNO = '"+OrNo+"')";
                MySqlCommand cmd = new MySqlCommand(query,db.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblName.Text = reader[0].ToString();
                    lblContactNo.Text = reader[1].ToString();
                    lblEmail.Text = reader[2].ToString();
                    lblDate.Text = reader[3].ToString();
                    lblTime.Text = reader[4].ToString();
                    lblScreen.Text = reader[5].ToString();
                    RetrieveSeats(OrNo);
                }
                else
                {
                    MessageBox.Show("Something Wnet");
                }

                db.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void RetrieveSeats(String OrNo)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                dataGridView1.ColumnCount = 2;
                dataGridView1.Columns[0].Name = "Seat No.";
                dataGridView1.Columns[1].Name = "Status";

                DataGridViewButtonColumn btnCancel = new DataGridViewButtonColumn();
                btnCancel.HeaderText = "";
                btnCancel.Name = "btn";
                btnCancel.Text = "Cancel";
                btnCancel.FlatStyle = FlatStyle.Popup;
                btnCancel.DefaultCellStyle.ForeColor = Color.White;
                btnCancel.DefaultCellStyle.BackColor = Color.OrangeRed;
                btnCancel.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnCancel);

                String shit = "SELECT s.SeatNo, Status FROM tblbookedseats bs INNER JOIN tblseatno s ON bs.SeatNoID = s.SeatNoID WHERE bs.ORNO = '"+OrNo+"'";



                String query = "SELECT SeatNo, DATE_FORMAT(bs.Date,'%y-%m-%d'), Status FROM tblseatno WHERE SeatNoID = '1'";
                Database db = new Database();
                db.connection.Open();
                MySqlCommand cmd = new MySqlCommand(shit,db.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                ArrayList AL = new ArrayList();
                while (reader.Read())
                {
                    AL = new ArrayList();
                    AL.Add(reader[0].ToString());
                    AL.Add(reader[1].ToString());

                    dataGridView1.Rows.Add(AL.ToArray());
                }


                cmd.Dispose();
                db.connection.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String status = dataGridView1[1, e.RowIndex].Value.ToString();

                if (e.ColumnIndex == 2 && status == "occupied")
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel booking?", "Cancel Booking?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        String seatNo = dataGridView1[0, e.RowIndex].Value.ToString();
                        CancelBooking(seatNo);
                    }
                }
                else if (e.ColumnIndex == 2 && status == "canceled")
                {
                    MessageBox.Show("The seat is already canceled");
                }
                
            }
            catch (ArgumentOutOfRangeException err)
            {
                MessageBox.Show("Unable to click");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
}

        private void CancelBooking(String SeatNo)
        {
            try
            {
                DateTime dt = DateTime.Now;

                Database db = new Database();
                db.conn.Open();
                String query = "UPDATE tblseatno SET Date = '"+dt.ToString("yyyy-MM-dd")+"', Status= 'canceled' " +
                               "WHERE SeatNoID = ANY(SELECT SeatNoID FROM tblbookedseats "+
                                        "WHERE ORNO = '"+Orno+ "') AND SeatNo = '" + SeatNo + "'";
                MySqlCommand cmd = new MySqlCommand(query,db.conn);
                if (cmd.ExecuteNonQuery().ToString() == "1")
                {
                    MessageBox.Show("Success");
                    RetrieveSeats(Orno);
                }
                else
                {
                    MessageBox.Show("Failed");
                }

                db.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
