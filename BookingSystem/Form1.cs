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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }




        private void btnSignIn_Click(object sender, EventArgs e)
        {

            Database db = new Database();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM userfield WHERE Username = '"+tbUsername.Text+"' AND Password = '"+tbPassword.Text+"' AND Usertype = '"+cbUsertype.SelectedItem.ToString()+"' ", db.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            if (dt.Rows[0][0].ToString()=="1")
            {
                MessageBox.Show("Successfully Log-in");

                if (cbUsertype.SelectedItem.Equals("Admin"))
                {
                    //Form2 home = new Form2();
                    //home.LockBooking();
                    //home.Show();

                    frmMenu menu = new frmMenu();
                    menu.Show();
                    this.Hide();
                }
                else if (cbUsertype.SelectedItem.Equals("Employee"))
                {
                    //Form2 home = new Form2();
                    //home.LockMovie();
                    //home.Show();

                    frmMenu menu = new frmMenu();
                    menu.Show();
                    this.Hide();
                }


            }
            else
            {
                MessageBox.Show("Username and Password is Incorrect!");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 home = new Form2();
            home.Show();
            this.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Want to Exit the Program?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
