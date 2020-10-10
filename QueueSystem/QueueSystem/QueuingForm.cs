using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueSystem
{
    public partial class QueuingForm : Form
    {

        private CashierClass cashier;
        

        public QueuingForm()
        {
            cashier = new CashierClass();

            CashierWindowQueueForm form = new CashierWindowQueueForm();
            form.Visible = true;

            NextQueueForm form2 = new NextQueueForm();
            form2.Visible = true;

            InitializeComponent();
        }


        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGenerateNumber("P- ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }




        private void InputQueue_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
