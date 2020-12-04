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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            dbViewCstmrBkngs();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = tbSearch.Text.ToString();
            if (!keyword.Equals(""))
            {
                dbSearchCstmrBkngs(keyword);
            }
            else
            {
                MessageBox.Show("Please Input Something!");
                dbViewCstmrBkngs();
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 6)
                {
                    var s = dataGridView1[0, e.RowIndex].Value.ToString();
                    MessageBox.Show(" Dont click me!  " + s);
                }
            }
            catch (ArgumentOutOfRangeException err)
            {
                MessageBox.Show("Cannot Sort Column");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }


        public void dbViewCstmrBkngs()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                dataGridView1.ColumnCount = 6;
                dataGridView1.Columns[0].Name = "ORNo.";
                dataGridView1.Columns[1].Name = "Name";
                dataGridView1.Columns[2].Name = "Seat No.";
                dataGridView1.Columns[3].Name = "Date";
                dataGridView1.Columns[4].Name = "Time";
                dataGridView1.Columns[5].Name = "Screen";
                //dataGridView1.Columns[6].Name = "ContactNo.";
                //dataGridView1.Columns[7].Name = "Email";


                DataGridViewButtonColumn Test = new DataGridViewButtonColumn();
                Test.HeaderText = "View More";
                Test.Name = "btn";
                Test.Text = "More";
                Test.FlatStyle = FlatStyle.Popup;
                Test.DefaultCellStyle.ForeColor = Color.White;
                Test.DefaultCellStyle.BackColor = Color.CornflowerBlue;
                Test.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(Test);



                Database db = new Database();
                String query1 = "SELECT bs.ORNO, c.Name, GROUP_CONCAT(SeatNo), bs.Date,bs.Time,bs.Screen, c.ContactNo, c.Email " +
                               //  String query1 = "SELECT bs.ORNO, tblcustomer.Name, bs.SeatNo,bs.Date,bs.Time,bs.Screen, tblcustomer.ContactNo, tblcustomer.Email " +
                               "FROM bookingdb.tblbookedseats bs " +
                                "INNER JOIN tblcustomer c " +
                                "ON c.customerID = bs.customerID,tblseatno " +
                                "WHERE tblseatno.SeatNoID = bs.SeatNoID " +
                                //"AND bs.ORNO = 'OR-53' " +
                                "GROUP BY bs.ORNO " +
                                "ORDER BY bs.SeatNoID DESC ";
                db.conn.Open();
                ArrayList AL = new ArrayList();

                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                MySqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    AL = new ArrayList();
                    AL.Add(reader[0].ToString());
                    AL.Add(reader[1].ToString());
                    AL.Add(reader[2].ToString());
                    AL.Add(reader[3].ToString());
                    AL.Add(reader[4].ToString());
                    AL.Add(reader[5].ToString());
                    //AL.Add(reader[6].ToString());
                    dataGridView1.Rows.Add(AL.ToArray());



                }
                reader.Close();
                command1.Dispose();

                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                db.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dbSearchCstmrBkngs(String keyword)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                Database db = new Database();
                String query1 = "SELECT bs.ORNO, c.Name, GROUP_CONCAT(SeatNo), bs.Date,bs.Time,bs.Screen, c.ContactNo, c.Email " +
                               "FROM bookingdb.tblbookedseats bs " +
                                "INNER JOIN tblcustomer c " +
                                "ON c.customerID = bs.customerID,tblseatno " +
                                "WHERE tblseatno.SeatNoID = bs.SeatNoID " +
                                "AND bs.ORNO = '"+tbSearch.Text.ToString()+ "' " +   
                                "GROUP BY bs.ORNO " +
                                "ORDER BY bs.SeatNoID DESC ";
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
                    AL.Add(reader[7].ToString());
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
                    dbViewCstmrBkngs();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
