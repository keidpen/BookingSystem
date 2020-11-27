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
            RetrievePrices();
            InsertBtn();
        }

        double PriceA = 0, PriceB = 0,PriceC = 0, PriceD = 0, PriceE = 0, PriceF = 0, PriceG = 0;
        void RetrievePrices()
        {
            classRetrieveSeatCatPrice r = new classRetrieveSeatCatPrice();
            lblPriceA.Text = r.CatSeat_A.ToString();
            PriceA = r.CatSeat_A;
            lblPriceB.Text = r.CatSeat_B.ToString();
            PriceB = r.CatSeat_B;
            lblPriceC.Text = r.CatSeat_C.ToString();
            PriceC = r.CatSeat_C;
            lblPriceD.Text = r.CatSeat_D.ToString();
            PriceD = r.CatSeat_D;
            lblPriceE.Text = r.CatSeat_E.ToString();
            PriceE = r.CatSeat_E;
            lblPriceF.Text = r.CatSeat_F.ToString();
            PriceF = r.CatSeat_F;
            lblPriceG.Text = r.CatSeat_G.ToString();
            PriceG = r.CatSeat_G;
        }

        int intQtyA = 0, intQtyB = 0, intQtyC = 0, intQtyD = 0, intQtyE = 0, intQtyF = 0, intQtyG = 0;

        private void label10_Click(object sender, EventArgs e)
        {

        }

        void InsertBtn()
        {
            for (int i=1; i <= 308 ;i++)
            {
                if (seatNo.Contains(i))
                {
                    Button btnseats = new Button();
                    btnseats.Text = i.ToString();
                    btnseats.Size = new Size(40,40);

                    if (i>=1 && i<=56)
                    {
                        MessageBox.Show("A");
                        flpCatA.Controls.Add(btnseats);
                        intQtyA++;
                    }
                    else if ((i >= 57 && i <= 65) || (i >= 85 && i <= 93) || (i >= 113 && i <= 121))
                    {
                        MessageBox.Show("B");
                        flpCatB.Controls.Add(btnseats);
                        intQtyB++;
                    }
                    else if ((i >= 66 && i <= 75) || (i >= 93 && i <= 103) || (i >= 122 && i <= 131))
                    {
                        MessageBox.Show("C");
                        flpCatC.Controls.Add(btnseats);
                        intQtyC++;
                    }
                    else if ((i >= 76 && i <= 84) || (i >= 104 && i <= 112) || (i >= 132 && i <= 140))
                    {
                        MessageBox.Show("D");
                        flpCatD.Controls.Add(btnseats);
                        intQtyD++;
                    }
                    else if ((i >= 141 && i <= 154) || (i >= 169 && i <= 182) || (i >= 197 && i <= 210))
                    {
                        MessageBox.Show("E");
                        flpCatE.Controls.Add(btnseats);
                        intQtyE++;
                    }
                    else if ((i >= 155 && i <= 168) || (i >= 183 && i <= 196) || (i >= 197 && i <= 210))
                    {
                        MessageBox.Show("F");
                        flpCatF.Controls.Add(btnseats);
                        intQtyF++;
                    }
                    else if (i>=225 && i <=308)
                    {
                        MessageBox.Show("G");
                        flpCatG.Controls.Add(btnseats);
                        intQtyG++;
                    }
                    double totalA = 0, totalB = 0, totalC = 0, totalD = 0, totalE = 0, totalF = 0, totalG = 0;

                    lblQtyA.Text = intQtyA.ToString();
                    totalA = intQtyA * PriceA;
                    lblAm_A.Text = totalA.ToString();

                    lblQtyB.Text = intQtyB.ToString();
                    totalB = intQtyB * PriceB;
                    lblAm_B.Text = totalB.ToString();

                    lblQtyC.Text = intQtyC.ToString();
                    totalC = intQtyC * PriceC;
                    lblAm_C.Text = totalC.ToString();

                    lblQtyD.Text = intQtyD.ToString();
                    totalD = intQtyD * PriceD;
                    lblAm_D.Text = totalD.ToString();

                    lblQtyE.Text = intQtyE.ToString();
                    totalE = intQtyE * PriceE;
                    lblAm_E.Text = totalE.ToString();

                    lblQtyF.Text = intQtyF.ToString();
                    totalF = intQtyF * PriceF;
                    lblAm_F.Text = totalF.ToString();

                    lblQtyG.Text = intQtyG.ToString();
                    totalG = intQtyG * PriceG;
                    lblAm_G.Text = totalG.ToString();

                    lblTotalAm.Text = (totalA + totalB + totalC + totalD + totalE + totalF + totalG).ToString();
                }
            }
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            if(!tbName.Text.Trim().Equals("")  && !tbContact.Text.Trim().Equals("") && !tbEmail.Text.Trim().Equals(""))
            {
                dbAddBooking();
                PrintReceipt();

                //printPreviewDialog1.Document = printDocument1;
                //printPreviewDialog1.ShowDialog();

                Refresh r = new Refresh();
                r.GetRefreshFrame(0);

                this.Close();
                
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
        List<int> seatNo = new List<int>();

        private void flpCatA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void GetData(List<string> seatNo , String Date,String screen, String SelSchedTime)
        {
            foreach (string seat in seatNo)
            {
                if (seat != null)
                {
                    newSeatNo += " "+seat +",";
                    this.seatNo.Add(int.Parse(seat));
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
                String query1 = "SELECT COALESCE(MAX(SeatNoID), 0)+1  FROM bookingdb.tblbookedseats";
                db.conn.Open();
                MySqlCommand command1 = new MySqlCommand(query1,db.conn);
                MySqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    int conNplus = (int.Parse(reader[0].ToString()));
                    ORnum.Enqueue(conNplus + "");
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
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to Book Seat");
                }
                command2.Dispose();
                db.conn.Close();



                String query3 =  "INSERT INTO bookingdb.tblbookedseats(ORNO,customerID,Date,Time,Screen) " +
                    "VALUES('"+"OR-"+ORnum.Peek()+"', " +
                    //"(SELECT customerID FROM tblcustomer WHERE customerID = (SELECT MAX(customerID) FROM tblcustomer WHERE Name = '"+name+"')), " +
                    "(SELECT customerID FROM tblcustomer WHERE (customerID = (SELECT MAX(customerID) AS Expr1 FROM tblcustomer tblcustomer_1 WHERE (Name = '"+name+"')))) ," +
                    " '"+newDate+"','"+ SelSchedTime + "','"+newScreen+"')";
                
                db.conn.Open();

                MySqlCommand command3 = new MySqlCommand(query3,db.conn);
                if(command3.ExecuteNonQuery()==1)
                {
                    //MessageBox.Show("Booked Seat!");
                }
                else
                {
                    MessageBox.Show("Failed to Book Seat");
                }
                command3.Dispose();
                db.conn.Close();

                bool swith = true;
                for (int i=0,j=0; i<seatNo.Count ;i++) {
                    String query4 = "INSERT INTO bookingdb.tblseatno(SeatNoID,SeatNo,Date,Status) " +
                    "VALUES((SELECT MAX(SeatNoID) AS Expr1 FROM tblbookedseats) , '" + seatNo[i]+"' , '"+newDate+"', 'occupied' )";

                    db.conn.Open();

                    command3 = new MySqlCommand(query4, db.conn);
                    if (command3.ExecuteNonQuery() == j)
                    {
                        MessageBox.Show("Booked Seat!");
                        swith = false;
                        j++;
                    }
                    else
                    {
                        if (swith==true) {
                            MessageBox.Show("Failed to Book Seat");
                        } 
                    }
                    command3.Dispose();
                    db.conn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
