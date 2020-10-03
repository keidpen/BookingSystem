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
            dbAddBooking();
            Form2 form = new Form2();
            form.BookingRefresh();
            form.Visible = true;

            this.Visible = false;

        }

        String newSeatNo="", newDate = "", newScreen="";

        public void GetData(String[] seatNo , String Date,String screen)
        {
            
            foreach (string seat in seatNo)
            {
                if (seat != null)
                {
                    newSeatNo += " "+seat +",";
                    MessageBox.Show(seat);
                }
            }

            lblDate.Text = "Date: " + Date;
            lblSeatNo.Text = "Seat No: " + newSeatNo;

            newDate = Date;
            newScreen = screen;
        }

        public void dbAddBooking()
        {
            try
            {
                Database db = new Database();
                String name = tbName.Text.Trim();
                String query1 = "INSERT INTO bookingdb.tblcustomer(Name,ContactNo,Email) VALUES ('"+name+"','"+"093123"+"','"+"nolss@gmail"+"')";
                db.conn.Open();
                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                if (command1.ExecuteNonQuery() == 1)
                {
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Failed to Book Seat");
                }

                db.conn.Close();

                 


                String query2 = "INSERT INTO bookingdb.bookedseats(SeatNo,customerID,Date,Time,Screen) VALUES('"+newSeatNo+"',(SELECT customerID FROM tblcustomer WHERE customerID = (SELECT MAX(customerID) FROM tblcustomer WHERE Name = '"+name+"')),'"+newDate+"','"+"10:00 am - 12:30 pm"+"','"+newScreen+"')";
                db.conn.Open();

                MySqlCommand command2 = new MySqlCommand(query2,db.conn);
                if(command2.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("Booked Seat!");
                }
                else
                {
                    MessageBox.Show("Failed to Book Seat");
                }

                db.conn.Close();




            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
