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
    public partial class CashierWindowQueueForm : Form
    {

        public CashierWindowQueueForm()
        {
            InitializeComponent();

            Timer time = new Timer();
            time.Interval = 1000;
            time.Tick += new EventHandler(btnRefresh_Click);
            time.Start();
        }

        
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count<=0)
            {
                MessageBox.Show("The Queue is null.");
            }
            else
            {
                CashierClass.CashierQueue.Dequeue();
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
             DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(Queue<string> CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
                
            }
        }

    }
}
