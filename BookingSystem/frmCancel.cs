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
            RetrieveData();
        }



        private void RetrieveData()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].Name = "Seat No.";
                dataGridView1.Columns[1].Name = "Date";
                dataGridView1.Columns[2].Name = "Status";

                DataGridViewButtonColumn btnCancel = new DataGridViewButtonColumn();
                btnCancel.HeaderText = "";
                btnCancel.Name = "btn";
                btnCancel.Text = "Cancel";
                btnCancel.FlatStyle = FlatStyle.Popup;
                btnCancel.DefaultCellStyle.ForeColor = Color.White;
                btnCancel.DefaultCellStyle.BackColor = Color.OrangeRed;
                btnCancel.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnCancel);

                String query = "SELECT SeatNo, DATE_FORMAT(Date,'%y-%m-%d'), Status FROM tblseatno WHERE SeatNoID = '1'";
                Database db = new Database();
                db.conn.Open();
                MySqlCommand cmd = new MySqlCommand(query,db.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                ArrayList AL = new ArrayList();
                while (reader.Read())
                {
                    AL = new ArrayList();
                    AL.Add(reader[0].ToString());
                    AL.Add(reader[1].ToString());
                    AL.Add(reader[2].ToString());

                    dataGridView1.Rows.Add(AL.ToArray());
                }


                cmd.Dispose();
                db.conn.Close();

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
                String status = dataGridView1[2, e.RowIndex].Value.ToString();

                if (e.ColumnIndex == 3 && status == "occupied")
                {
                    var s = dataGridView1[2, e.RowIndex].Value.ToString();
                    MessageBox.Show(" Dont click me!  " + s);
                }
                else
                {
                    MessageBox.Show("You can't cancel the booking.");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void CancelBooking()
        {
            
        }
    }
}
