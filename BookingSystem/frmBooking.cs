﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem
{
    public partial class frmBooking : Form
    {
        public frmBooking()
        {
            InitializeComponent();
            timer.Interval = 1000;
        }
        Timer timer = new Timer();
        Refresh refreshPnl = new Refresh();

        private void frmBooking_Load(object sender, EventArgs e)
        {
            cbScreen.SelectedIndex = 0;
            dbToListSched();
            BtnSeatArray();
        }

        Queue<string> sched = new Queue<string>();
        public List<string> seatnum = new List<string>();

        String selectedDate = "", SelSchedTime = "", sdDate = "";
        bool nextlayer = true, tries = true, sdMode;
        int seatnumcount = 0;

        private void cbScreen_SelectedIndexChanged(object sender, EventArgs e)
        {
            seatnum.Clear();
            seatnumcount = 0;
            pnlBooking.Controls.Clear();
            BtnSeatArray();
            dbToListSched();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            seatnum.Clear();
            seatnumcount = 0;
            pnlBooking.Controls.Clear();
            SelSchedTime = cbSched.SelectedItem.ToString();
            BtnSeatArray();
        }

        
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
        
        private void btnPayment_Click(object sender, EventArgs e)
        {

            if (seatnumcount <= 0)
            {
                MessageBox.Show("Please Select Seat Number!");
            }
            else if (cbSched.Text == "No Available")
            {
                MessageBox.Show("No schedule available");
            }
            else
            {
                DateTime currentDate = DateTime.Now;

                String date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
                String screen = cbScreen.SelectedItem.ToString();

                refreshPnl = new Refresh();
                refreshPnl.GetRefreshFrame(1);

                timer.Tick += new EventHandler(RefreshEvent);
                timer.Start();

                classOrderDetail c = new classOrderDetail();
                c.ResetData();
                c.setDate(date);
                c.setScreen(screen);
                c.setTime(SelSchedTime);
                c.setSetseatNo(seatnum);

                classTransaction t = new classTransaction();
                t.ResetData();
                t.setDate(currentDate.ToString("yyyy-MM-dd"));

                frmOrderDetail form = new frmOrderDetail();
                form.ShowDialog(this);


            }
        }

        public void RefreshEvent(object sender, EventArgs e)
        {
            refreshPnl = new Refresh();
            if (refreshPnl.SetRefreshFrame() == 0)
            {
                dbToListSched();
                timer.Stop();
            }
        }

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
           // String query = "SELECT COUNT(*) FROM tblsocialdistancing WHERE sdmode = 'true' AND '" + sdDate + "' = Date";
            String query = "SELECT COUNT(*) FROM tblsocialdistancing WHERE sdmode = 'true' ";
            MySqlDataAdapter sda = new MySqlDataAdapter(query ,db.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            //if (dt.Rows[0][0].ToString() == "1")
            if (int.Parse(dt.Rows[0][0].ToString()) >= 1)
            {
                sdMode = true;
            }
            else
            {
                sdMode = false;
            }
            db.conn.Close();
        }




        List<string> colorCoding = new List<string>();
        public void BtnSeatArray()
        {
            colorCoding.Clear();
            colorCoding.Add("");
            nextlayer = false;
            String date = DateTime.Now.ToString("yyyy-MM-dd");
            String screen = "";

            Database db = new Database();

            date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            selectedDate = date;
            screen = cbScreen.SelectedItem.ToString();
            

            if (cbSched.Items.Count > 1)
            {
                SelSchedTime = cbSched.SelectedItem.ToString();
            }

            SocialDistancingMode();
            int x = 10, y = 10, z = 28;
            int intQtyA = 1, intQtyB = 1, intQtyC = 1, intQtyD = 1, intQtyE = 1, intQtyF = 1, intQtyG = 1;

            for (int i = 1,j=1; i <= 308;j++,i++)
            {
                Button btnSeats = new Button();
                btnSeats.Size = new Size(40, 40);
                btnSeats.Location = new System.Drawing.Point(x, y);
                btnSeats.Text = i.ToString();
                btnSeats.Font = new Font("Arial", 8, FontStyle.Bold);


                //-- Test
                String refSeat ="";
                if (i >= 1 && i <= 56){
                    refSeat = "A-" + intQtyA.ToString();
                    btnSeats.Text ="A-"+intQtyA.ToString();
                    intQtyA++;
                }else if ((i >= 57 && i <= 65) || (i >= 85 && i <= 93) || (i >= 113 && i <= 121)){
                    refSeat = "B-" + intQtyB.ToString();
                    btnSeats.Text = "B-" + intQtyB.ToString();
                    intQtyB++;
                }else if ((i >= 66 && i <= 75) || (i >= 93 && i <= 103) || (i >= 122 && i <= 131)){
                    refSeat = "C-" + intQtyC.ToString();
                    btnSeats.Text = "C-" + intQtyC.ToString();
                    intQtyC++;
                }else if ((i >= 76 && i <= 84) || (i >= 104 && i <= 112) || (i >= 132 && i <= 140)){
                    refSeat = "D-" + intQtyD.ToString();
                    btnSeats.Text = "D-" + intQtyD.ToString();
                    intQtyD++;
                }else if ((i >= 141 && i <= 154) || (i >= 169 && i <= 182) || (i >= 197 && i <= 210)){
                    refSeat = "E-" + intQtyE.ToString();
                    btnSeats.Text = "E-" + intQtyE.ToString();
                    intQtyE++;
                }else if ((i >= 155 && i <= 168) || (i >= 183 && i <= 196) || (i >= 211 && i <= 224)){
                    refSeat = "F-" + intQtyF.ToString();
                    btnSeats.Text = "F-" + intQtyF.ToString();
                    intQtyF++;
                }else if (i >= 225 && i <= 308){
                    refSeat = "G-" + intQtyG.ToString();
                    btnSeats.Text = "G-" + intQtyG.ToString();
                    intQtyG++;
                }

                //


                if (sdMode == true && j % 2 == 0 && nextlayer == true)
                {
                    btnSeats.Enabled = false;
                    btnSeats.Text = "";
                }
                else if (sdMode == true && j % 2 != 0 && nextlayer == false)
                {
                    btnSeats.Enabled = false;
                    btnSeats.Text = "";
                }

                //Database read seat
                String query = "SELECT COUNT(*) FROM tblseatno sn INNER JOIN tblbookedseats bs ON bs.SeatNoID = sn.SeatNoID WHERE sn.Status = 'occupied' AND sn.SeatNo = '"+refSeat+"' AND bs.Time = '"+SelSchedTime+"' AND bs.Date = '"+date+"' AND bs.Screen='"+screen+"' ";
                //MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM tblbookedseats WHERE Date ='" + date + "' AND Screen = '" + screen + "' AND SeatNo LIKE '% " + i + ",%' AND Time = '" + SelSchedTime + "' ", db.conn);
                MySqlDataAdapter sda = new MySqlDataAdapter(query, db.conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    //this should be Green
                    btnSeats.BackColor = Color.FromArgb(119, 221, 119);
                    
                    //if (nextlayer==false)
                    if(btnSeats.Text=="")// && nextlayer==false)
                    {
                        //i++;
                        btnSeats.Text = i.ToString();
                        //nextlayer = true;
                        btnSeats.Enabled = true;
                        //                        sdMode = false;
                        j++;
                    }
                    colorCoding.Add("green");
                }
                else
                {
                    if (btnSeats.Text.Equals(""))
                    {
                        //this should be Orange or red
                        // btnSeats.BackColor = Color.FromArgb(255, 179, 71);
                        btnSeats.BackColor = Color.FromArgb(255, 105, 97);
                        colorCoding.Add("red");
                    }
                    else
                    {
                        //this shoud be White
                        btnSeats.BackColor = Color.White;
                        colorCoding.Add("white");
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
                if (i == z){
                    x = 10;
                    y += 40;
                    z += 28;
                    if (nextlayer == true){
                        nextlayer = false;
                    }else{
                        nextlayer = true;
                    }

                    // Split chair per row
                    if (z == 84 || z == 168 || z == 252){
                        y += 15;
                    }

                }
                // Split chair per column
                if (i == 65 || i == 93 || i == 121 || i == 75 || i == 103 || i == 131) //seat B,C, D
                {
                    x += 15;
                }else if (i == 154 || i == 182 || i == 210) //seat E,F
                {
                    x += 25;
                }
            }

            if (sdMode==true)
            {
                ReArrange();
            }
        }

        public void ReArrange()
        {
            pnlBooking.Controls.Clear();
            int intQtyA = 1, intQtyB = 1, intQtyC = 1, intQtyD = 1, intQtyE = 1, intQtyF = 1, intQtyG = 1;
            int x =10, y=10, z=28;
            for (int i=1;i<=308 ;i++)
            {
                Button btnSeats = new Button();
                btnSeats.Size = new Size(40, 40);
                btnSeats.Location = new System.Drawing.Point(x, y);
                btnSeats.Font = new Font("Arial", 8, FontStyle.Bold);
                    if (i >= 1 && i <= 56) {
                        btnSeats.Text = "A-" + intQtyA.ToString();
                        intQtyA++;
                    } else if ((i >= 57 && i <= 65) || (i >= 85 && i <= 93) || (i >= 113 && i <= 121)) {
                        btnSeats.Text = "B-" + intQtyB.ToString();
                        intQtyB++;
                    } else if ((i >= 66 && i <= 75) || (i >= 93 && i <= 103) || (i >= 122 && i <= 131)) {
                        btnSeats.Text = "C-" + intQtyC.ToString();
                        intQtyC++;
                    } else if ((i >= 76 && i <= 84) || (i >= 104 && i <= 112) || (i >= 132 && i <= 140)) {
                        btnSeats.Text = "D-" + intQtyD.ToString();
                        intQtyD++;
                    } else if ((i >= 141 && i <= 154) || (i >= 169 && i <= 182) || (i >= 197 && i <= 210)) {
                        btnSeats.Text = "E-" + intQtyE.ToString();
                        intQtyE++;
                    } else if ((i >= 155 && i <= 168) || (i >= 183 && i <= 196) || (i >= 211 && i <= 224)) {
                        btnSeats.Text = "F-" + intQtyF.ToString();
                        intQtyF++;
                    } else if (i >= 225 && i <= 308) {
                        btnSeats.Text = "G-" + intQtyG.ToString();
                        intQtyG++;
                    }
                


                if (i>=2 && i<307 && colorCoding[i-1]=="red" && colorCoding[i]=="white" && colorCoding[i+1]=="green"){
                    btnSeats.BackColor = Color.FromArgb(255, 105, 97);
                    btnSeats.Enabled = false;
                    btnSeats.Text = "";
                }else if(colorCoding[i]=="red"){
                    btnSeats.BackColor = Color.FromArgb(255, 105, 97);
                    btnSeats.Enabled = false;
                    btnSeats.Text = "";
                }else if(colorCoding[i]=="green"){
                    btnSeats.BackColor = Color.FromArgb(119, 221, 119);
                }else if (colorCoding[i]=="white"){
                    btnSeats.BackColor = Color.White;
                }

                if ((i >= 1 && i <= 56) || (i >= 225 && i <= 308)){
                    x += 41;
                }else{
                    x += 40;
                }

                btnSeats.Click += btn_Click;
                pnlBooking.Controls.Add(btnSeats);

                if (i == z){
                    x = 10;
                    y += 40;
                    z += 28;
                    if (nextlayer == true){
                        nextlayer = false;
                    }else{
                        nextlayer = true;
                    }

                    if (z == 84 || z == 168 || z == 252){
                        y += 15;
                    }
                }if (i == 65 || i == 93 || i == 121 || i == 75 || i == 103 || i == 131){
                    x += 15;
                }else if (i == 154 || i == 182 || i == 210){
                    x += 25;
                }
            }
        }


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
            else if (btn.BackColor == System.Drawing.Color.FromArgb(119, 221, 119)){
                MessageBox.Show("This is already reserve!");
            }else{
                if (seatnumcount < 10){
                    btn.BackColor = Color.SkyBlue;
                    seatnum.Add(btn.Text);
                    seatnumcount++;
                }else{
                    MessageBox.Show("You input maximum booking!");
                }
            }
        }


        public void dbToListSched()
        {
            try
            {
                cbSched.Items.Clear();
                sched.Clear();
                Database db = new Database();
                //String date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
                String screen = cbScreen.SelectedItem.ToString();
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
                }else if (day.Equals("Tuesday")){
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

                for (int i = start, j = 0; i <= end; i += 7, j++)
                {
                    daypos[j] = i;
                }

                String date = dt.ToString("MMM dd,yyyy") + " --to-- " + dt2.ToString("MMM dd,yyyy");
                String query = "SELECT Time FROM bookingdb.moviesched " +
                    "WHERE Date = '" + date + "' AND moviesched.Screen ='" + screen + "' AND isDeleted = 'false'" +
                    "AND (SchedPosition LIKE '% " + daypos[0].ToString() + ",%' OR SchedPosition LIKE '% " + daypos[1].ToString() + ",%' " +
                    "OR SchedPosition LIKE '% " + daypos[2].ToString() + ",%' OR SchedPosition LIKE '% " + daypos[3].ToString() + ",%' " +
                    "OR SchedPosition LIKE '% " + daypos[4].ToString() + ",%') ORDER BY Time ASC";

                //String query ="SELECT Time FROM bookingdb.moviesched WHERE  '" + date + "' BETWEEN CAST(StartDate AS DATE) AND EndDate AND moviesched.Screen='" + screen + "' ORDER BY Time ASC";

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

    }
}
