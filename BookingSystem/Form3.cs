using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BookingSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            if(!tbName.Text.Trim().Equals("")  && !tbContact.Text.Trim().Equals("") && !tbEmail.Text.Trim().Equals(""))
            {
                dbAddBooking();
                PrintReceipt();

                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();

                //Form2 form = new Form2();
                //form.BookingRefresh();
                //form.Visible = true;

                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Please input some infor!");
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Welcome to", new Font("Arial",12,FontStyle.Regular), Brushes.Black, new Point(10,10));
        }


        public void PrintReceipt()
        {
            StreamWriter file = new StreamWriter("Receipt " + ORnum.Peek()+".txt");
            file.Write("=================   OR No.:"+ORnum.Peek()+"    =====================\r\n\n");
            file.Write("Schedule Date: "+ newDate);
            file.Write("\r\nScreen No.: "+ newScreen);
            file.Write("\r\nBooked Seat No.: "+ newSeatNo);
            file.Close();
        }


        String newSeatNo="", newDate = "", newScreen="", SelSchedTime="";



        public void GetData(List<string> seatNo , String Date,String screen, String SelSchedTime)
        {
            foreach (string seat in seatNo)
            {
                if (seat != null)
                {
                    newSeatNo += " "+seat +",";
                    MessageBox.Show(seat);
                }
            }

            this.SelSchedTime = SelSchedTime;
            lblDate.Text = "Date: " + Date;
            lblSeatNo.Text = "Seat No: " + newSeatNo;

            newDate = Date;
            newScreen = screen;
        }

        Queue<string> ORnum = new Queue<string>();
        public void dbAddBooking()
        {
            try
            {
                Database db = new Database();
                String query1 = "SELECT MAX(ID) FROM bookingdb.bookedseats";
                db.conn.Open();
                MySqlCommand command1 = new MySqlCommand(query1,db.conn);
                MySqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    int conNplus = (int.Parse(reader[0].ToString()))+1;
                    ORnum.Enqueue(conNplus+"");
                }
                reader.Close();
                command1.Dispose();
                db.conn.Close();
                

                String name = tbName.Text.Trim(), contact = tbContact.Text.Trim(), email = tbEmail.Text.Trim();
                String query2 = "INSERT INTO bookingdb.tblcustomer(Name,ContactNo,Email) " +
                                "VALUES ('"+name+"','"+contact+"','"+email+"')";
                db.conn.Open();
                MySqlCommand command2 = new MySqlCommand(query2, db.conn);
                if (command2.ExecuteNonQuery() == 1)
                {
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Failed to Book Seat");
                }
                command2.Dispose();
                db.conn.Close();



                String query3 = "INSERT INTO bookingdb.bookedseats(ORNO, SeatNo,customerID,Date,Time,Screen) " +
                    "VALUES('"+"OR-"+ORnum.Peek() + "','"+newSeatNo+"'," +
                    "(SELECT customerID FROM tblcustomer WHERE customerID = " +
                    "(SELECT MAX(customerID) FROM tblcustomer WHERE Name = '"+name+"')),'"+newDate+"','"+ SelSchedTime + "','"+newScreen+"')";
                
                db.conn.Open();

                MySqlCommand command3 = new MySqlCommand(query3,db.conn);
                if(command3.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("Booked Seat!");
                }
                else
                {
                    MessageBox.Show("Failed to Book Seat");
                }
                command3.Dispose();
                db.conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
