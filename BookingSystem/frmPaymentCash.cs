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
        List<String> seatNo = new List<String>();
        //List<int> seatNo = new List<int>();
        Queue<string> ORnum = new Queue<string>();
        String newSeatNo = "",currentDate="" ,Date = "", Screen = "", Time = "",generateORNO = "";

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (tbCash.Text.ToString()!="" || tbCash.Text.ToString() !=null) {
                double cash = double.Parse(tbCash.Text.ToString().Trim());
                double change = double.Parse(lblChange.Text.ToString().Trim());

                classTransaction t = new classTransaction();
                t.setCash(cash);
                t.setChange(change);
                t.setName(tbName.Text);

                GenerateORNO();
                InsertCostumer();
                GenerateReceipt();
            }
        }


        private void frmPaymentCash_Load(object sender, EventArgs e)
        {
            classOrderDetail c = new classOrderDetail();
            Date = c.getDate;
            Screen = c.getScreen;
            Time = c.getTime;
            seatNo = c.getseatNo;

            classTransaction t = new classTransaction();
            currentDate = t.getDate;
        }

        Timer time = new Timer();
        private void GenerateReceipt()
        {
            time.Interval = 1000;
            time.Tick += new EventHandler(close);
            time.Start();

            frmReceiptViewer frm = new frmReceiptViewer();
            frm.ShowDialog(this);
        }

        public void close(object sender, EventArgs e)
        {
            Refresh r = new Refresh();
            if (r.SetRefreshFrame() == 0)
            {
                time.Dispose();
                this.Close();
            }
        }

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

        private void tbCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            
        }

        private void tbCash_TextChanged(object sender, EventArgs e)
        {
            if (tbCash.Text.Length >=1) {
                classTransaction c = new classTransaction();
                double ammount =  double.Parse(tbCash.Text) - c.getTotalAmmount;

                lblChange.Text = String.Format("{0:0.00}", ammount);
            }
            else
            {
                lblChange.Text = "0";
            }
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

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
                    "VALUES((SELECT MAX(SeatNoID) AS Expr1 FROM tblbookedseats) , '" + seatNo[i] + "' , '" + currentDate + "', 'occupied' )";

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

                //classOrderDetail c = new classOrderDetail();
                //c.ResetData();
                //Refresh r = new Refresh();
                //r.GetRefreshFrame(0);
            }
            catch(Exception err){
                MessageBox.Show(err.Message);
            }
        }


        private void InsertTransaction()
        {
            try
            {
                classTransaction c = new classTransaction();
                c.setORNO(generateORNO);

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
        //public void dbAddBooking()
        //{
        //    try
        //    {
        //        Database db = new Database();
        //        String query1 = "SELECT COALESCE(MAX(SeatNoID), 0)+1  FROM bookingdb.tblbookedseats";
        //        db.conn.Open();
        //        MySqlCommand command1 = new MySqlCommand(query1, db.conn);
        //        MySqlDataReader reader = command1.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            int conNplus = (int.Parse(reader[0].ToString()));
        //            ORnum.Enqueue(conNplus + "");
        //            generateORNO = "OR-" + reader[0].ToString();
        //        }

        //        reader.Close();
        //        command1.Dispose();
        //        db.conn.Close();


        //        String name = tbName.Text.Trim(), contact = tbContact.Text.Trim(), email = tbEmail.Text.Trim();
        //        String query2 = "INSERT INTO bookingdb.tblcustomer(Name,ContactNo,Email) " +
        //                        "VALUES ('" + name + "','" + contact + "','" + email + "')";
        //        db.conn.Open();
        //        MySqlCommand command2 = new MySqlCommand(query2, db.conn);
        //        if (command2.ExecuteNonQuery() == 1)
        //        {
        //            //this.Close();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Failed to Book Seat");
        //        }
        //        command2.Dispose();
        //        db.conn.Close();



        //        String query3 = "INSERT INTO bookingdb.tblbookedseats(ORNO,customerID,Date,Time,Screen) " +
        //            "VALUES('" + generateORNO + "', " +
        //            //"(SELECT customerID FROM tblcustomer WHERE customerID = (SELECT MAX(customerID) FROM tblcustomer WHERE Name = '"+name+"')), " +
        //            "(SELECT customerID FROM tblcustomer WHERE (customerID = (SELECT MAX(customerID) AS Expr1 FROM tblcustomer tblcustomer_1 WHERE (Name = '" + name + "')))) ," +
        //            " '" + Date + "','" + Time + "','" + Screen + "')";

        //        db.conn.Open();

        //        MySqlCommand command3 = new MySqlCommand(query3, db.conn);
        //        if (command3.ExecuteNonQuery() == 1)
        //        {
        //            //MessageBox.Show("Booked Seat!");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Failed to Book Seat");
        //        }
        //        command3.Dispose();
        //        db.conn.Close();
        //        int j = 0;
        //        for (int i = 0; i < seatNo.Count; i++)
        //        {
        //            String query4 = "INSERT INTO bookingdb.tblseatno(SeatNoID,SeatNo,Date,Status) " +
        //            "VALUES((SELECT MAX(SeatNoID) AS Expr1 FROM tblbookedseats) , '" + seatNo[i] + "' , '" + Date + "', 'occupied' )";

        //            db.conn.Open();

        //            command3 = new MySqlCommand(query4, db.conn);
        //            if (command3.ExecuteNonQuery() == 1)
        //            {
        //                if (j == 0)
        //                {
        //                    MessageBox.Show("Booked Seat!");
        //                    j++;
        //                }
        //            }
        //            else
        //            {
        //                if (j == 0)
        //                {
        //                    MessageBox.Show("Failed to Book Seat");
        //                }
        //            }
        //            command3.Dispose();
        //            db.conn.Close();

        //        }

        //        classOrderDetail c = new classOrderDetail();
        //        c.ResetData();
        //        Refresh r = new Refresh();
        //        r.GetRefreshFrame(0);

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}



    }
}
