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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            btnSchedArray();
        }

        int x = 10, y = 10,z=7;


        public void btnSchedArray()
        {
            for (int i = 1; i<=28 ;i++)
            {
                Button btnSched = new Button();
                btnSched.Size = new Size(160, 125);
                btnSched.Location = new System.Drawing.Point(x, y);
                btnSched.Text = i.ToString();
                btnSched.BackColor = Color.YellowGreen;
                btnSched.Click += btnSched_Click;
                pnlSched.Controls.Add(btnSched);

                if (i==z)
                {
                    x = 10;
                    y += 133;
                    z += 7;
                }
                else
                {
                    x += 164;
                }
            }

        }

        public void btnSched_Click(object sender, EventArgs e)
        {
            Button btnSched = (Button)sender;
            MessageBox.Show("Hello");
        }

    }
}
