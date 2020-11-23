using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class frmSocialDistancing : Form
    {
        public frmSocialDistancing()
        {
            InitializeComponent();
            SDMode();
            listView1.Visible = false;
            monthCalendar1.Visible = false;
            label2.Visible = false;
        }

        DateTime currentDate = DateTime.Now;
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime d = monthCalendar1.SelectionRange.Start;
            if (currentDate.Date <= d.Date){
                ValidateSeat();
            }
            else{
                MessageBox.Show("You can't add or remove");
            }
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime d = monthCalendar1.SelectionRange.Start;
            String date = d.Year.ToString() + "-" + d.Month.ToString();
            if (currentDate.Date < d.Date)
            {
                SDModeDate(date);
            }
        }

        public void SDMode() {
            try
            {
                Database db = new Database();
                String query = "SELECT COUNT(sdmode) FROM bookingdb.tblsocialdistancing WHERE sdmode ='true'";

                db.conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, db.conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (int.Parse(dt.Rows[0][0].ToString()) >= 1)
                {
                    SDModeDate("");
                }
                else
                {
                    btnActivate.Text = "Deactivated";
                    listView1.Enabled = false;
                    monthCalendar1.Enabled = false;
                }

                db.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void SDModeDate(String date)
        {
            try
            {
                int x = 0, intMonthRef = 0, y = 0;
                bool SwitchOn = true,turnOff = true; ;

                listView1.Clear();
                monthCalendar1.RemoveAllBoldedDates();

                DateTime dFirstDayOfThisMonth = DateTime.Today.AddDays(-(DateTime.Today.Day - 1));
                DateTime dNextMonth = dFirstDayOfThisMonth.AddMonths(+2).AddMinutes(-1);

                String query1 = "";
                if (date == "" || date == null || date == dFirstDayOfThisMonth.ToString("yyyy-MM") || date == dNextMonth.ToString("yyyy-MM"))
                {
                    query1 = "SELECT DATE_FORMAT(Date,'%Y-%m-%d') FROM tblsocialdistancing WHERE sdmode ='true' AND Date BETWEEN '" + dFirstDayOfThisMonth.ToString("yyyy-MM-dd") + "' AND'" + dNextMonth.ToString("yyyy-MM-dd") + "'  ORDER BY tblsocialdistancing.Date ";
                }
                else
                {
                    String[] Arrdate = date.Split('-');
                    query1 = "SELECT DATE_FORMAT(Date,'%Y-%m-%d') FROM tblsocialdistancing WHERE sdmode ='true' AND  YEAR(Date) = '" + Arrdate[0].ToString() + "' ORDER BY Date ASC";
                    SwitchOn = false;
                }
                

                Database db = new Database();
                db.conn.Open();

                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                MySqlDataReader reader = command1.ExecuteReader();

                ArrayList AL = new ArrayList();

                listView1.View = View.Tile;
                List<ListViewGroup> month = new List<ListViewGroup>();
                
                while (reader.Read())
                {
                    String dext = reader[0].ToString();
                    String[] split = dext.Split('-');
                    DateTime myVacation1 = new DateTime(int.Parse(split[0].ToString()), int.Parse(split[1].ToString()), int.Parse(split[2].ToString()));
                    monthCalendar1.AddBoldedDate(myVacation1);

                    String[] whichMonth = { "This Month", "Next Month", "Future Date" };
                    String[] ArrMonth = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                    
                    int IntMonth = 0;
                    String strMonth = "";

                    for (int i = 1; i <= ArrMonth.Length; i++){
                        if (int.Parse(split[1].ToString()) == i){

                            IntMonth = i;
                            strMonth = ArrMonth[i].ToString();
                            if (turnOff == true){
                                intMonthRef = IntMonth;
                                turnOff = false;
                            }
                            break;
                        }
                    }

                    if (SwitchOn == true){
                        DateTime dt3 = DateTime.Parse(reader[0].ToString());

                        if (IntMonth != intMonthRef){
                            listView1.Groups.Add(month[x]);
                            x = 0;
                            y++;
                            intMonthRef = IntMonth;
                            month.Clear();
                        }if (dt3.ToString("yyyy-MM") != currentDate.ToString("yyyy-MM")){
                            y = 1;
                        }
                        month.Add(new ListViewGroup(ArrMonth[IntMonth].ToString() + " " + split[0].ToString() + "( " + whichMonth[y].ToString() + ")", HorizontalAlignment.Left));

                    }else{
                        if (IntMonth != intMonthRef){
                            listView1.Groups.Add(month[x]);
                            x = 0;
                            intMonthRef = IntMonth;
                            month.Clear();
                        }
                        month.Add(new ListViewGroup(ArrMonth[IntMonth].ToString() + " " + split[0].ToString() + "( " + whichMonth[2].ToString() + ")", HorizontalAlignment.Left));
                    }
                    listView1.Items.Add(new ListViewItem(reader[0].ToString(), month[x]));
                }foreach (ListViewGroup list in month){
                    listView1.Groups.Add(list);
                }

                db.conn.Close();
            }catch (Exception err){
                MessageBox.Show(err.Message);
            }
        }

        public void ValidateSeat()
        {
            try
            {
                String selectionDate = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
                Database db = new Database();
                String query = "SELECT COUNT(Date) FROM bookingdb.tblbookedseats WHERE Date = '" + selectionDate + "' AND Status = 'occupied' ";

                db.conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, db.conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Can't activate social distancing mode with the selected date because some of the chair is already ocuppied");
                }
                else
                {
                    ValidateDate();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        public void ValidateDate()
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

                if (dt.Rows[0][0].ToString() == "1"){

                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Delete Date?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DeleteDate(selectionDate);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                else{
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to add date?", "Add Date?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        InsertDate(selectionDate);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                SDModeDate("");

                db.conn.Close();
            }catch (Exception err){
                MessageBox.Show(err.Message);
            }
        }

        public void InsertDate(String date)
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
                    SDModeDate(date2);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void DeleteDate(String date)
        {
            try
            {
                Database db = new Database();
                String query1 = "DELETE FROM tblsocialdistancing WHERE Date ='"+ date + "' ";
                db.conn.Open();

                MySqlCommand command1 = new MySqlCommand(query1, db.conn);
                if (command1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Successfully Deleted.");
                }
                else
                {
                    MessageBox.Show("Failed to Delete.");
                }
                command1.Dispose();
                db.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void LayoutDes()
        {
            if (btnActivate.Text=="Deactivated")
            {
                //current
                monthCalendar1.Location = new System.Drawing.Point(260, 41);
                label1.Location = new System.Drawing.Point(499, 41);
                btnActivate.Location = new System.Drawing.Point(506, 112);
            }
            else
            {
                monthCalendar1.Location = new System.Drawing.Point(350, 41);
                label1.Location = new System.Drawing.Point(700, 41);
                btnActivate.Location = new System.Drawing.Point(700, 202);

            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnActivate.Text == "Activated") {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Deactive?", "Deactive?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Database db = new Database();
                        String query = "UPDATE bookingdb.tblsocialdistancing SET sdmode = 'false' ";

                        db.conn.Open();
                        MySqlCommand command = new MySqlCommand(query, db.conn);
                        if (command.ExecuteNonQuery() >= 1)
                        {
                            MessageBox.Show("Successfully Deactivated");
                            btnActivate.Text = "Deactivated";
                            listView1.Enabled = false;
                            monthCalendar1.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to Deactivate");
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Activate?", "Activate?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Database db = new Database();
                        String query = "UPDATE tblsocialdistancing SET sdmode = 'true' " +
                            "WHERE Date != ALL (SELECT DATE FROM tblbookedseats WHERE Status = 'occupied')";

                        db.conn.Open();
                        MySqlCommand command = new MySqlCommand(query, db.conn);
                        if (command.ExecuteNonQuery() >= 1)
                        {
                            MessageBox.Show("Successfully Activated");
                            btnActivate.Text = "Activated";
                            listView1.Enabled = true;
                            monthCalendar1.Enabled = true;
                            SDModeDate("");
                        }
                        else
                        {
                            MessageBox.Show("Failed to Activate");
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
