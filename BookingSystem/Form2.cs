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

        private void lblMovie_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lblSeats.Visible = true;
            lblCostumer.Visible = true;
            comboBox1.Visible = true;
            pnlBooking.Visible = true;
            dateTimePicker1.Visible = true;
            BtnSeatArray();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public void BtnSeatArray()
        {

            String date = DateTime.Now.ToString("MM-dd-yyyy");
            String screen = "Screen 2";

            Database db = new Database();

            date = dateTimePicker1.Value.Date.ToString("MM-dd-yyyy");
            screen = comboBox1.SelectedItem.ToString();
            MessageBox.Show(screen);
            MessageBox.Show(dateTimePicker1.Value.Date.ToString("MM-dd-yyyy"));

            int x = 10, y = 10, z = 18;


            for (int i = 1; i <= 144; i++)
            {
                Button btnSeats = new Button();
                btnSeats.Size = new Size(60, 50);
                btnSeats.Location = new System.Drawing.Point(x, y);
                btnSeats.Text = i.ToString();
                btnSeats.Font = new Font("Arial", 12, FontStyle.Bold);


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

                if ((i>=1 && i<=36) || (i>=109 && i<=144))
                {
                    x += 62;
                }
                else
                {
                    x += 60;
                }

                // Create new layer for btn
                if (i == z)
                {
                    x = 10;
                    y += 50;
                    z += 18;
                    
                    // Split chair per row
                    if (z == 54 || z == 90 || z == 126 )
                    {
                        y+=20;
                    }

                }


                // Split chair per column
                if (i == 42 || i == 60 || i == 48 || i ==66 )
                {
                    x += 20;
                }else if ( i == 81 || i == 99)
                {
                    x += 40;
                }

            }

        }

        public void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show("Fuck dont click me! "+ btn.Text, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (btn.BackColor == System.Drawing.Color.Red)
            {
                btn.BackColor = Color.Yellow;
            }
            else
            {
                btn.BackColor = Color.Red;
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlBooking.Controls.Clear();
            BtnSeatArray();
        }
    }
}
