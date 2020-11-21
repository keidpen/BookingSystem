using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BookingSystem
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            test();
            test2("");
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }



        public void test2(String date)
        {
            try
            {
                listView1.Clear();
                monthCalendar1.RemoveAllBoldedDates();

                DateTime dFirstDayOfThisMonth = DateTime.Today.AddDays(-(DateTime.Today.Day - 1));
                DateTime dt2 = dFirstDayOfThisMonth.AddMonths(+2).AddMinutes(-1);
                
                bool SwitchOn = true;
                String query1 = "";
                if (date == "" || date == null || date == dFirstDayOfThisMonth.ToString("yyyy-MM") || date == dt2.ToString("yyyy-MM"))
                {
                    query1 = "SELECT DATE_FORMAT(Date,'%Y-%m-%d') FROM tblsocialdistancing WHERE sdmode ='true' AND Date BETWEEN '" + dFirstDayOfThisMonth.ToString("yyyy-MM-dd") + "' AND'" + dt2.ToString("yyyy-MM-dd") + "'  ORDER BY tblsocialdistancing.Date ";
                }
                else
                {
                    String[] Arrdate = date.Split('-');
                    query1 = "SELECT DATE_FORMAT(Date,'%Y-%m-%d') FROM tblsocialdistancing WHERE sdmode ='true' AND  YEAR(Date) = '" + Arrdate[0].ToString() + "' ORDER BY Date ASC";
                    SwitchOn = false;
                }

                int x = 0, intMonthRef = 0, y = 0;
                

                Database db = new Database();
                db.conn.Open();

                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                MySqlDataReader reader = command1.ExecuteReader();

                ArrayList AL = new ArrayList();

                listView1.View = View.Tile;
                List<ListViewGroup> month = new List<ListViewGroup>();
                bool turnOff = true;
                flowLayoutPanel1.Controls.Clear();
                while (reader.Read())
                {
                    Label l = new Label();
                    String dext = reader[0].ToString();
                    String[] split = dext.Split('-');
                    DateTime myVacation1 = new DateTime(int.Parse(split[0].ToString()), int.Parse(split[1].ToString()), int.Parse(split[2].ToString()));
                    monthCalendar1.AddBoldedDate(myVacation1);

                    String[] whichMonth = { "This Month", "Next Month", "Future Date" };
                    String[] ArrMonth = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                    int IntMonth = 0;
                    String strMonth = "";

                    for (int i = 1; i <= ArrMonth.Length; i++)
                    {
                        if (int.Parse(split[1].ToString()) == i)
                        {
                            
                            IntMonth = i;
                            strMonth = ArrMonth[i].ToString();
                            if (turnOff == true)
                            {
                                intMonthRef = IntMonth;
                                turnOff = false;
                            }
                            break;
                        }
                    }
                    if (SwitchOn == true)
                    {
                        //if (IntMonth != intMonthRef)
                        //{
                        //    listView1.Groups.Add(month[x]);
                        //    //month.Clear();
                        //    month = new List<ListViewGroup>();
                        //    x = 0;

                        //    turnOff = true;
                        //    if (intMonthRef > IntMonth)
                        //    {
                        //        break;
                        //    }
                        //    intMonthRef = IntMonth;

                        //}


                        //month.Add(new ListViewGroup(ArrMonth[IntMonth].ToString() + " " + split[0].ToString(), HorizontalAlignment.Left));
                        //listView1.Items.Add(new ListViewItem(reader[0].ToString(), month[x]));
                        DateTime dt3 = DateTime.Parse(reader[0].ToString());


                        if (IntMonth != intMonthRef)
                        {
                            listView1.Groups.Add(month[x]);
                            x = 0;
                            y++;
                            intMonthRef = IntMonth;
                            month.Clear();
                        }
                        if (dt3.ToString("yyyy-MM") != currentDate.ToString("yyyy-MM"))
                        {
                            y = 1;
                        }
                        month.Add(new ListViewGroup(ArrMonth[IntMonth].ToString() + " " + split[0].ToString() + "( " + whichMonth[y].ToString() + ")", HorizontalAlignment.Left));

                    }
                    else
                    {
                        if (IntMonth != intMonthRef)
                        {
                            listView1.Groups.Add(month[x]);
                            x = 0;
                            intMonthRef = IntMonth;
                            month.Clear();
                        }

                        month.Add(new ListViewGroup(ArrMonth[IntMonth].ToString() + " " + split[0].ToString() + "( " + whichMonth[2].ToString() + ")", HorizontalAlignment.Left));
                    }
                    listView1.Items.Add(new ListViewItem(reader[0].ToString(), month[x]));


                }
                foreach (ListViewGroup list in month)
                {
                    listView1.Groups.Add(list);
                }

                db.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void test4()
        {
            try
            {
                String selectionDate = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
                Database db = new Database();
                String query1 = "SELECT COUNT(Date) FROM bookingdb.tblsocialdistancing WHERE sdmode ='true' AND Date = '" + selectionDate + "' ";
                db.conn.Open();

                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(command1);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Exist");

                }
                else
                {
                    test3(selectionDate);
                }

                db.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }



        public void test3(String date)
        {
            try
            {
                Database db = new Database();
                String query1 = "INSERT INTO bookingdb.tblsocialdistancing(sdmode,Date) VALUES('true','" + date + "')";
                db.conn.Open();

                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                if (command1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Success");
                    DateTime d = monthCalendar1.SelectionRange.Start;
                    String date2 = d.Year.ToString() + "-" + d.Month.ToString();
                    test2(date2);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        public void test5(String date)
        {
            try
            {
                Database db = new Database();
                String query1 = "UPDATE bookingdb.tblsocialdistancing(sdmode,Date) VALUES('true','" + date + "')";
                db.conn.Open();

                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                if (command1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Success");
                    test2("");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void test()
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

                Database db = new Database();
                String query1 = "SELECT * FROM bookedseats";

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
                    // AL.Add(reader[6].ToString());
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

        DateTime currentDate = DateTime.Now;
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime d = monthCalendar1.SelectionRange.Start;
            if (currentDate.Date <= d.Date)
            {
                test4();
            }
            else
            {
                MessageBox.Show("Cant add or removed ");
            }
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime d = monthCalendar1.SelectionRange.Start;
            String date = d.Year.ToString() + "-" + d.Month.ToString();
            if (currentDate.Date < d.Date){
                test2(date);
            }
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Databindings();   
        }

        public void Databindings()
        {
            Database db = new Database();
            db.conn.Open();
            String query = "SELECT * FROM tblcustomer";

            String query1 = "SELECT tblcustomer.Name, bs.SeatNo,bs.Date,bs.Time,bs.Screen, tblcustomer.ContactNo, tblcustomer.Email " +
                "FROM bookingdb.bookedseats bs " +
                "JOIN tblcustomer " +
                "ON tblcustomer.customerID = bs.customerID " +
                "ORDER BY bs.ID DESC ";

            MySqlCommand cmd = new MySqlCommand(query, db.conn);
            MySqlDataAdapter adt = new MySqlDataAdapter(cmd);
            DataSet set = new DataSet();
            adt.Fill(set);

            DataTable tb = new DataTable();
            adt.Fill(tb);

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = tb;

            CrystalReport2 rpt = new CrystalReport2();
            rpt.SetDataSource(tb);

            frmData form = new frmData();
            form.crystalReportViewer1.ReportSource = rpt;
            form.ShowDialog();
        }

    }
}
