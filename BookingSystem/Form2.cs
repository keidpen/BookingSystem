using MySql.Data.MySqlClient;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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
        }

        private void lblMovie_Click(object sender, EventArgs e)
        {
            lblMovie.ForeColor = Color.DarkViolet;
            lblHome.ForeColor = Color.Black;
            lblBooking.ForeColor = Color.Black;

            lblSeats.Visible = false;
            lblCostumer.Visible = false;
        }

        private void lblBooking_Click_1(object sender, EventArgs e)
        {
            lblBooking.ForeColor = Color.DarkViolet;
            lblHome.ForeColor = Color.Black;
            lblMovie.ForeColor = Color.Black;

            dataGridView1.Visible = false;
            btnSearch.Visible = false;
            tbSearch.Visible = false;

            lblCostumer.ForeColor = Color.Black;
            lblSeats.ForeColor = Color.DarkViolet;
            lblSeats.Visible = true;
            lblCostumer.Visible = true;
            dateTimePicker1.Visible = true;
            comboBox1.Visible = true;
            pnlBooking.Visible = true;
            BtnSeatArray();

        }

        private void lblCostumer_Click_1(object sender, EventArgs e)
        {
            lblSeats.ForeColor = Color.Black;
            lblCostumer.ForeColor = Color.DarkViolet;
            comboBox1.Visible = false;
            pnlBooking.Visible = false;
            dateTimePicker1.Visible = false;

            btnSearch.Visible = true;
            tbSearch.Visible = true;

            dbViewCstmrBkngs();
            dataGridView1.Visible = true;
            
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlBooking.Controls.Clear();
            BtnSeatArray();
        }

        public void BtnSeatArray()
        {

            String date = DateTime.Now.ToString("MM-dd-yyyy");
            String screen = "Screen 2";

            Database db = new Database();

            date = dateTimePicker1.Value.Date.ToString("MM-dd-yyyy");
            screen = comboBox1.SelectedItem.ToString();
            

            int x = 10, y = 10, z = 28;

            for (int i = 1; i <= 308; i++)
            {
                Button btnSeats = new Button();
                btnSeats.Size = new Size(35, 35);
                btnSeats.Location = new System.Drawing.Point(x, y);
                btnSeats.Text = i.ToString();
                btnSeats.Font = new Font("Arial", 8, FontStyle.Regular);
                
                //Database read seat
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM bookedseats WHERE Date ='" + date + "' AND Screen = '" + screen + "' AND SeatNo = '" + i + "' ", db.conn);
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

                if ((i>=1 && i<=56) || (i>=225 && i<=308))
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
                    if (z == 84 || z == 168 || z == 252 )
                    {
                        y+=15;
                    }
                }


                // Split chair per column
                if (i==65 || i==93 || i==121 || i==75 || i==103 || i==131) //seat B,C, D
                {
                    x += 15;
                }else if (i==154 || i== 182 || i==210) //seat E,F
                {
                    x += 25;
                }
            }

        }

        public void dbViewCstmrBkngs()
        {
            try
            {
                Database db = new Database();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT Name,SeatNo,Date,Time,Screen FROM bookingdb.bookedseats", db.conn);

                db.conn.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "bookedseats");
                dataGridView1.DataSource = ds.Tables["bookedseats"];
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
                Database db = new Database();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT Name,SeatNo,Date,Time,Screen FROM bookingdb.bookedseats WHERE Name='"+keyword+"'", db.conn);

                db.conn.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "bookedseats");
                dataGridView1.DataSource = ds.Tables["bookedseats"];
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                db.conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show("You click no:  "+ btn.Text, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (btn.BackColor == System.Drawing.Color.Red)
            {
                btn.BackColor = Color.Yellow;
            }
            else
            {
                btn.BackColor = Color.Red;
                String date = dateTimePicker1.Value.Date.ToString("MM-dd-yyyy");
                String screen = comboBox1.SelectedItem.ToString();

                Form3 form = new Form3();
                form.GetData(btn.Text,date,screen);
                form.Visible = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            pnlBooking.Controls.Clear();
            BtnSeatArray();
        }

        private void lblSeats_Click(object sender, EventArgs e)
        {

        }


        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword =tbSearch.Text.ToString();
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
    }
}
