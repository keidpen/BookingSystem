using LiveCharts;
using LiveCharts.Wpf;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            LoadChart();
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
                String query1 = "SELECT tblcustomer.Name, bs.SeatNo,bs.Date,bs.Time,bs.Screen, tblcustomer.ContactNo, tblcustomer.Email " +
                                "FROM bookingdb.tblbookedseats bs " +
                                "JOIN tblcustomer " +
                                "ON tblcustomer.customerID = bs.customerID " +
                                //          "WHERE Date = '" + dt.ToString("yyyy-MM-dd") + "'" +
                                "ORDER BY bs.ID DESC ";

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
            if (currentDate.Date < d.Date)
            {
                test2(date);
            }

        }

        //// Start of C0ntact Tracing /////

        private void button3_Click(object sender, EventArgs e)
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
        ////  End   Contact Tracing //////
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //dataGridView1.DataSource = null;
                //dataGridView1.Rows.Clear();

                //dataGridView2.ColumnCount = 4;

                //dataGridView1.Columns[0].Name = "Date";
                //dataGridView1.Columns[1].Name = "Year";
                //dataGridView1.Columns[2].Name = "Month";
                //dataGridView1.Columns[3].Name = "Day";

                //DateTime dt = DateTime.Today;
                Database db = new Database();
// RollUp dapat
                String query1 = "SELECT Date , YEAR(Date) ,MONTH(Date) ,DAY(Date) FROM bookingdb.tblbookedseats";

                db.conn.Open();
                ArrayList AL = new ArrayList();

                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(command1);
                
                DataTable tb = new DataTable();
                da.Fill(tb);

                DataTable dtCloned = tb.Clone();
                dtCloned.Columns[0].DataType = typeof(string);
                dtCloned.Columns[1].DataType = typeof(Int32);
                dtCloned.Columns[2].DataType = typeof(Int32);
                dtCloned.Columns[3].DataType = typeof(Int32);


                foreach (DataRow row in tb.Rows)
                {
                    dtCloned.ImportRow(row);
                }
                dtCloned.Columns[1].ColumnName = "Year";
                dtCloned.Columns[2].ColumnName = "Month";
                dtCloned.Columns[3].ColumnName = "Day";

                MessageBox.Show(list.Count.ToString());
                for (int i = 1; i < dtCloned.Rows.Count; i++)
                {
                    lvSalesReport sales = new lvSalesReport();
                    sales.Date = dtCloned.Rows[i][0].ToString();
                    sales.Year = int.Parse(dtCloned.Rows[i][1].ToString());
                    sales.Month = int.Parse(dtCloned.Rows[i][2].ToString());
                    sales.Day = int.Parse(dtCloned.Rows[i][3].ToString());
                    list.Add(sales);
                }
                MessageBox.Show(list.Count.ToString());
                //list = (from DataRow dr in dtCloned.Rows
                //               select new lvSalesReport()
                //               {
                //                   Date = dr["Date"].ToString(),
                //                   Year = Convert.ToInt32(dr["Year"]),
                //                   Month = Convert.ToInt32(dr["Month"]),
                //                   Day = Convert.ToInt32(dr["Day"])
                //               }).ToList();

                

                //MySqlDataReader reader = command1.ExecuteReader();
                //while (reader.Read())
                //{
                //    AL = new ArrayList();
                //    AL.Add(reader[0].ToString());
                //    AL.Add(int.Parse(reader[1].ToString()));
                //    AL.Add(int.Parse(reader[2].ToString()));
                //    AL.Add(int.Parse(reader[3].ToString()));
                //    dataGridView2.Rows.Add(AL.ToArray());

                //}
                //reader.Close();
                command1.Dispose();

                //dataGridView2.AutoResizeColumns();
                //dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                db.conn.Close();


                if (dataGridView2.Rows.Count == 0 || dataGridView2.Rows == null)
                {
                    MessageBox.Show("No Result Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        ///         Sales Report        ///
        /// 

        List<lvSalesReport> list = new List<lvSalesReport>();
        public void LoadChart()
        {
            lvSalesReportBindingSource.DataSource = list;
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",
                Labels = new[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" }
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Year",
                LabelFormatter = value => value.ToString("C")
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            dt.Columns.Add("Date");
            dt.Columns.Add("Year", typeof(string));
            dt.Columns.Add("Month", typeof(string));
            dt.Columns.Add("Day", typeof(string));

            foreach (DataGridViewRow dgv in dataGridView2.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value);
            }

            ds.Tables.Add(dt);

            

            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            var years = (from o in lvSalesReportBindingSource.DataSource as List<lvSalesReport>
                         select new { Year = o.Year }).Distinct();
            foreach(var year in years){
                List<int> values = new List<int>();
                for (int month =1; month<=12; month++)
                {
                    int value = 0;
                    var data = from o in lvSalesReportBindingSource.DataSource as List<lvSalesReport>
                               where o.Year.Equals(year.Year) && o.Month.Equals(month)
                               orderby o.Month ascending
                               select new {o.Day ,o.Month };
                    if (data.SingleOrDefault()!=null)
                    {
                        value = data.SingleOrDefault().Day;
                        values.Add(value);
                    }
                    series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<int>(values) });
                }
                cartesianChart1.Series = series; 
            }


        }

    }
}
