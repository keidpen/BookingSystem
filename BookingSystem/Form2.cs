using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BookingSystem
{
    public partial class Form2 : Form
    {
        Database dbtest = new Database();
        public Form2()
        {
            InitializeComponent();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
        }

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
        }

        private void DisableUnderUpdateMovie()
        {

        }

        private void DisableUnderSetSchedule()
        {

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
            btnPayment.Visible = true;
            
            dateTimePicker1.Visible = true;
            comboBox1.Visible = true;
            comboBox1.SelectedIndex = 0;
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
        public void BtnSeatArray()
        {

            String date = DateTime.Now.ToString("yyyy-MM-dd");
            String screen = "Screen 2";

            Database db = new Database();

            date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            selectedDate = date;
            screen = comboBox1.SelectedItem.ToString();
            if (cbSched.Items.Count>1)
            {
                SelSchedTime = cbSched.SelectedItem.ToString();
            }
            


            int x = 10, y = 10, z = 28;

            for (int i = 1; i <= 308; i++)
            {
                Button btnSeats = new Button();
                btnSeats.Size = new Size(35, 35);
                btnSeats.Location = new System.Drawing.Point(x, y);
                btnSeats.Text = i.ToString();
                btnSeats.Font = new Font("Arial", 8, FontStyle.Regular);


                //Database read seat
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM bookedseats WHERE Date ='" + date + "' AND Screen = '" + screen + "' AND SeatNo LIKE '% " + i + ",%' AND Time = '" + SelSchedTime + "' ", db.conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    btnSeats.BackColor = Color.Red;
                }
                else
                {
                    btnSeats.BackColor = Color.Yellow;
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
                String date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
                String screen = comboBox1.SelectedItem.ToString();

                String query = "SELECT Time FROM bookingdb.moviesched WHERE  '" + date + "' BETWEEN StartDate AND EndDate AND moviesched.Screen='" + screen + "' ORDER BY Time ASC";
                db.conn.Open();
                MySqlCommand command = new MySqlCommand(query, db.conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sched.Enqueue(reader[0].ToString());
                }
                reader.Close();
                command.Dispose();
                db.conn.Close();

                foreach (String str in sched)
                {
                    cbSched.Items.Add(str);
                }

                if (cbSched.Items.Count <= 0)
                {
                    cbSched.Items.Add("No Available");
                }

                cbSched.SelectedIndex = 0;
                cbSched.Visible = true;
            }
            catch (Exception err)
            {
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
                    btn.BackColor = Color.Yellow;
                    seatnumcount--;
                }

            }
            else if (btn.BackColor == System.Drawing.Color.Red)
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

        private void lblSeats_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            seatnum.Clear();
            seatnumcount = 0;
            pnlBooking.Controls.Clear();
            BtnSeatArray();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        //////////////////////////////////////////////////          Movie Module               //////////////////////////////

        private void lblAdd_Click(object sender, EventArgs e)
        {
            lblUpdate.ForeColor = Color.Black;
            lblAdd.ForeColor = Color.DarkViolet;
            lblSetSched.ForeColor = Color.Black;
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            lblUpdate.ForeColor = Color.DarkViolet;
            lblAdd.ForeColor = Color.Black;
            lblSetSched.ForeColor = Color.Black;
            DisableUnderAddMovie();
        }

        private void lblSetSched_Click(object sender, EventArgs e)
        {
            lblUpdate.ForeColor = Color.Black;
            lblAdd.ForeColor = Color.Black;
            lblSetSched.ForeColor = Color.DarkViolet;
            DisableUnderAddMovie();
        }

        private void btnSelectImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *png)|*.jpg; *png";

            if (opf.ShowDialog()==DialogResult.OK)
            {
                picBoxMovie.Image = Image.FromFile(opf.FileName);
            }

            
            
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            picBoxMovie.Image.Save(ms, picBoxMovie.Image.RawFormat);
            byte[] img = ms.ToArray();

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




    }
}
