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
            test2();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }



        public void test2()
        {
            try
            {
                monthCalendar1.RemoveAllBoldedDates();
                listView1.Items.Clear();
                Database db = new Database();
                DateTime dFirstDayOfThisMonth = DateTime.Today.AddDays(-(DateTime.Today.Day - 1));
                DateTime dt2 = dFirstDayOfThisMonth.AddMonths(-1);
                String query1 = "SELECT DATE_FORMAT(Date,'%Y-%m-%d') FROM tblsocialdistancing WHERE sdmode ='true' AND Date > '" + dt2.ToString("yyyy-MM-dd") + "'  ORDER BY tblsocialdistancing.Date ";
                db.conn.Open();
                ArrayList AL = new ArrayList();

                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                MySqlDataReader reader = command1.ExecuteReader();
                listView1.View = View.Tile;
                //ListViewGroup month;
                List<ListViewGroup> month = new List<ListViewGroup>();
                int x = 0, intMonthRef = 0, y = 0;
                bool turnOff = true, turnOff2 = true;
                flowLayoutPanel1.Controls.Clear();
                while (reader.Read())
                {
                    Label l = new Label();
                    String dext = reader[0].ToString();
                    String[] split = dext.Split('-');
                    DateTime myVacation1 = new DateTime(int.Parse(split[0].ToString()), int.Parse(split[1].ToString()), int.Parse(split[2].ToString()));
                    monthCalendar1.AddBoldedDate(myVacation1);
                    //                    monthCalendar1.ShowTodayCircle = true;
                    //monthCalendar1.BackColor = Color.Red;
                    //monthCalendar1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(192)));
                    //monthCalendar1.TitleBackColor = System.Drawing.Color.Purple;
                    //monthCalendar1.TitleForeColor = System.Drawing.Color.Yellow; 
                    monthCalendar1.Refresh();

                    String[] ArrMonth = { "", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                    int IntMonth = 0;
                    String strMonth = "";
                    for (int i = 1; i <= ArrMonth.Length; i++)
                    {
                        if (split[1].ToString() == i.ToString())
                        {
                            IntMonth = i;
                            strMonth = ArrMonth[i].ToString();
                            if (turnOff == true)
                            {
                                intMonthRef = IntMonth;
                                turnOff = false;
                                y = 1;
                            }
                            break;
                        }
                    }
                    if (IntMonth != intMonthRef)
                    {
                        listView1.Groups.Add(month[x]);
                        //month.Clear();
                        month = new List<ListViewGroup>();
                        x = 0;

                        turnOff = true;
                        if (intMonthRef > IntMonth)
                        {
                            break;
                        }
                        intMonthRef = IntMonth;

                    }


                    month.Add(new ListViewGroup(ArrMonth[IntMonth].ToString() + " " + split[0].ToString(), HorizontalAlignment.Left));
                    listView1.Items.Add(new ListViewItem(reader[0].ToString(), month[x]));

                    //if (IntMonth != intMonthRef)
                    //{
                    //    listView1.Groups.Add(month[x]);
                    //    x = 0;
                    //    intMonthRef = IntMonth;
                    //    month.Clear();
                    //}

                    if (intMonthRef != IntMonth || y == 1)
                    {
                        Label lbl2 = new Label();
                        lbl2.Text = strMonth + "----------";
                        lbl2.Visible = true;
                        flowLayoutPanel1.Controls.Add(lbl2);
                        y++;
                    }
                    Label lbl = new Label();
                    lbl.Text = reader[0].ToString();
                    lbl.Visible = true;
                    flowLayoutPanel1.Controls.Add(lbl);

                }
                //foreach (ListViewGroup list in month){
                //    listView1.Groups.Add(list);
                // }


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
                    test2();
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
                    test2();
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


        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show("Helo " + monthCalendar1.SelectionStart.ToString("yyyy-MM-dd"));
            test4();
            monthCalendar1_DateChanged(sender, e);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.Refresh();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
