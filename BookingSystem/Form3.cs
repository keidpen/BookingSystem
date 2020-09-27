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
        }

        String newSeatNo="", newDate = "", newScreen="";

        public void GetData(String seatNo , String Date,String screen)
        {
            lblSeatNo.Text = "Seat No: " + seatNo;
            lblDate.Text ="Date: " + Date;
            newSeatNo = seatNo;
            newDate = Date;
            newScreen = screen;
        }

        public void dbAddBooking()
        {
            try
            {
                Database db = new Database();
                String query = "INSERT INTO bookingdb.bookedseats(Name,SeatNo,Date,Time,Screen) VALUES('"+tbName.Text+"','"+newSeatNo+"','"+newDate+"','"+"10:00 am - 12:30 pm"+"','"+newScreen+"')";
                db.conn.Open();

                MySqlCommand command = new MySqlCommand(query,db.conn);
                if(command.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("Booked Seat!");
                    this.Visible = false;
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
