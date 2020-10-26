using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                    "WHERE movieinfo.movieID = '"+id+"'";
                db.conn.Open();
                MySqlCommand command = new MySqlCommand(query, db.conn);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    lblMovieTitle.Text=reader[0].ToString();
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


        public void SplitPos(String split)
        {
            //Sunday    = 1,8,15,22,29
            //Monday    = 2,9,16,23,30
            //Tuesday   = 3,10,17,24,31
            //Wednesday =4,11,18,25,32
            //Thursday  =5,12,19,26,33
            //Friday    =6,13,20,27,34
            //Saturday  =7,14,21,28,35

            int start=0, end = 0;
            if (lblTime.Text == "7:00 AM to 10:00 AM")
            {
                start = 1;
                end = 7;
                MessageBox.Show("Uma");
            }
            else if (lblTime.Text == "11:00 AM to 1:00 PM")
            {
                start = 8;
                end = 14;
                MessageBox.Show("Uma2");
            }
            else if (lblTime.Text == "1:00 PM to 4:00 PM")
            {
                start = 15;
                end = 28;
                MessageBox.Show("Uma3");
            }
            else if (lblTime.Text == "4:00 PM to 7:00 PM")
            {
                start = 22;
                end = 28;
                MessageBox.Show("Uma4");
            }
            else if (lblTime.Text == "7:00 PM to 10:00 PM")
            {
                start = 29;
                end = 35;
                MessageBox.Show("Uma5");
            }

            //kukunin ang day
            //

            var checkDay = new Action[] { checkSunday, checkMonday,checkTuesday, checkWednesday, 
                                            checkThursday, checkFriday, checkSaturday};

            String ss = "";
            String[] arrpos = split.Split(',');
            for (int i=0; i<arrpos.Length ;i++)
            {
                for(int j =start;j<=end ;j++){
                    if (arrpos[i].Contains(j.ToString()) == true)
                    {
                        ss += arrpos[i].ToString() + "MErron\n";
                        int test = end - j;
                        Thread t = new Thread(new ThreadStart(checkDay[test]));
                        t.Start();
                    } 
                }
            }

            MessageBox.Show(ss);
        }

        void checkSunday()
        {
            checkBox1.Checked = true;
        }
        void checkMonday()
        {
            checkBox2.Checked = true;
        }
        void checkTuesday()
        {
            checkBox3.Checked = true;
        }
        void checkWednesday()
        {
            checkBox4.Checked = true;
        }
        void checkThursday()
        {
            checkBox5.Checked = true;
        }
        void checkFriday()
        {
            checkBox6.Checked = true;
        }
        void checkSaturday()
        {
            checkBox7.Checked = true;
        }


        public void FetchInfo(String id,String screen, String date, String time)
        {
            lblScreen.Text = screen;
            lblTime.Text = time;
            GetNameMovie(id);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
