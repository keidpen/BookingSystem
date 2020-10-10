using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueSystem
{
    public partial class NextQueueForm : Form
    {
        public NextQueueForm()
        {
            InitializeComponent();

            Timer time = new Timer();
            time.Interval = 1000;
            time.Tick += new EventHandler(label1_Click);
            time.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count>0)
            {
                label1.Text = CashierClass.CashierQueue.Peek().ToString();
            }
            
        }

        private void NextQueueForm_Load(object sender, EventArgs e)
        {

        }
    }
}
