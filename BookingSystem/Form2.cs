using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BookingSystem
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            SocialDistancingMode();
        }

        /// ////////////////////////TEST ///////////////////////////////////
        String sdDate ="";
        bool sdMode;
        public void SocialDistancingMode()
        {
            if (selectedDate.Equals(null) || selectedDate.Equals(""))
            {
                sdDate = DateTime.Now.ToString("yyyy-MM-dd");
            }
            else
            {
                sdDate = selectedDate;
            }

            Database db = new Database();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM tblsettings WHERE sdmode = 'true' AND '" + sdDate + "' BETWEEN StartDate AND EndDate", db.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            if (dt.Rows[0][0].ToString() == "1")
            {
                sdMode = true;
            }
            else
            {
                sdMode = false;
            }
        }

        ////////////////////////////End of TEST//////////////////////////////////////

        public void LockMovie()
        {
            lblMovie.Enabled = false;
        }
        public void LockBooking()
        {
            lblBooking.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void pnlBooking_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            lblHome.ForeColor = Color.DarkViolet;
            lblBooking.ForeColor = Color.Black;
            lblMovie.ForeColor = Color.Black;

            DisableUnderMovie();
            DisableUnderBooking();
        }
        //////////////////////////////////////////Disable under Home /////////////////////
        
        public void DisableUnderHome()
        {

        }

        ///////////////////////////////////////////End of Disabling Home/////////////////////

        private void lblMovie_Click(object sender, EventArgs e)
        {
            lblMovie.ForeColor = Color.DarkViolet;
            lblHome.ForeColor = Color.Black;
            lblBooking.ForeColor = Color.Black;

            
            lblAdd.ForeColor = Color.DarkViolet;
            lblSetSched.ForeColor = Color.Black;
            lblUpdate.ForeColor = Color.Black;

            DisableUnderUpdateMovie();
            DisableUnderSetSchedule();

            lblAdd.Visible = true;

            btnSearch.Visible = false;
            tbSearch.Visible = false;
            dataGridView1.Visible = false;
            

            comboBox1.Visible = false;
            pnlBooking.Visible = false;
            dateTimePicker1.Visible = false;
            btnPayment.Visible = false;
            cbSched.Visible = false;

            lblSeats.Visible = false;
            lblCostumer.Visible = false;

            picBoxMovie.Visible = true;
            btnSelectImg.Visible = true;
            btnAddMovie.Visible = true;
            lblAddTitle.Visible = true;
            lblSetSched.Visible = true;
            lblUpdate.Visible = true;
            lblAddDirector.Visible = true;
            lblAddDuration.Visible = true;
            lblAddPrice.Visible = true;
            lblAddSynopsis.Visible = true;
            tbSynopsis.Visible = true;
            tbTitle.Visible = true;
            tbDirector.Visible = true;
            tbDuration.Visible = true;
            tbPrice.Visible = true;
            lblAddGenre.Visible = true;
            cbGenre.Visible = true;

        }

        //////////////////////////////////// Disable under Movie//////////////////////////////
        private void DisableUnderMovie()
        {
            lblAdd.Visible = false;
            lblSetSched.Visible = false;
            lblUpdate.Visible = false;
            DisableUnderAddMovie();
            DisableUnderUpdateMovie();
            DisableUnderSetSchedule();
        }

        private void DisableUnderAddMovie()
        {
            picBoxMovie.Visible = false;
            btnSelectImg.Visible = false;
            btnAddMovie.Visible = false;
            lblAddTitle.Visible = false;
            lblAddDirector.Visible = false;
            lblAddDuration.Visible = false;
            lblAddPrice.Visible = false;
            lblAddSynopsis.Visible = false;
            tbSynopsis.Visible = false;
            tbTitle.Visible = false;
            tbDirector.Visible = false;
            tbDuration.Visible = false;
            tbPrice.Visible = false;
            lblAddGenre.Visible = false;
            cbGenre.Visible = false;

            tbTitle.Text = "";
            tbDirector.Text = "";
            tbSynopsis.Text = "";
            tbDuration.Text = "";
            tbPrice.Text = "";
            img = "";
            picBoxMovie.Image = null;
            for (int i = 0; i < cbGenre.Items.Count; i++)
            {
                cbGenre.SetItemCheckState(i, (false ? CheckState.Checked : CheckState.Unchecked));
            }

        }

        private void DisableUnderUpdateMovie()
        {
            picBoxUpdate.Visible = false;
            lblUpdTitle.Visible = false;
            lblUpdDirector.Visible = false;
            lblUpdGenre.Visible = false;
            lblUpdDuration.Visible = false;
            lblUpdSynopsis.Visible = false;
            lblUpdPrice.Visible = false;

            cbUpdTitle.Visible = false;
            cbUpdGenre.Visible = false;
            tbUpdDirector.Visible = false;
            tbUpdDuration.Visible = false;
            tbUpdSynopsis.Visible = false;
            tbUpdPrice.Visible = false;
            btnUpdSelectImg.Visible = false;
            btnUpdate.Visible = false;
            btnSearchIdMov.Visible = false;
            btnDelete.Visible = false;

            movieInfoID = "";
            cbUpdTitle.Text = "";
            tbUpdDirector.Text = "";
            tbUpdDuration.Text = "";
            tbUpdSynopsis.Text = "";
            tbUpdPrice.Text = "";
            imgUpdate = "";
            picBoxUpdate.Image = null;
            for (int i = 0; i < cbUpdGenre.Items.Count; i++)
            {
                cbUpdGenre.SetItemCheckState(i, (false ? CheckState.Checked : CheckState.Unchecked));
            }
        }

        private void DisableUnderSetSchedule()
        {
            cbSetDate.Visible = false;
            cbSetScreen.Visible = false;
            pnlTime.Visible = false;
            pnlSched.Visible = false;
        }

        //////////////////////////////////////////////////////////// END OF DISABLING MOVIE//////////////////////////////////

        private void lblBooking_Click_1(object sender, EventArgs e)
        {
            lblBooking.ForeColor = Color.DarkViolet;
            lblHome.ForeColor = Color.Black;
            lblMovie.ForeColor = Color.Black;

            lblCostumer.ForeColor = Color.Black;
            lblSeats.ForeColor = Color.DarkViolet;

            DisableUnderMovie();
            BookingRefresh();
        }

        public void BookingRefresh()
        {
            DisableUnderBookingCostumer();
            pnlBooking.Controls.Clear();
            seatnum.Clear();
            seatnumcount = 0;

            lblSeats.Visible = true;
            lblCostumer.Visible = true;

            dateTimePicker1.Visible = true;
            comboBox1.Visible = true;
            comboBox1.SelectedIndex = 0;
            btnPayment.Visible = true;
            pnlBooking.Visible = true;
            
            dbToListSched();
            BtnSeatArray();
        }
        ////////////////////////////////////////// Disabling Booking //////////////////////////////////
        
        public void DisableUnderBooking()
        {
            pnlBooking.Controls.Clear();
            seatnum.Clear();
            seatnumcount = 0;

            lblSeats.Visible = false;
            lblCostumer.Visible = false;

            DisableUnderBookingSeats();
            DisableUnderBookingCostumer();
        }

        public void DisableUnderBookingSeats()
        {
            
            comboBox1.Visible = false;
            pnlBooking.Visible = false;
            dateTimePicker1.Visible = false;
            btnPayment.Visible = false;
            cbSched.Visible = false;
        }
        public void DisableUnderBookingCostumer()
        {
            
            dataGridView1.Visible = false;
            btnSearch.Visible = false;
            tbSearch.Visible = false;
        }

        //////////////////////////////////////////End of Disabling Booking///////////////////////////

        private void lblCostumer_Click_1(object sender, EventArgs e)
        {
            lblSeats.ForeColor = Color.Black;
            lblCostumer.ForeColor = Color.DarkViolet;

            DisableUnderBookingSeats();

            btnSearch.Visible = true;
            tbSearch.Visible = true;

            dbViewCstmrBkngs();
            dataGridView1.Visible = true;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seatnum.Clear();
            seatnumcount = 0;
            pnlBooking.Controls.Clear();
            BtnSeatArray();
            dbToListSched();
        }

        String selectedDate = "", SelSchedTime = "";
        bool nextlayer = true;
        public void BtnSeatArray()
        {

            String date = DateTime.Now.ToString("yyyy-MM-dd");
            String screen = "";

            Database db = new Database();

            date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            selectedDate = date;
            screen = comboBox1.SelectedItem.ToString();
            if (cbSched.Items.Count>1)
            {
                SelSchedTime = cbSched.SelectedItem.ToString();
            }

            SocialDistancingMode();

            int x = 10, y = 10, z = 28;

            
            for (int i = 1; i <= 308; i++)
            {
                Button btnSeats = new Button();
                btnSeats.Size = new Size(35, 35);
                btnSeats.Location = new System.Drawing.Point(x, y);
                btnSeats.Text = i.ToString();
                btnSeats.Font = new Font("Arial", 8, FontStyle.Bold);

                if (sdMode==true && i%2==0 && nextlayer==true)
                {
                    btnSeats.Enabled = false;
                    btnSeats.Text = "";
                }
                else if (sdMode == true && i%2 != 0 && nextlayer ==false)
                {
                    btnSeats.Enabled = false;
                    btnSeats.Text = "";
                }

                //Database read seat
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM bookedseats WHERE Date ='" + date + "' AND Screen = '" + screen + "' AND SeatNo LIKE '% " + i + ",%' AND Time = '" + SelSchedTime + "' ", db.conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    //this should be Green
                    btnSeats.BackColor = Color.FromArgb(119, 221, 119);
                }
                else
                {
                    if (btnSeats.Text.Equals(""))
                    {
                        //this should be Orange or red
                       // btnSeats.BackColor = Color.FromArgb(255, 179, 71);
                        btnSeats.BackColor = Color.FromArgb(255, 105, 97);
                    }
                    else
                    {
                        //this shoud be White
                        btnSeats.BackColor = Color.White;
                    }
                    
                }

                btnSeats.Click += btn_Click;
                pnlBooking.Controls.Add(btnSeats);

                if ((i >= 1 && i <= 56) || (i >= 225 && i <= 308))
                {
                    x += 41;
                }
                else
                {
                    x += 40;
                }

                // Create new layer for btn
                if (i == z)
                {
                    x = 10;
                    y += 40;
                    z += 28;
                    if (nextlayer==true)
                    {
                        nextlayer=false;
                    }
                    else
                    {
                        nextlayer = true;
                    }

                    // Split chair per row
                    if (z == 84 || z == 168 || z == 252)
                    {
                        y += 15;
                    }

                }
                // Split chair per column
                if (i == 65 || i == 93 || i == 121 || i == 75 || i == 103 || i == 131) //seat B,C, D
                {
                    x += 15;
                }
                else if (i == 154 || i == 182 || i == 210) //seat E,F
                {
                    x += 25;
                }
            }

        }

        
        public void dbViewCstmrBkngs()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
              
                dataGridView1.ColumnCount = 8;
                dataGridView1.Columns[0].Name = "ORNo.";
                dataGridView1.Columns[1].Name = "Name";
                dataGridView1.Columns[2].Name = "Seat No.";
                dataGridView1.Columns[3].Name = "Date";
                dataGridView1.Columns[4].Name = "Time";
                dataGridView1.Columns[5].Name = "Screen";
                dataGridView1.Columns[6].Name = "ContactNo.";
                dataGridView1.Columns[7].Name = "Email";

                Database db = new Database();

                String query1 = "SELECT bs.ORNO, tblcustomer.Name, bs.SeatNo,bs.Date,bs.Time,bs.Screen, tblcustomer.ContactNo, tblcustomer.Email " +
                                "FROM bookingdb.bookedseats bs " +
                                "JOIN tblcustomer " +
                                "ON tblcustomer.customerID = bs.customerID " +
                                "ORDER BY bs.Date DESC ";

                db.conn.Open();
                ArrayList AL = new ArrayList();

                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                MySqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    AL = new ArrayList();
                    AL.Add(reader[0].ToString());
                    AL.Add(reader[1].ToString());
                    AL.Add(reader[2].ToString());
                    AL.Add(reader[3].ToString());
                    AL.Add(reader[4].ToString());
                    AL.Add(reader[5].ToString());
                    AL.Add(reader[6].ToString());
                    AL.Add(reader[7].ToString());
                    dataGridView1.Rows.Add(AL.ToArray());
                }
                reader.Close();
                command1.Dispose();

                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                db.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dbSearchCstmrBkngs(String keyword)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                Database db = new Database();
                String query1 = "SELECT bookedseats.ORNO, tblcustomer.Name, bookedseats.SeatNo,bookedseats.Date,bookedseats.Time,bookedseats.Screen, tblcustomer.ContactNo, tblcustomer.Email FROM bookingdb.bookedseats JOIN tblcustomer ON tblcustomer.customerID = bookedseats.customerID WHERE tblcustomer.Name='" + keyword + "'";

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
                    AL.Add(reader[7].ToString());
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
                    dbViewCstmrBkngs();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        Queue<string> sched = new Queue<string>();
        public void dbToListSched()
        {
            try
            {
                cbSched.Items.Clear();
                sched.Clear();
                Database db = new Database();
                //String date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
                String screen = comboBox1.SelectedItem.ToString();
//dito na
                DateTime dt = dateTimePicker1.Value.Date.StartOfWeek(DayOfWeek.Sunday);
                DateTime dt2 = dt.AddDays(7).AddSeconds(-1);
                String day = dateTimePicker1.Value.DayOfWeek.ToString();
                int[] daypos = new int[5];
                int start = 0, end = 0;
                if (day.Equals("Sunday")){
                    start = 1; end = 29;
                }else if (day.Equals("Monday")){
                    start = 2; end = 30;
                }else  if (day.Equals("Tuesday")){
                    start = 3; end = 31;
                }else if (day.Equals("Wednesday")){
                    start = 4; end = 32;
                }else if (day.Equals("Thursday")){
                    start = 5; end = 33;
                }else if (day.Equals("Friday")){
                    start = 6; end = 34;
                }else if (day.Equals("Saturday")){
                    start = 7; end = 35;
                }
                
                for (int i=start,j=0 ;i <= end;i+=7,j++) 
                {
                    daypos[j]= i;
                }

                String date = dt.ToString("MMM dd,yyyy") + " --to-- " + dt2.ToString("MMM dd,yyyy");

                String query = "SELECT Time FROM bookingdb.moviesched " +
                    "WHERE Date = '"+date+ "' AND moviesched.Screen='" + screen + "' " +
                    "AND SchedPosition LIKE '%"+daypos[0]+ "%' OR SchedPosition LIKE '%"+daypos[1]+"%' " +
                    "OR SchedPosition LIKE '%"+daypos[2]+"%' OR SchedPosition LIKE '%"+daypos[3]+"%' " +
                    "OR SchedPosition LIKE '%"+daypos[4]+"%' ORDER BY Time ASC";

                //String query ="SELECT Time FROM bookingdb.moviesched WHERE  '" + date + "' BETWEEN CAST(StartDate AS DATE) AND EndDate AND moviesched.Screen='" + screen + "' ORDER BY Time ASC";
                
                db.conn.Open();
                MySqlCommand command = new MySqlCommand(query, db.conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read()){
                    sched.Enqueue(reader[0].ToString());
                }
                reader.Close();
                command.Dispose();
                db.conn.Close();

                foreach (String str in sched){
                    cbSched.Items.Add(str);
                }

                if (cbSched.Items.Count <= 0){
                    cbSched.Items.Add("No Available");
                }

                cbSched.SelectedIndex = 0;
                cbSched.Visible = true;
            }catch (Exception err){
                MessageBox.Show(err.Message);
            }
        }


        int seatnumcount = 0;
        public List<string> seatnum = new List<string>();
        public void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;


            if (btn.BackColor == System.Drawing.Color.SkyBlue)
            {
                if (seatnum.Contains(btn.Text))
                {
                    seatnum.Remove(btn.Text);
                    //this should be white
                    btn.BackColor = Color.White;
                    seatnumcount--;
                }

            }
            else if (btn.BackColor == System.Drawing.Color.FromArgb(119, 221, 119))
            {
                MessageBox.Show("This is already reserve!");

            }
            else
            {
                if (seatnumcount < 10)
                {
                    btn.BackColor = Color.SkyBlue;
                    seatnum.Add(btn.Text);
                    seatnumcount++;
                }
                else
                {
                    MessageBox.Show("You input maximum booking!");
                }
            }
        }


        private void btnPayment_Click(object sender, EventArgs e)
        {

            if (seatnumcount <= 0)
            {
                MessageBox.Show("Please Select Seat Number!");
            }
            else
            {
                String date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
                String screen = comboBox1.SelectedItem.ToString();

                Form3 form = new Form3();
                form.GetData(seatnum, date, screen, SelSchedTime);
                form.Visible = true;

                this.Visible = false;
            }

        }
        bool tries = true;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (tries == true)
            {
                string message = "All selected seats will not be save! Are you sure you want to change? ";
                DialogResult diagResult = MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo);
                if (diagResult == DialogResult.No)
                {
                    tries = false;
                    dateTimePicker1.Value = DateTime.ParseExact(selectedDate, "yyyy-MM-dd", null);
                }
                else if (diagResult == DialogResult.Yes)
                {
                    seatnumcount = 0;
                    seatnum.Clear();
                    pnlBooking.Controls.Clear();
                    BtnSeatArray();
                    dbToListSched();
                }
            }
            else
            {
                tries = true;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = tbSearch.Text.ToString();
            if (!keyword.Equals(""))
            {
                dbSearchCstmrBkngs(keyword);
            }
            else
            {
                MessageBox.Show("Please Input Something!");
                dbViewCstmrBkngs();
            }
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            seatnum.Clear();
            seatnumcount = 0;
            pnlBooking.Controls.Clear();
            BtnSeatArray();
        } 
        //////////////////////////////////////////////////          Movie Module               //////////////////////////////

        private void lblAdd_Click(object sender, EventArgs e)
        {
            lblUpdate.ForeColor = Color.Black;
            lblAdd.ForeColor = Color.DarkViolet;
            lblSetSched.ForeColor = Color.Black;

            DisableUnderUpdateMovie();
            DisableUnderSetSchedule();
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            dbSelect();
            lblUpdate.ForeColor = Color.DarkViolet;
            lblAdd.ForeColor = Color.Black;
            lblSetSched.ForeColor = Color.Black;
            DisableUnderAddMovie();
            DisableUnderSetSchedule();

            picBoxUpdate.Visible = true;
            lblUpdTitle.Visible = true;
            lblUpdDirector.Visible = true;
            lblUpdGenre.Visible = true;
            lblUpdDuration.Visible = true;
            lblUpdSynopsis.Visible = true;
            lblUpdPrice.Visible = true;
            cbUpdTitle.Visible = true;
            cbUpdGenre.Visible = true;

            tbUpdDirector.Visible = true;
            tbUpdDuration.Visible = true;
            tbUpdSynopsis.Visible = true;
            tbUpdPrice.Visible = true;
            btnUpdSelectImg.Visible = true;
            btnUpdate.Visible = true;
            btnSearchIdMov.Visible = true;
            btnDelete.Visible = true;

        }

        private void lblSetSched_Click(object sender, EventArgs e)
        {
            getStartAndEndDate();
            cbSetScreen.SelectedIndex = 0;
            cbSetDate.SelectedIndex = 0;
            btnSchedArray();

            
            cbSetDate.Visible = true;
            cbSetScreen.Visible = true;
            pnlTime.Visible = true;
            pnlSched.Visible = true;
            lblUpdate.ForeColor = Color.Black;
            lblAdd.ForeColor = Color.Black;
            lblSetSched.ForeColor = Color.DarkViolet;
            DisableUnderAddMovie();
            DisableUnderUpdateMovie();

        }

        String img = "";
        private void btnSelectImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *png)|*.jpg; *png";

            if (opf.ShowDialog()==DialogResult.OK)
            {
                picBoxMovie.Image = Image.FromFile(opf.FileName);
                String replace = opf.FileName;
                img = replace.Replace("\\","\\\\");
            }
            
        }

        


        private void btnAddMovie_Click(object sender, EventArgs e)
        {

            String genre = "",check="";
            foreach (string s in cbGenre.CheckedItems)
            {
                genre += s + ", ";
                check += s;
            }


            if (img == null ||check.Equals("") || tbTitle.Text.Equals(null) || tbDirector.Text.Equals(null) || tbDuration.Text.Equals(null) || tbSynopsis.Text.Equals(null) || tbPrice.Text.Equals(null))
            {
                MessageBox.Show("Everything is empty");
            }
            else
            {

                try
                {
                    Database db = new Database();
                    String query1 = "INSERT INTO bookingdb.movieinfo(Title,Director,Genre,Duration,Synopsis,Price,isDeleted,imgPath) " +
                                    "VALUES('" + tbTitle.Text + "' , '"+tbDirector.Text+"' , '" + genre + "'  , '" + tbDuration.Text + "' , '"+tbSynopsis.Text+"' ,'" + tbPrice.Text + "' , '"+"false"+ "' , '" + img + "')";
                    db.conn.Open();

                    MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                    if (command1.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Added new Movie");
                        tbTitle.Text = "";
                        tbDirector.Text = "";
                        tbSynopsis.Text = "";
                        tbDuration.Text = "";
                        tbPrice.Text = "";
                        img = "";
                        picBoxMovie.Image = null;
                        for (int i=0;i <cbGenre.Items.Count ;i++)
                        {
                            cbGenre.SetItemCheckState(i, (false ? CheckState.Checked : CheckState.Unchecked));
                        }
                    }
                    command1.Dispose();
                    db.conn.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        //////////////////////////////////////////Update

        List<string> sortList = new List<string>();

        public void dbSelect()
        {
            try
            {
                sortList.Clear();
                cbUpdTitle.Items.Clear();

                String query1 = "";
                query1 = "SELECT Title FROM movieinfo WHERE isDeleted ='false'";

                Database db = new Database();
                db.conn.Open();
                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                MySqlDataReader reader = command1.ExecuteReader();
                
                while (reader.Read())
                {
                    sortList.Add(reader[0].ToString());
                }
                

                reader.Close();
                command1.Dispose();
                db.conn.Close();

                foreach (String str in sortList)
                {
                    cbUpdTitle.Items.Add(str);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        String movieInfoID = "";
        public void dbDisplayAfterSelect()
        {
            try{
                Database db = new Database();
                String query1 = "SELECT * FROM movieinfo WHERE Title = '"+cbUpdTitle.Text+"'";
                db.conn.Open();
                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command1);
                DataTable table = new DataTable();

                adapter.Fill(table);

                movieInfoID = table.Rows[0][0].ToString();
                tbUpdDirector.Text = table.Rows[0][2].ToString();
                tbUpdDuration.Text = table.Rows[0][4].ToString();
                tbUpdSynopsis.Text = table.Rows[0][5].ToString();
                tbUpdPrice.Text = table.Rows[0][6].ToString();
                var imgs = table.Rows[0][8].ToString();

                picBoxUpdate.Image = Image.FromFile(imgs);
                String replace = imgs.Replace("\\","\\\\");
                imgUpdate = replace;

                adapter.Dispose();
                db.conn.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message+"Wlalang lumabas");
            }
        }


        //set

        public void dbDisplayAfterSelectForSet()
        {
            try
            {
                Database db = new Database();
                String query1 = "SELECT * FROM movieinfo WHERE Title = ' The rocket '";
                db.conn.Open();
                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command1);
                DataTable table = new DataTable();

                adapter.Fill(table);

                movieInfoID = table.Rows[0][0].ToString();
              //  tbUpdDuration.Text = table.Rows[0][4].ToString();
              //  tbUpdSynopsis.Text = table.Rows[0][5].ToString();
              //  tbUpdPrice.Text = table.Rows[0][6].ToString();
                var imgs = table.Rows[0][8].ToString();


                adapter.Dispose();
                db.conn.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        //////////update or remove

        public void UpdateOrDeleteMovieInfo(String isDeleted)
        {
            String genre = "", check = "";
            foreach (string s in cbUpdGenre.CheckedItems)
            {
                genre += s + ", ";
                check += s; 
            }

            if ( imgUpdate == null || (check.Equals("") && isDeleted.Equals("false")) || cbUpdTitle.Text.Equals(null) || tbUpdDirector.Text.Equals(null) || tbUpdDuration.Text.Equals(null) || tbUpdSynopsis.Text.Equals(null) || tbUpdPrice.Text.Equals(null))
            {
                MessageBox.Show("Everything is not fill");
            }
            else
            {
                try
                {
                    Database db = new Database();

                    String query1 = "";

                    if (isDeleted.Equals("false"))
                    {
                        query1 = "UPDATE bookingdb.movieinfo " +
                                 "SET Title ='" + cbUpdTitle.Text + "',Director ='" + tbUpdDirector.Text + "' , Genre= '" + genre + "'  , Duration = '" + tbUpdDuration.Text + "' , Synopsis = '" + tbUpdSynopsis.Text + "' , Price = '" + tbUpdPrice.Text + "' , isDeleted = 'false' , imgPath = '" + imgUpdate + "' " +
                                 "WHERE movieID = '" + movieInfoID + "'";
                    }else if (isDeleted.Equals("true"))
                    {
                        query1 = "UPDATE bookingdb.movieinfo " +
                                 "SET isDeleted = 'true'" +
                                 "WHERE movieID = '" + movieInfoID + "'";
                    }
                        
                    db.conn.Open();
                    MySqlCommand command = new MySqlCommand(query1, db.conn);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        if (isDeleted.Equals("false"))
                        {
                            MessageBox.Show("Movie info updated");
                        }
                        else if(isDeleted.Equals("true"))
                        {
                            MessageBox.Show("Movie info is Deleted");
                        }

                        movieInfoID = "";
                        cbUpdTitle.Text = "";
                        tbUpdDirector.Text = "";
                        tbUpdDuration.Text = "";
                        tbUpdSynopsis.Text = "";
                        tbUpdPrice.Text = "";
                        imgUpdate = "";
                        picBoxUpdate.Image = null;
                        for (int i = 0; i < cbUpdGenre.Items.Count; i++)
                        {
                            cbUpdGenre.SetItemCheckState(i, (false ? CheckState.Checked : CheckState.Unchecked));
                        }
                        dbSelect();

                    }
                    else
                    {
                        MessageBox.Show("Movie info update failed");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        //


        ////////// DB END

        String imgUpdate = "";

        private void btnUpdSelectImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *png)|*.jpg; *png";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                picBoxUpdate.Image = Image.FromFile(opf.FileName);
                String replace = opf.FileName;
                imgUpdate = replace.Replace("\\", "\\\\");
            }
        }

        private void btnSearchIdMov_Click(object sender, EventArgs e)
        {
            dbDisplayAfterSelect();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to DELETE?", "Delete Movie?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UpdateOrDeleteMovieInfo("true");
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Update?", "Update Movie?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UpdateOrDeleteMovieInfo("false");
            }
        }



        ////                     ////                            ////

        String WholeWeek = "";
        List<int> listofPos = new List<int>();
        public void getStartAndEndDate() {            
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

            int[,] Arrday = new int[7,5] { 
                { 1, 8, 15, 22, 29},   { 2, 9, 16, 23, 30}, { 3, 10, 17, 24, 31 }, 
                { 4, 11, 18, 25, 32 }, { 5, 12, 19, 26, 33 }, { 6, 13, 20, 27, 34 },
                { 7, 14, 21, 28, 35 }};

            String dayToday = DateTime.Now.DayOfWeek.ToString();
            string[] day = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            for (int i=0; i<day.Length-1 ;i++) {
                if (dayToday == day[i].ToString()){
                    for (int j=i-1;j >= 0;j--){
                        for (int k =0; k<5 ;k++){
                            listofPos.Add(Arrday[j, k]);
                        }
                    }
                } 
            }
        }

        String SetbtnImg = "", strSetMovieName = "", newMovieInfoID ="";
        public void GetNameAndImgMovie(String pos)
        {
            Database db = new Database();
            String query2 = "SELECT movieID,Title,imgPath FROM movieinfo WHERE movieID = " +
                "ANY (SELECT movieID FROM moviesched WHERE Screen='" + cbSetScreen.Text +"' " +
                "AND Date = '" + cbSetDate.Text + "' AND SchedPosition LIKE '% "+pos+",%' AND isDeleted = 'false')";

            db.conn.Open();
            MySqlCommand command = new MySqlCommand(query2, db.conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            db.conn.Close();

            newMovieInfoID = table.Rows[0][0].ToString();
            strSetMovieName = table.Rows[0][1].ToString();
            SetbtnImg = table.Rows[0][2].ToString();
            
        }

        public void btnSchedArray()
        {
            Database db = new Database();
            int Xsched = 10, Ysched = 35, Zsched = 7;
            int Xday = 40;
            string[] day ={"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"};
            // DateTime dat = DateTime.Now.StartOfWeek(DayOfWeek.Sunday);
            int x = cbSetDate.SelectedIndex;
            int y =0;
            for (int i =0; i<x ;i++){
                y += 7;
            }
            DateTime dat = DateTime.Now.AddDays(y).StartOfWeek(DayOfWeek.Sunday);
            for (int i=0;i<7 ;i++)
            {
                DateTime dt2 = dat.AddDays(i);
                Label lblday = new Label();
                lblday.Text = dt2.ToString("dd") +" ,"+ day[i].ToString();
                lblday.TextAlign = ContentAlignment.MiddleCenter;
                lblday.AutoSize = true;
                lblday.Location = new Point(Xday,10);
                lblday.BackColor = Color.Transparent;
                lblday.Font = new Font("Arial", 12, FontStyle.Bold);
                pnlSched.Controls.Add(lblday);
                Xday += 164;
            }

            db.conn.Open();
            for (int i = 1; i <= 35; i++)
            {
                Button btnSched = new Button();
                btnSched.Tag = i.ToString();
                btnSched.Size = new Size(162, 92);
                btnSched.Location = new System.Drawing.Point(Xsched, Ysched);
                btnSched.Font = new Font("Arial", 12, FontStyle.Bold);
                btnSched.BackColor = Color.White;

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
                        "AND isDeleted = 'false' " +
                        "AND SchedPosition LIKE '% "+i+",%'";

                    MySqlDataAdapter sda = new MySqlDataAdapter(query, db.conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        String pos = btnSched.Tag.ToString();
                        GetNameAndImgMovie(pos);
                        btnSched.Text= strSetMovieName;
                        btnSched.Image = new Bitmap(Image.FromFile(SetbtnImg), new Size(217, 151));
                    }
                    else
                    {
                        btnSched.Text = "No Movie";
                        btnSched.Font = new Font("Arial", 12, FontStyle.Regular);
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
            MessageBox.Show(btnSched.Tag.ToString());

            //Sunday    = 1,8,15,22,29
            //Monday    = 2,9,16,23,30
            //Tuesday   = 3,10,17,24,31
            //Wednesday = 4,11,18,25,32
            //Thursday  = 5,12,19,26,33
            //Friday    = 6,13,20,27,34
            //Saturday  = 7,14,21,28,35
            String time = "";
            int pos = Convert.ToInt32(btnSched.Tag);
            if ( pos >= 1 && pos <=7){
                time = "7:00 AM to 10:00 AM";
            }else if (pos >= 8 && pos <= 14){
                time = "10:00 AM to 1:00 PM";
            }else if(pos >=15 && pos <=21){
                time = "1:00 PM to 4:00 PM";
            }else if (pos >=22 && pos <=28){
                time = "4:00 PM to 7:00 PM";
            }else if (pos >=29 && pos <=35){
                time = "7:00 PM to 10:00 PM";
            }

            Form4 form = new Form4();
            if ( pos >=1 && btnSched.Text !="No Movie" ){
                GetNameAndImgMovie(pos.ToString());
                form.FetchInfo(newMovieInfoID, cbSetScreen.Text,cbSetDate.Text,time ,btnSched.Tag.ToString());
                form.Visible = true;
            }else if (btnSched.Text == "No Movie"){
                form.Run(cbSetScreen.Text, cbSetDate.Text, time, btnSched.Tag.ToString());
                form.Visible = true;
            }
        }

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

        //// ////       /   //////          /////           /////
        ///
        
    }
}
