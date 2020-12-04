using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BookingSystem
{
    public partial class frmOrderDetail : Form
    {
        public frmOrderDetail()
        {
            InitializeComponent();
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            classOrderDetail c = new classOrderDetail();

            seatNo = c.getseatNo;
            lblDate.Text = c.getDate;
            lblScreen.Text = c.getScreen;
            lblTime.Text = c.getTime;

            CreateColumn();
            
        }

        int intQtyA = 0, intQtyB = 0, intQtyC = 0, intQtyD = 0, intQtyE = 0, intQtyF = 0, intQtyG = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Timer time = new Timer();
        private void btnPayment_Click(object sender, EventArgs e)
        {

            using (frmPaymentCash frm = new frmPaymentCash())
            {
                time.Interval = 1000;
                time.Tick += new EventHandler(close);
                time.Start();
                frm.ShowDialog();
            }
        }

        public void close(object sender, EventArgs e)
        {
            Refresh r = new Refresh();
            
            if (r.SetRefreshFrame() == 0)
            {
                time.Dispose();
                this.Close();
            }
        }

        List<String> seatNo = new List<String>();
        //List<int> seatNo = new List<int>();
        double PriceA = 0, PriceB = 0, PriceC = 0, PriceD = 0, PriceE = 0, PriceF = 0, PriceG = 0;
        double totalA = 0, totalB = 0, totalC = 0, totalD = 0, totalE = 0, totalF = 0, totalG = 0;
        String strSeatNoA, strSeatNoB, strSeatNoC, strSeatNoD, strSeatNoE, strSeatNoF, strSeatNoG;


       //public void GetData(List<string> seatNo, String Date, String screen, String SelSchedTime)
       // {
       //     foreach (string seat in seatNo)
       //     {
       //         if (seat != null)
       //         {
       //             //newSeatNo += " " + seat + ",";
       //             this.seatNo.Add(int.Parse(seat));
       //         }
       //     }

       //     lblDate.Text = Date;
       //     lblScreen.Text = screen;
       //     lblTime.Text = SelSchedTime;

       //     //this.SelSchedTime = SelSchedTime;
       //     //lblSeatNo.Text = "Seat No: " + newSeatNo;

       //     //newDate = Date;
       //     //newScreen = screen;
       // }

        void CreateColumn()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Category";
            dataGridView1.Columns[1].Name = "Seat No.";
            dataGridView1.Columns[2].Name = "Price";
            dataGridView1.Columns[3].Name = "Quantity";
            dataGridView1.Columns[4].Name = "Ammount";

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Regular);

            classRetrieveSeatCatPrice r = new classRetrieveSeatCatPrice();
            PriceA = r.CatSeat_A;
            PriceB = r.CatSeat_B;
            PriceC = r.CatSeat_C;
            PriceD = r.CatSeat_D;
            PriceE = r.CatSeat_E;
            PriceF = r.CatSeat_F;
            PriceG = r.CatSeat_G;

            for (int i=0; i <seatNo.Count ;i++) 
            //for (int i = 1; i <= 308; i++)
            {
                if (seatNo[i].Contains("A")){
                    strSeatNoA += seatNo[i].ToString() + ", ";
                    intQtyA++;
                }
                else if (seatNo[i].Contains("B")){
                    strSeatNoB += seatNo[i].ToString() + ", ";
                    intQtyB++;
                }
                else if (seatNo[i].Contains("C")){
                    strSeatNoC += seatNo[i].ToString() + ", ";
                    intQtyC++;
                }
                else if (seatNo[i].Contains("D")){
                    strSeatNoD += seatNo[i].ToString() + ", ";
                    intQtyD++;
                }
                else if (seatNo[i].Contains("E")){
                    strSeatNoE += seatNo[i].ToString() + ", ";
                    intQtyE++;
                }
                else if (seatNo[i].Contains("F")){
                    strSeatNoF += seatNo[i].ToString() + ", ";
                    intQtyF++;
                }
                else if (seatNo[i].Contains("G")){
                    strSeatNoG += seatNo[i].ToString() + ", ";
                    intQtyG++;
                }
                else
                {
                    MessageBox.Show(seatNo[i]);
                }



                //if (seatNo.Contains(i))
                //{
                //    if (i >= 1 && i <= 56)
                //    {
                //        strSeatNoA += i + ", ";
                //        intQtyA++;
                //    }
                //    else if ((i >= 57 && i <= 65) || (i >= 85 && i <= 93) || (i >= 113 && i <= 121))
                //    {
                //        strSeatNoB += i + ", ";
                //        intQtyB++;
                //    }
                //    else if ((i >= 66 && i <= 75) || (i >= 93 && i <= 103) || (i >= 122 && i <= 131))
                //    {
                //        strSeatNoC += i + ", ";
                //        intQtyC++;
                //    }
                //    else if ((i >= 76 && i <= 84) || (i >= 104 && i <= 112) || (i >= 132 && i <= 140))
                //    {
                //        strSeatNoD += i + ", ";
                //        intQtyD++;
                //    }
                //    else if ((i >= 141 && i <= 154) || (i >= 169 && i <= 182) || (i >= 197 && i <= 210))
                //    {
                //        strSeatNoE += i + ", ";
                //        intQtyE++;
                //    }
                //    else if ((i >= 155 && i <= 168) || (i >= 183 && i <= 196) || (i >= 197 && i <= 210))
                //    {
                //        strSeatNoF += i + ", ";
                //        intQtyF++;
                //    }
                //    else if (i >= 225 && i <= 308)
                //    {
                //        strSeatNoG += i + ", ";
                //        intQtyG++;
                //    }
                //
                //}
            }


            totalA = intQtyA * PriceA;
            totalB = intQtyB * PriceB;
            totalC = intQtyC * PriceC;
            totalD = intQtyD * PriceD;
            totalE = intQtyE * PriceE;
            totalF = intQtyF * PriceF;
            totalG = intQtyG * PriceG;

            double SubTotal = totalA + totalB + totalC + totalD + totalE + totalF + totalG;


            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Category");
            dt.Columns.Add("Seat No", typeof(string));
            dt.Columns.Add("Price", typeof(string));
            dt.Columns.Add("Quantity", typeof(string));
            dt.Columns.Add("Ammount", typeof(string));

            if (totalA >= 1){
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = "A";
                row.Cells[1].Value = strSeatNoA;
                row.Cells[2].Value = PriceA;
                row.Cells[3].Value = intQtyA;
                row.Cells[4].Value = totalA;
                dataGridView1.Rows.Add(row);

                dt.Rows.Add("A", strSeatNoA, PriceA, intQtyA, totalA);
            }if (totalB >= 1){
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = "B";
                row.Cells[1].Value = strSeatNoB;
                row.Cells[2].Value = PriceB;
                row.Cells[3].Value = intQtyB;
                row.Cells[4].Value = totalB;
                dataGridView1.Rows.Add(row);

                dt.Rows.Add("B", strSeatNoB, PriceB, intQtyB, totalB);
            }
            if (totalC >= 1)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = "C";
                row.Cells[1].Value = strSeatNoC;
                row.Cells[2].Value = PriceC;
                row.Cells[3].Value = intQtyC;
                row.Cells[4].Value = totalC;
                dataGridView1.Rows.Add(row);

            }
            if (totalD >= 1)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = "D";
                row.Cells[1].Value = strSeatNoD;
                row.Cells[2].Value = PriceD;
                row.Cells[3].Value = intQtyD;
                row.Cells[4].Value = totalD;
                dataGridView1.Rows.Add(row);

                dt.Rows.Add("D", strSeatNoD, PriceD, intQtyD, totalD);
            }
            if (totalE >= 1)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = "E";
                row.Cells[1].Value = strSeatNoE;
                row.Cells[2].Value = PriceE;
                row.Cells[3].Value = intQtyE;
                row.Cells[4].Value = totalE;
                dataGridView1.Rows.Add(row);

                dt.Rows.Add("E", strSeatNoE, PriceE, intQtyE, totalE);
            }
            if (totalF >= 1)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = "F";
                row.Cells[1].Value = strSeatNoF;
                row.Cells[2].Value = PriceF;
                row.Cells[3].Value = intQtyF;
                row.Cells[4].Value = totalF;
                dataGridView1.Rows.Add(row);

                dt.Rows.Add("F", strSeatNoF, PriceF, intQtyF, totalF);
            }
            if (totalG >= 1)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = "G";
                row.Cells[1].Value = strSeatNoG;
                row.Cells[2].Value = PriceG;
                row.Cells[3].Value = intQtyG;
                row.Cells[4].Value = totalG;
                dataGridView1.Rows.Add(row);

                dt.Rows.Add("G",strSeatNoG,PriceG,intQtyG,totalG);
            }

            ds.Tables.Add(dt);
            ds.WriteXmlSchema("OrderDetails.xml");

            //FormViewerTesting cd = new FormViewerTesting();
            //cd.Show();

            DataGridViewRow Divider = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            Divider.DividerHeight = 1;
            dataGridView1.Rows.Add(Divider);

            DataGridViewRow rowSubTotal = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            rowSubTotal.Cells[3].Value = "SubTotal : ";
            rowSubTotal.Cells[4].Value = SubTotal.ToString();
            rowSubTotal.Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Rows.Add(rowSubTotal);

            DataGridViewRow rowTax = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            rowTax.Cells[3].Value = "Add VAT(12%): ";
            rowTax.Cells[4].Value = String.Format("{0:0.00}", SubTotal * .12);
            rowTax.Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            rowTax.DividerHeight = 2;
            dataGridView1.Rows.Add(rowTax);

            DataGridViewRow rowTotalAmmount = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            rowTotalAmmount.DefaultCellStyle.Font = new Font("Tahoma", 14, FontStyle.Bold);
            rowTotalAmmount.Cells[3].Value = "Total Ammount: ";
            double TotalAmmount = SubTotal * 1.12;
            rowTotalAmmount.Cells[4].Value = String.Format("{0:0.00}", TotalAmmount);
            rowTotalAmmount.Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Rows.Add(rowTotalAmmount);

            classTransaction c = new classTransaction();
            c.setTotalAmmount(TotalAmmount);

        }
    }
}
