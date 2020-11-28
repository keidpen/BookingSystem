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

namespace BookingSystem
{
    public partial class frmPaymentCash : Form
    {
        public frmPaymentCash()
        {
            InitializeComponent();
        }
        Queue<string> ORnum = new Queue<string>();
        String newSeatNo = "", Date = "", Screen = "", Time = "";

        private void btnPayment_Click(object sender, EventArgs e)
        {
            GenerateORNO();
            InsertCostumer();
        }

        List<int> seatNo = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmPaymentCash_Load(object sender, EventArgs e)
        {
            classOrderDetail c = new classOrderDetail();
            Date = c.getDate;
            Screen = c.getScreen;
            Time = c.getTime;
            seatNo = c.getseatNo;

        }
        String generateORNO = "";

        private void GenerateORNO()
        {
            try
            {
                Database db = new Database();
                String query1 = "SELECT COALESCE(MAX(SeatNoID), 0)+1  FROM bookingdb.tblbookedseats";
                db.conn.Open();
                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                MySqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    generateORNO = "OR-" + reader[0].ToString();
                }

                reader.Close();
                command1.Dispose();
                db.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void InsertCostumer()
        {
            try
            {
                Database db = new Database();
                String name = tbName.Text.Trim(), contact = tbContact.Text.Trim(), email = tbEmail.Text.Trim();
                
                String query2 = "INSERT INTO bookingdb.tblcustomer(Name,ContactNo,Email) " +
                                "VALUES ('" + name + "','" + contact + "','" + email + "')";
                db.conn.Open();
                MySqlCommand command2 = new MySqlCommand(query2, db.conn);
                if (command2.ExecuteNonQuery() == 1)
                {
                    InsertBooking();
                    InsertTransaction();
                }
                else
                {
                    MessageBox.Show("Failed to Book Seat");
                }
                command2.Dispose();
                db.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void InsertBooking()
        {
            try
            {
                Database db = new Database();
                String name = tbName.Text.Trim(), contact = tbContact.Text.Trim(), email = tbEmail.Text.Trim();
                String query = "INSERT INTO bookingdb.tblbookedseats(ORNO,customerID,Date,Time,Screen) " +
                    "VALUES('" + generateORNO + "', " +
                    //"(SELECT customerID FROM tblcustomer WHERE customerID = (SELECT MAX(customerID) FROM tblcustomer WHERE Name = '"+name+"')), " +
                    "(SELECT customerID FROM tblcustomer WHERE (customerID = (SELECT MAX(customerID) AS Expr1 FROM tblcustomer tblcustomer_1 WHERE (Name = '" + name + "')))) ," +
                    " '" + Date + "','" + Time + "','" + Screen + "')";

                db.conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, db.conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    InsertSeatNo();
                }
                else
                {
                    MessageBox.Show("Failed to Book Seat");
                }
                cmd.Dispose();
                db.conn.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void InsertSeatNo()
        {
            try
            {
                Database db = new Database();

                int j = 0;
                for (int i = 0; i < seatNo.Count; i++)
                {
                    String query = "INSERT INTO bookingdb.tblseatno(SeatNoID,SeatNo,Date,Status) " +
                    "VALUES((SELECT MAX(SeatNoID) AS Expr1 FROM tblbookedseats) , '" + seatNo[i] + "' , '" + Date + "', 'occupied' )";

                    db.conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, db.conn);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        if (j == 0)
                        {
                            MessageBox.Show("Booked Seat!");
                            j++;
                        }
                    }
                    else
                    {
                        if (j == 0)
                        {
                            MessageBox.Show("Failed to Book Seat");
                        }
                    }
                    cmd.Dispose();
                    db.conn.Close();
                }

                classOrderDetail c = new classOrderDetail();
                c.ResetData();
                Refresh r = new Refresh();
                r.GetRefreshFrame(0);
            }
            catch(Exception err){
                MessageBox.Show(err.Message);
            }
        }


        public void InsertTransaction()
        {
            try
            {
                classTransaction c = new classTransaction();
                MessageBox.Show(c.getTotalAmmount.ToString());

                Database db = new Database();

                String query = "INSERT INTO bookingdb.tbltransaction(ORNO,Ammount,Date) " +
                                "VALUES('" + generateORNO + "' , '" + c.getTotalAmmount + "' , '"+c.getDate+"' )";

                db.conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, db.conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Transaction Complete.");
                }
                else
                {
                    MessageBox.Show("Transaction Incomplete.");
                }

                cmd.Dispose();
                db.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        //Scractch Code
        public void dbAddBooking()
        {
            try
            {
                Database db = new Database();
                String query1 = "SELECT COALESCE(MAX(SeatNoID), 0)+1  FROM bookingdb.tblbookedseats";
                db.conn.Open();
                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                MySqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    int conNplus = (int.Parse(reader[0].ToString()));
                    ORnum.Enqueue(conNplus + "");
                    generateORNO = "OR-" + reader[0].ToString();
                }

                reader.Close();
                command1.Dispose();
                db.conn.Close();


                String name = tbName.Text.Trim(), contact = tbContact.Text.Trim(), email = tbEmail.Text.Trim();
                String query2 = "INSERT INTO bookingdb.tblcustomer(Name,ContactNo,Email) " +
                                "VALUES ('" + name + "','" + contact + "','" + email + "')";
                db.conn.Open();
                MySqlCommand command2 = new MySqlCommand(query2, db.conn);
                if (command2.ExecuteNonQuery() == 1)
                {
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to Book Seat");
                }
                command2.Dispose();
                db.conn.Close();



                String query3 = "INSERT INTO bookingdb.tblbookedseats(ORNO,customerID,Date,Time,Screen) " +
                    "VALUES('" + generateORNO + "', " +
                    //"(SELECT customerID FROM tblcustomer WHERE customerID = (SELECT MAX(customerID) FROM tblcustomer WHERE Name = '"+name+"')), " +
                    "(SELECT customerID FROM tblcustomer WHERE (customerID = (SELECT MAX(customerID) AS Expr1 FROM tblcustomer tblcustomer_1 WHERE (Name = '" + name + "')))) ," +
                    " '" + Date + "','" + Time + "','" + Screen + "')";

                db.conn.Open();

                MySqlCommand command3 = new MySqlCommand(query3, db.conn);
                if (command3.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Booked Seat!");
                }
                else
                {
                    MessageBox.Show("Failed to Book Seat");
                }
                command3.Dispose();
                db.conn.Close();
                int j = 0;
                for (int i = 0; i < seatNo.Count; i++)
                {
                    String query4 = "INSERT INTO bookingdb.tblseatno(SeatNoID,SeatNo,Date,Status) " +
                    "VALUES((SELECT MAX(SeatNoID) AS Expr1 FROM tblbookedseats) , '" + seatNo[i] + "' , '" + Date + "', 'occupied' )";

                    db.conn.Open();

                    command3 = new MySqlCommand(query4, db.conn);
                    if (command3.ExecuteNonQuery() == 1)
                    {
                        if (j == 0)
                        {
                            MessageBox.Show("Booked Seat!");
                            j++;
                        }
                    }
                    else
                    {
                        if (j == 0)
                        {
                            MessageBox.Show("Failed to Book Seat");
                        }
                    }
                    command3.Dispose();
                    db.conn.Close();

                }

                classOrderDetail c = new classOrderDetail();
                c.ResetData();
                Refresh r = new Refresh();
                r.GetRefreshFrame(0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



    }
}
