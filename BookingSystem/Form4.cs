using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Authentication;
using System;
using System.Collections;
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
                    "WHERE movieinfo.movieID = '" + id +"' AND moviesched.Date ='"+WeekDate+"' AND moviesched.Time ='"+lblTime.Text+"' " +
                    "AND moviesched.Screen = '"+lblScreen.Text+"' AND moviesched.isDeleted = 'false' ";
                db.conn.Open();
                MySqlCommand command = new MySqlCommand(query, db.conn);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    //lblMovieTitle.Text = reader[0].ToString();
                    cbTitle.Text = reader[0].ToString();
                    picBoxMovie.Image = Image.FromFile(reader[1].ToString());
                    picBoxMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                   // System.Drawing.Image img = System.Drawing.Image.FromFile(reader[1].ToString());
                  //  picBoxMovie.Image = new Bitmap(Image.FromFile(reader[1].ToString()), new Size(img.Height, img.Width));
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

        public void GetTime()
        {
            start = 0; end = 0;
            if (lblTime.Text == "7:00 AM to 10:00 AM"){
                start = 1;
                end = 7;
            }else if (lblTime.Text == "10:00 AM to 1:00 PM"){
                start = 8;
                end = 14;
            }else if (lblTime.Text == "1:00 PM to 4:00 PM"){
                start = 15;
                end = 21;
            }else if (lblTime.Text == "4:00 PM to 7:00 PM"){
                start = 22;
                end = 28;
            }else if (lblTime.Text == "7:00 PM to 10:00 PM"){
                start = 29;
                end = 35;
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
            
            GetTime();

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
            try{
                Database db = new Database();
                String query = "SELECT schedID FROM bookingdb.moviesched " +
                    "WHERE Date ='" + WeekDate + "' AND Time = '" + lblTime.Text + "' " +
                    "AND Screen = '" + lblScreen.Text + "' AND isDeleted = 'false' AND SchedPosition LIKE '%"+pos+"%' ";
                db.conn.Open();
                MySqlCommand command = new MySqlCommand(query, db.conn);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    schedId = reader[0].ToString();
                }
            }
            catch (Exception err){
                MessageBox.Show(err.Message);
            }
        }
        String WeekDate = "", schedId = "", Day = "",pos="";
        public void FetchInfo(String id, String screen, String date, String time, String pos){
            this.pos = " "+pos+",";
            lblScreen.Text = screen;
            lblTime.Text = time;
            WeekDate = date;
            GetNameMovie(id);
            GetIDSched();
            RetrieveMovie();
            DisableCheckBox();
            DisableCheckbox2();
           // cbTitle.Visible = false;
            btnSet.Enabled = false;

            cbSunday.Visible = false;
            cbMonday.Visible = false;
            cbTuesday.Visible = false;
            cbWednesday.Visible = false;
            cbThursday.Visible = false;
            cbFriday.Visible = false;
            cbSaturday.Visible = false;
        }
        

        public void Run(String screen, String date, String time,String pos)
        {
            lblScreen.Text = screen;
            lblTime.Text = time;
            WeekDate = date;
            this.pos = " "+pos+",";
            GetTime();
            DisableCheckBox();
            DisableCheckbox2();
            RetrieveMovie();
            btnUpdate.Enabled = false;
            btnPullout.Enabled = false;
            btnDelete.Enabled = false;
        }
        //      ///         ///     ///             ///


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
            try{
                Database db = new Database();
                db.conn.Open();

                String query = "SELECT SchedPosition FROM moviesched WHERE Date ='" + WeekDate + "' " +
                    "AND Screen = '" + lblScreen.Text + "' AND Time = '" + lblTime.Text + "' " +
                    "AND schedID != '" + schedId + "' AND isDeleted='false' AND SchedPosition NOT LIKE '"+pos+"'";

                MySqlCommand command = new MySqlCommand(query, db.conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read()){

                    var cbDisable = new Action[] { disSat, disFri, disThu, disWed, disTue, disMon, disSun };
                    String[] arrpos = reader[0].ToString().Trim().Split(',');
                    for (int i = 0; i < arrpos.Length; i++)
                    {
                        for (int j = start; j <= end; j++)
                        {
                            if (arrpos[i].Contains(j.ToString()) == true)
                            {
                                int test = end - j;
                                cbDisable[test].Invoke();
                            }
                        }
                    }

                }
            }catch (Exception err){
                MessageBox.Show(err.Message);
            }


            void disSun(){ cbSunday.Enabled = false; cbSunday.Text = "Scheduled by another Movie!";
            }void disMon(){ cbMonday.Enabled = false; cbMonday.Text = "Scheduled by another Movie!";
            }void disTue(){ cbTuesday.Enabled = false; cbTuesday.Text = "Scheduled by another Movie!";
            }void disWed(){ cbWednesday.Enabled = false; cbWednesday.Text = "Scheduled by another Movie!";
            }void disThu(){ cbThursday.Enabled = false; cbThursday.Text = "Scheduled by another Movie!";
            }void disFri(){ cbFriday.Enabled = false; cbFriday.Text = "Scheduled by another Movie!";
            }void disSat(){ cbSaturday.Enabled = false; cbSaturday.Text = "Scheduled by another Movie!";
            }
        }
        /// <summary>
        /// ///////////////////////////////BTN Update
        /// </summary>
        /// 

        List<String> arrDay = new List<String> { };
        int intarrDay = 0;
        public void GetPos(){
            intarrDay = 0;
            //7,14,21,28,35
            Day = "";
            var CheckCB = new bool[] { cbSunday.Checked, cbMonday.Checked, cbTuesday.Checked,
                cbWednesday.Checked, cbThursday.Checked, cbFriday.Checked, cbSaturday.Checked };

            if (lblTime.Text == "7:00 AM to 10:00 AM"){
                for (int i = 0; i < 7; i++){
                    if (CheckCB[i] == true){
                        Day += " " + (i + 1) + ",";
                        arrDay.Add(" " + (i + 1) + ",");
                        intarrDay++;
                    }
                }
            }else if (lblTime.Text == "10:00 AM to 1:00 PM"){
                for (int i = 0; i < 7; i++){
                    if (CheckCB[i] == true){
                        Day += " " + (i + 8) + ",";
                        arrDay.Add(" " + (i + 8) + ",");
                        intarrDay++;
                    }
                }
            }else if (lblTime.Text == "1:00 PM to 4:00 PM"){
                for (int i = 0; i < 7; i++){
                    if (CheckCB[i] == true){
                        Day += " " + (i + 15) + ",";
                        arrDay.Add(" " + (i + 15) + ",");
                        intarrDay++;
                    }
                }
            }else if (lblTime.Text == "4:00 PM to 7:00 PM"){
                for (int i = 0; i < 7; i++){
                    if (CheckCB[i] == true){
                        Day += " " + (i + 22) + ",";
                        arrDay.Add(" " + (i + 22) + ",");
                        intarrDay++;
                    }
                }
            }else if (lblTime.Text == "7:00 PM to 10:00 PM"){
                for (int i = 0; i < 7; i++){
                    if (CheckCB[i] == true){
                        Day += " " + (i + 29) + ",";
                        arrDay.Add(" " + (i + 29) + ",");
                        intarrDay++;
                    }
                }
            }
        }

        public void UpdateSched()
        {
            try{
                Database db = new Database();
                String query = "UPDATE bookingdb.moviesched " +
                    "SET movieID = '"+movieInfoID+"' " +
                    "WHERE schedID = '"+ schedId + "'";
                db.conn.Open();

                MySqlCommand command3 = new MySqlCommand(query, db.conn);
                if (command3.ExecuteNonQuery() == 1){
                    MessageBox.Show("Update Schedule!");
                }else{
                    MessageBox.Show("Failed to Update Schedule");
                }
                command3.Dispose();
                db.conn.Close();
            }catch (Exception err){
                MessageBox.Show(err.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e){
            GetPos();
            UpdateSched();
        }


        ///////// BTN SET//////////////////

        SortedList<int,string> listOfMovie = new SortedList<int,string>();

        public void RetrieveMovie()
        {
            listOfMovie.Clear();
            try
            {
                Database db = new Database();
                String query = "SELECT movieID, Title FROM bookingdb.movieinfo";
                db.conn.Open();
                MySqlCommand command = new MySqlCommand(query,db.conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listOfMovie.Add(int.Parse(reader[0].ToString()), reader[1].ToString());
                }

                foreach (String str in listOfMovie.Values)
                {
                    cbTitle.Items.Add(str);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        String movieInfoID = "";

        private void cbTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetIDMovie();

            }
        }

        public void GetIDMovie()
        {
            try
            {
                Database db = new Database();
                String query = "SELECT movieID,imgPath FROM bookingdb.movieinfo WHERE Title ='" + cbTitle.Text + "' OR Title = '"+lblMovieTitle.Text+"' ";
                db.conn.Open();
                MySqlCommand command = new MySqlCommand(query, db.conn);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    movieInfoID = reader[0].ToString();
                    picBoxMovie.Image = Image.FromFile(reader[1].ToString());
                    picBoxMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("GetIDMovie: " + err.Message);
            }
        }

        public void ValidateSchedule()
        {
            try
            {
                Database db = new Database();
                String query = "SELECT schedID,SchedPosition FROM moviesched WHERE DATE = '"+WeekDate+"' AND Screen= '"+lblScreen.Text+"' " +
                    "AND movieID ='"+movieInfoID+"' AND Time ='"+lblTime.Text+"' AND isDeleted ='false' ";
                db.conn.Open();
                //  MySqlDataAdapter adp = new MySqlDataAdapter(query,db.conn);
                //  DataTable dt = new DataTable();
                //  adp.Fill(dt);
                //  if (dt.Rows[0][0].ToString()=="0")
                MySqlCommand command = new MySqlCommand(query, db.conn);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    schedId = reader[0].ToString();
                    GetPos();
                    Day += reader[1].ToString();
                    UpdateSched();
                }
                else
                {
                    GetPos();
                    InsertMovieSchedule();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void InsertMovieSchedule()
        {
            try{

                Database db = new Database();
                //insert ka 
                db.conn.Open();
                for (int i= 0; i< arrDay.Count ;i++) {
                    String query = "INSERT INTO bookingdb.moviesched(SchedPosition,Date,Time,Screen,movieID,isDeleted) " +
                        "VALUES( '" + arrDay[i].ToString() + "' , '" + WeekDate + "', '" + lblTime.Text + "', '" + lblScreen.Text + "','" + movieInfoID + "' ,'false') ";

                    MySqlCommand command = new MySqlCommand(query, db.conn);
                    if (command.ExecuteNonQuery() == 1 ){ 
                        if(arrDay.Count-1 == i){
                            MessageBox.Show("Set Schedule Successfully!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to Set Schedule ");
                    } 
                }
                arrDay.Clear();
                db.conn.Close();
            }
            catch (Exception err){
                MessageBox.Show(err.Message);
            }

        }

        private void btnSet_Click(object sender, EventArgs e){
            if (picBoxMovie.Image == null)
            {
                MessageBox.Show("Please Fill up Everything");
            }
            else
            {
                GetPos();
                InsertMovieSchedule();
                //ValidateSchedule();
            }
        }




        //////////////////////////
        
        public void PullOut()
        {
            try
            {
                Database db = new Database();
                String query = "UPDATE bookingdb.moviesched SET isDeleted = 'true' " +
                    "WHERE isDeleted = 'false' AND movieID ='"+movieInfoID+"'";
                db.conn.Open();

                MySqlCommand command = new MySqlCommand(query, db.conn);
                if (command.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("Pull out Successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to Pull out");
                }
                command.Dispose();
                db.conn.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnPullout_Click(object sender, EventArgs e){
            GetIDMovie();
            PullOut();
        }
        ////////////// Delete
        public void DeleteSched()
        {
            try
            {
                Database db = new Database();
                String query = "UPDATE bookingdb.moviesched SET isDeleted = 'true' " +
                    "WHERE SchedId = '"+schedId+"' AND isDeleted = 'false' ";
                db.conn.Open();

                MySqlCommand command = new MySqlCommand(query, db.conn);
                if (command.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("Deleted!");
                }
                else
                {
                    MessageBox.Show("Failed to Delete.");
                }
                command.Dispose();
                db.conn.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSched();
        }


    }
}
