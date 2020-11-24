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
    public partial class frmContactTracing : Form
    {
        public frmContactTracing()
        {
            InitializeComponent();
        }

        private void frmContactTracing_Load(object sender, EventArgs e)
        {
            RetrieveData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Seat No", typeof(string));
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Time", typeof(string));
            dt.Columns.Add("Screen", typeof(string));
            dt.Columns.Add("Contact No.", typeof(string));
            dt.Columns.Add("Email", typeof(string));

            foreach (DataGridViewRow dgv in dataGridView1.Rows)
            {
                    dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value, dgv.Cells[6].Value);
            }

            ds.Tables.Add(dt);
            ds.WriteXmlSchema("Sample.xml");

            ContactTracing cr = new ContactTracing();
            cr.SetDataSource(ds);
            frmData frm = new frmData();
            frm.crystalReportViewer1.ReportSource = cr;
            frm.Show();
        }

        public void RetrieveData()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                dataGridView1.ColumnCount = 7;

                dataGridView1.Columns[0].Name = "Name";
                dataGridView1.Columns[1].Name = "Seat No.";
                dataGridView1.Columns[2].Name = "Date";
                dataGridView1.Columns[3].Name = "Time";
                dataGridView1.Columns[4].Name = "Screen";
                dataGridView1.Columns[5].Name = "Contact No.";
                dataGridView1.Columns[6].Name = "Email.";
                DateTime dt = DateTime.Today;
                Database db = new Database();

                String query1;
                //if (dateTimePicker1.Value==null && dateTimePicker2.Value==null)
                //{
                //    query1 = "SELECT tblcustomer.Name, bs.SeatNo,bs.Date,bs.Time,bs.Screen, tblcustomer.ContactNo, tblcustomer.Email " +
                //                    "FROM bookingdb.tblbookedseats bs " +
                //                    "JOIN tblcustomer " +
                //                    "ON tblcustomer.customerID = bs.customerID " +
                //                    //          "WHERE Date = '" + dt.ToString("yyyy-MM-dd") + "'" +
                //                    "ORDER BY bs.ID DESC ";
                //}
                //else
                //{
                    query1 = "SELECT tblcustomer.Name, bs.SeatNo,bs.Date,bs.Time,bs.Screen, tblcustomer.ContactNo, tblcustomer.Email " +
                                    "FROM bookingdb.tblbookedseats bs " +
                                    "JOIN tblcustomer " +
                                    "ON tblcustomer.customerID = bs.customerID " +
                                    "WHERE Date BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") +"'" +
                                    "ORDER BY Date DESC ";
                //}
                db.conn.Open();
                ArrayList AL = new ArrayList();

                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                MySqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    AL = new ArrayList();
                    AL.Add(reader[0].ToString());
                    AL.Add(reader[1].ToString());
                    AL.Add(reader[2].ToString().Trim());
                    AL.Add(reader[3].ToString());
                    AL.Add(reader[4].ToString());
                    AL.Add(reader[5].ToString());
                    AL.Add(reader[6].ToString());
                    // AL.Add(reader[7].ToString());
                    dataGridView1.Rows.Add(AL.ToArray());
                }
                reader.Close();
                command1.Dispose();

                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                db.conn.Close();


                if (dataGridView1.Rows.Count == 0 || dataGridView1.Rows == null)
                {
                    MessageBox.Show("No Result Found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < dateTimePicker2.Value)
            {
                RetrieveData();
            }
            else
            {
                dateTimePicker2.Value = dateTimePicker1.Value;
                RetrieveData();
                MessageBox.Show(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            RetrieveData();
        }
    }
}
