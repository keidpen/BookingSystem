using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem
{
    public partial class frmSchedule : Form
    {
        public frmSchedule()
        {
            InitializeComponent();
            getStartAndEndDate();
            cbSetScreen.SelectedIndex = 0;
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {

        }
        String WholeWeek = "";
        List<int> listofPos = new List<int>();
        Refresh r = new Refresh();

        private void cbSetScreen_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlSched.Controls.Clear();
            btnSchedArray();
        }

        private void cbSetDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlSched.Controls.Clear();
            btnSchedArray();
        }

        public void getStartAndEndDate()
        {
            cbSetDate.Items.Clear();

            DateTime dt = DateTime.Now.StartOfWeek(DayOfWeek.Sunday);
            DateTime dt2 = dt.AddDays(7).AddSeconds(-1);
            WholeWeek = dt.ToString("MMM dd,yyyy") + " --to-- " + dt2.ToString("MMM dd,yyyy");
            cbSetDate.Items.Add(dt.ToString("MMM dd,yyyy") + " --to-- " + dt2.ToString("MMM dd,yyyy"));
            cbSetDate.SelectedIndex = 0;

            int addDays = 8;
            for (int i = 0; i <= 12; i++)
            {
                DateTime dt3 = dt.AddDays(addDays).AddSeconds(-1);
                DateTime dt4 = dt3.AddDays(6).AddSeconds(-1);
                addDays += 7;
                cbSetDate.Items.Add(dt3.ToString("MMM dd,yyyy") + " --to-- " + dt4.ToString("MMM dd,yyyy")); ;
            }

            int[,] Arrday = new int[7, 5] {
                { 1, 8, 15, 22, 29},   { 2, 9, 16, 23, 30}, { 3, 10, 17, 24, 31 },
                { 4, 11, 18, 25, 32 }, { 5, 12, 19, 26, 33 }, { 6, 13, 20, 27, 34 },
                { 7, 14, 21, 28, 35 }};
            //dito disable
            String dayToday = DateTime.Now.DayOfWeek.ToString();
            string[] day = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            for (int i = 0; i < day.Length; i++)
            {
                if (dayToday == day[i].ToString())
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            listofPos.Add(Arrday[j, k]);
                        }
                    }
                }
            }

        }

        String SetbtnImg = "", strSetMovieName = "", newMovieInfoID = "";
        public void GetNameAndImgMovie(String pos)
        {
            Database db = new Database();
            String query2 = "SELECT movieID,Title, imgPath FROM movieinfo WHERE movieID = " +
                "ANY (SELECT movieID FROM moviesched WHERE Screen='" + cbSetScreen.Text + "' " +
                "AND Date = '" + cbSetDate.Text + "' AND SchedPosition LIKE '% " + pos + ",%' AND isDeleted = 'false')";

            db.conn.Open();
            MySqlCommand command = new MySqlCommand(query2, db.conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            db.conn.Close();

            newMovieInfoID = table.Rows[0][0].ToString();
            strSetMovieName = table.Rows[0][1].ToString();
            if (File.Exists(table.Rows[0][2].ToString()))
            {
                SetbtnImg = table.Rows[0][2].ToString();
            }
            else
            {
                SetbtnImg = "noimg.png";
            }


        }

        public void btnSchedArray()
        {
            Database db = new Database();
            int Xsched = 10, Ysched = 35, Zsched = 7;
            int Xday = 40;
            string[] day = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            // DateTime dat = DateTime.Now.StartOfWeek(DayOfWeek.Sunday);
            int x = cbSetDate.SelectedIndex;
            int y = 0;

            for (int i = 0; i < x; i++)
            {
                y += 7;
            }
            DateTime dat = DateTime.Now.AddDays(y).StartOfWeek(DayOfWeek.Sunday);
            for (int i = 0; i < 7; i++)
            {
                DateTime dt2 = dat.AddDays(i);
                Label lblday = new Label();
                lblday.Text = dt2.ToString("dd") + " ," + day[i].ToString();
                lblday.Font = new Font("Arial", 12, FontStyle.Bold);
                lblday.TextAlign = ContentAlignment.MiddleCenter;
                lblday.Location = new Point(Xday, 10);
                lblday.BackColor = Color.Transparent;
                lblday.AutoSize = true;
                
                pnlSched.Controls.Add(lblday);
                Xday += 164;
            }

            db.conn.Open();
            for (int i = 1; i <= 35; i++)
            {
                Button btnSched = new Button();
                btnSched.Location = new System.Drawing.Point(Xsched, Ysched);
                btnSched.Font = new Font("Arial", 12, FontStyle.Bold);
                btnSched.Size = new Size(162, 92);
                btnSched.Tag = i.ToString();


                if (WholeWeek == cbSetDate.SelectedItem.ToString())
                {
                    if (listofPos.Contains(i))
                    {
                        btnSched.Enabled = false;
                    }
                }

                try
                {
                    String query = "SELECT COUNT(*) FROM bookingdb.moviesched " +
                        "WHERE Date ='" + cbSetDate.SelectedItem.ToString() + "' " +
                        "AND Screen = '" + cbSetScreen.Text.ToString() + "' " +
                        "AND isDeleted = 'false' AND (movieID !=0 OR movieID !=null)" +
                        "AND SchedPosition LIKE '% " + i + ",%'";

                    MySqlDataAdapter sda = new MySqlDataAdapter(query, db.conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        String pos = btnSched.Tag.ToString();
                        GetNameAndImgMovie(pos);
                        btnSched.Text = strSetMovieName;
                        btnSched.Image = new Bitmap(Image.FromFile(SetbtnImg), new Size(217, 151));
                        btnSched.ForeColor = Color.White;
                    }
                    else
                    {
                        btnSched.Text = "No Movie";
                        btnSched.ForeColor = Color.Black;
                        btnSched.BackColor = Color.White;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }


                btnSched.Click += btnSched_Click;
                pnlSched.Controls.Add(btnSched);
                db.conn.Close();
                ///position
                if (i == Zsched)
                {
                    Xsched = 10;
                    Ysched += 92;
                    Zsched += 7;
                }
                else
                {
                    Xsched += 163;
                }
            }

        }

        public void btnSched_Click(object sender, EventArgs e)
        {
            Button btnSched = (Button)sender;


            //Sunday    = 1,8,15,22,29
            //Monday    = 2,9,16,23,30
            //Tuesday   = 3,10,17,24,31
            //Wednesday = 4,11,18,25,32
            //Thursday  = 5,12,19,26,33
            //Friday    = 6,13,20,27,34
            //Saturday  = 7,14,21,28,35
            String time = "";
            int pos = Convert.ToInt32(btnSched.Tag);
            if (pos >= 1 && pos <= 7)
            {
                time = "7:00 AM to 10:00 AM";
            }
            else if (pos >= 8 && pos <= 14)
            {
                time = "10:00 AM to 1:00 PM";
            }
            else if (pos >= 15 && pos <= 21)
            {
                time = "1:00 PM to 4:00 PM";
            }
            else if (pos >= 22 && pos <= 28)
            {
                time = "4:00 PM to 7:00 PM";
            }
            else if (pos >= 29 && pos <= 35)
            {
                time = "7:00 PM to 10:00 PM";
            }

            Form4 form = new Form4();
            if (pos >= 1 && btnSched.Text != "No Movie")
            {
                GetNameAndImgMovie(pos.ToString());

                form.FetchInfo(newMovieInfoID, cbSetScreen.Text, cbSetDate.Text, time, btnSched.Tag.ToString());
                form.ShowDialog(this);
            }
            else if (btnSched.Text == "No Movie")
            {
                form.Run(cbSetScreen.Text, cbSetDate.Text, time, btnSched.Tag.ToString());
                form.ShowDialog(this);
            }

            RefreshPanel(sender, e);
        }

        private void RefreshPanel(object sender, EventArgs e)
        {
                pnlSched.Controls.Clear();
                btnSchedArray();
         }
    }
}
