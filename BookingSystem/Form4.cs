using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public void GetNameMovie(String id)
        {
            try
            {
                Database db = new Database();
                String query = "SELECT movieinfo.Title, movieinfo.imgPath ,moviesched.SchedPosition " +
                    "FROM movieinfo LEFT JOIN moviesched ON movieinfo.movieID = moviesched.movieID " +
                    "WHERE movieinfo.movieID = '" + id + "'";
                db.conn.Open();
                MySqlCommand command = new MySqlCommand(query, db.conn);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    lblMovieTitle.Text = reader[0].ToString();
                    picBoxMovie.BackgroundImageLayout = ImageLayout.Stretch;
                    picBoxMovie.Image = Image.FromFile(reader[1].ToString());
                    SplitPos(reader[2].ToString().Trim());
                }
                reader.Close();
                command.Dispose();
                db.conn.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        int start = 0, end = 0;
        public void SplitPos(String split)
        {
            //Sunday    = 1,8,15,22,29
            //Monday    = 2,9,16,23,30
            //Tuesday   = 3,10,17,24,31
            //Wednesday =4,11,18,25,32
            //Thursday  =5,12,19,26,33
            //Friday    =6,13,20,27,34
            //Saturday  =7,14,21,28,35

            start = 0; end = 0;
            if (lblTime.Text == "7:00 AM to 10:00 AM") {
                start = 1;
                end = 7;
            } else if (lblTime.Text == "10:00 AM to 1:00 PM") {
                start = 8;
                end = 14;
            } else if (lblTime.Text == "1:00 PM to 4:00 PM") {
                start = 15;
                end = 21;
            } else if (lblTime.Text == "4:00 PM to 7:00 PM") {
                start = 22;
                end = 28;
            } else if (lblTime.Text == "7:00 PM to 10:00 PM") {
                start = 29;
                end = 35;
            }

            //kukunin ang day
            //

            var checkDay = new Action[] { checkSaturday, checkMonday,checkTuesday, checkWednesday,
                                            checkThursday, checkFriday, checkSunday};

            String[] arrpos = split.Split(',');
            for (int i = 0; i < arrpos.Length; i++)
            {
                for (int j = start; j <= end; j++) {
                    if (arrpos[i].Contains(j.ToString()) == true)
                    {
                        
                        int test = end - j;
                        //Thread t = new Thread(new ThreadStart(checkDay[test]));
                        //t.Start();
                        checkDay[test].Invoke();
                    }
                }
            }
            
            //DisableCheckbox2(arrpos);

        }

        void checkSaturday() { cbSaturday.Checked = true; }
        void checkMonday() { cbFriday.Checked = true; }
        void checkTuesday() { cbThursday.Checked = true; }
        void checkWednesday() { cbWednesday.Checked = true; }
        void checkThursday() { cbTuesday.Checked = true; }
        void checkFriday() { cbMonday.Checked = true; }
        void checkSunday() { cbSunday.Checked = true; }

        public void GetIDSched()
        {
            try
            {
                Database db = new Database();
                String query = "SELECT schedID FROM bookingdb.moviesched " +
                    "WHERE Date ='" + WeekDate + "' AND Time = '" + lblTime.Text + "' " +
                    "AND Screen = '" + lblScreen.Text + "' AND isDeleted = 'false' ";
                db.conn.Open();
                MySqlCommand command = new MySqlCommand(query, db.conn);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    schedId = reader[0].ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        String WeekDate = "", schedId = "", Day = "",pos="";
        public void FetchInfo(String id, String screen, String date, String time, String pos)
        {
            MessageBox.Show(id);
            pos = " "+pos+",";
            lblScreen.Text = screen;
            lblTime.Text = time;
            WeekDate = date;
            GetNameMovie(id);
            GetIDSched();
            DisableCheckBox();
        }
        //      ///         ///     ///             ///
        public void GetPos()
        {
            //7,14,21,28,35
            Day = "";
            var CheckCB = new bool[] { cbSunday.Checked, cbMonday.Checked, cbTuesday.Checked,
                cbWednesday.Checked, cbThursday.Checked, cbFriday.Checked, cbSaturday.Checked };

            if (lblTime.Text == "7:00 AM to 10:00 AM") {
                for (int i = 0; i < 7; i++) {
                    if (CheckCB[i] == true) {
                        Day += " " + (i + 1) + ",";
                    }
                }
            }
            else if (lblTime.Text == "10:00 AM to 1:00 PM") {
                for (int i = 0; i < 7; i++) {
                    if (CheckCB[i] == true) {
                        Day += " " + (i + 8) + ",";
                    }
                }
            }
            else if (lblTime.Text == "1:00 PM to 4:00 PM") {
                for (int i = 0; i < 7; i++) {
                    if (CheckCB[i] == true) {
                        Day += " " + (i + 15) + ",";
                    }
                }
            }
            else if (lblTime.Text == "4:00 PM to 7:00 PM") {
                for (int i = 0; i < 7; i++) {
                    if (CheckCB[i] == true) {
                        Day += " " + (i + 22) + ",";
                    }
                }
            }
            else if (lblTime.Text == "7:00 PM to 10:00 PM") {
                for (int i = 0; i < 7; i++) {
                    if (CheckCB[i] == true) {
                        Day += " " + (i + 29) + ",";
                    }
                }
            }

        }

        public void DisableCheckBox()
        {
            DateTime dt = DateTime.Now.StartOfWeek(DayOfWeek.Sunday);
            DateTime dt2 = dt.AddDays(7).AddSeconds(-1);
            String week = dt.ToString("MMM dd,yyyy") + " --to-- " + dt2.ToString("MMM dd,yyyy");
            if (WeekDate == week)
            {
                var cbDisable = new Action[] { disSun, disMon, disTue, disWed, disThu, disFri, disSat };
                String[] strDay = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                String dayToday = DateTime.Now.DayOfWeek.ToString();
                for (int i = 0; i < 7; i++)
                {
                    if (strDay[i] == dayToday)
                    {
                        for (int j = (i - 1); j >= 0; j--)
                        {
                            cbDisable[j].Invoke();
                        }
                    }
                }
            }

            void disSun() { cbSunday.Enabled = false;
            } void disMon() { cbMonday.Enabled = false;
            } void disTue() { cbTuesday.Enabled = false;
            } void disWed() { cbWednesday.Enabled = false;
            } void disThu() { cbThursday.Enabled = false;
            } void disFri() { cbFriday.Enabled = false;
            } void disSat() { cbSaturday.Enabled = false;
            }
        }

        public void DisableCheckbox2()
        {
            try
            {
                Database db = new Database();
                db.conn.Open();

                //for (int i = start; i < end; i++)
                //{
                String query = "SELECT SchedPosition FROM moviesched WHERE Date ='" + WeekDate + "' " +
                    "AND Screen = '" + lblScreen.Text + "' AND Time = '" + lblTime.Text + "' " +
                    "AND schedID != '" + schedId + "' ";

                MySqlCommand command = new MySqlCommand(query, db.conn);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    listBox1.Items.Add(reader[0].ToString());
                }
                //}
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            } 
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void UpdateSched()
        {
            try
            {
                Database db = new Database();
                String query = "UPDATE bookingdb.moviesched " +
                    "SET SchedPosition = '"+Day+"' " +
                    "WHERE schedID = '"+ schedId + "'";
                db.conn.Open();

                MySqlCommand command3 = new MySqlCommand(query, db.conn);
                if (command3.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Update Schedule!");
                }
                else
                {
                    MessageBox.Show("Failed to Update Schedule");
                }
                command3.Dispose();
                db.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GetPos();
            UpdateSched();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            DisableCheckbox2();
            listBox1.Items.Add("asd");
        }
        
        private void btnPullout_Click(object sender, EventArgs e)
        {
            

        }

    }
}
