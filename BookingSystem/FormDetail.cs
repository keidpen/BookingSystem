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
    public partial class FormDetail : Form
    {
        public FormDetail()
        {
            InitializeComponent();
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            //RetrievePrices();
            //InsertBtn();
            CreateColumn();
        }

        List<int> seatNo = new List<int>();
        public void GetData(List<string> seatNo, String Date, String screen, String SelSchedTime)
        {
            foreach (string seat in seatNo)
            {
                if (seat != null)
                {
                    //newSeatNo += " " + seat + ",";
                    this.seatNo.Add(int.Parse(seat));
                }
            }

            //this.SelSchedTime = SelSchedTime;
            //lblDate.Text = "Date: " + Date;
            //lblSeatNo.Text = "Seat No: " + newSeatNo;

            //newDate = Date;
            //newScreen = screen;
        }

        double PriceA = 0, PriceB = 0, PriceC = 0, PriceD = 0, PriceE = 0, PriceF = 0, PriceG = 0;
        double totalA = 0, totalB = 0, totalC = 0, totalD = 0, totalE = 0, totalF = 0, totalG = 0;
        String strSeatNoA, strSeatNoB, strSeatNoC, strSeatNoD, strSeatNoE, strSeatNoF, strSeatNoG;
        void CreateColumn()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Category.";
            dataGridView1.Columns[1].Name = "Seat No.";
            dataGridView1.Columns[2].Name = "Price";
            dataGridView1.Columns[3].Name = "Quantity";
            dataGridView1.Columns[4].Name = "Ammount";

            classRetrieveSeatCatPrice r = new classRetrieveSeatCatPrice();
            PriceA = r.CatSeat_A;
            PriceB = r.CatSeat_B;
            PriceC = r.CatSeat_C;
            PriceD = r.CatSeat_D;
            PriceE = r.CatSeat_E;
            PriceF = r.CatSeat_F;
            PriceG = r.CatSeat_G;

            for (int i = 1; i <= 308; i++)
            {
                if (seatNo.Contains(i))
                {
                    if (i >= 1 && i <= 56)
                    {
                        strSeatNoA += i + ", ";
                        intQtyA++;
                    }
                    else if ((i >= 57 && i <= 65) || (i >= 85 && i <= 93) || (i >= 113 && i <= 121))
                    {
                        strSeatNoB += i + ", ";
                        intQtyB++;
                    }
                    else if ((i >= 66 && i <= 75) || (i >= 93 && i <= 103) || (i >= 122 && i <= 131))
                    {
                        strSeatNoC += i + ", ";
                        intQtyC++;
                    }
                    else if ((i >= 76 && i <= 84) || (i >= 104 && i <= 112) || (i >= 132 && i <= 140))
                    {
                        strSeatNoD += i + ", ";
                        intQtyD++;
                    }
                    else if ((i >= 141 && i <= 154) || (i >= 169 && i <= 182) || (i >= 197 && i <= 210))
                    {
                        strSeatNoE += i + ", ";
                        intQtyE++;
                    }
                    else if ((i >= 155 && i <= 168) || (i >= 183 && i <= 196) || (i >= 197 && i <= 210))
                    {
                        strSeatNoF += i + ", ";
                        intQtyF++;
                    }
                    else if (i >= 225 && i <= 308)
                    {
                        strSeatNoG += i + ", ";
                        intQtyG++;
                    }

                }
            }


            totalA = intQtyA * PriceA;
            totalB = intQtyB * PriceB;
            totalC = intQtyC * PriceC;
            totalD = intQtyD * PriceD;
            totalE = intQtyE * PriceE;
            totalF = intQtyF * PriceF;
            totalG = intQtyG * PriceG;

            lblTotalAm.Text = (totalA + totalB + totalC + totalD + totalE + totalF + totalG).ToString();

            if (totalA >= 1)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = "A";
                row.Cells[1].Value = strSeatNoA;
                row.Cells[2].Value = PriceA;
                row.Cells[3].Value = intQtyA;
                row.Cells[4].Value = totalA;
                dataGridView1.Rows.Add(row);

            }
            if (totalB >= 1)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = "B";
                row.Cells[1].Value = strSeatNoB;
                row.Cells[2].Value = PriceB;
                row.Cells[3].Value = intQtyB;
                row.Cells[4].Value = totalB;
                dataGridView1.Rows.Add(row);

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

            }
        }



        void RetrievePrices()
        {
            classRetrieveSeatCatPrice r = new classRetrieveSeatCatPrice();
            lblPriceA.Text = r.CatSeat_A.ToString();
            PriceA = r.CatSeat_A;
            lblPriceB.Text = r.CatSeat_B.ToString();
            PriceB = r.CatSeat_B;
            lblPriceC.Text = r.CatSeat_C.ToString();
            PriceC = r.CatSeat_C;
            lblPriceD.Text = r.CatSeat_D.ToString();
            PriceD = r.CatSeat_D;
            lblPriceE.Text = r.CatSeat_E.ToString();
            PriceE = r.CatSeat_E;
            lblPriceF.Text = r.CatSeat_F.ToString();
            PriceF = r.CatSeat_F;
            lblPriceG.Text = r.CatSeat_G.ToString();
            PriceG = r.CatSeat_G;
        }

        int intQtyA = 0, intQtyB = 0, intQtyC = 0, intQtyD = 0, intQtyE = 0, intQtyF = 0, intQtyG = 0;

        void InsertBtn()
        {
            for (int i = 1; i <= 308; i++)
            {
                if (seatNo.Contains(i))
                {
                    Button btnseats = new Button();
                    btnseats.Text = i.ToString();
                    btnseats.Size = new Size(40, 40);

                    if (i >= 1 && i <= 56)
                    {
                        MessageBox.Show("A");
                        flpCatA.Controls.Add(btnseats);
                        intQtyA++;
                    }
                    else if ((i >= 57 && i <= 65) || (i >= 85 && i <= 93) || (i >= 113 && i <= 121))
                    {
                        MessageBox.Show("B");
                        flpCatB.Controls.Add(btnseats);
                        intQtyB++;
                    }
                    else if ((i >= 66 && i <= 75) || (i >= 93 && i <= 103) || (i >= 122 && i <= 131))
                    {
                        MessageBox.Show("C");
                        flpCatC.Controls.Add(btnseats);
                        intQtyC++;
                    }
                    else if ((i >= 76 && i <= 84) || (i >= 104 && i <= 112) || (i >= 132 && i <= 140))
                    {
                        MessageBox.Show("D");
                        flpCatD.Controls.Add(btnseats);
                        intQtyD++;
                    }
                    else if ((i >= 141 && i <= 154) || (i >= 169 && i <= 182) || (i >= 197 && i <= 210))
                    {
                        MessageBox.Show("E");
                        flpCatE.Controls.Add(btnseats);
                        intQtyE++;
                    }
                    else if ((i >= 155 && i <= 168) || (i >= 183 && i <= 196) || (i >= 197 && i <= 210))
                    {
                        MessageBox.Show("F");
                        flpCatF.Controls.Add(btnseats);
                        intQtyF++;
                    }
                    else if (i >= 225 && i <= 308)
                    {
                        MessageBox.Show("G");
                        flpCatG.Controls.Add(btnseats);
                        intQtyG++;
                    }
                    double totalA = 0, totalB = 0, totalC = 0, totalD = 0, totalE = 0, totalF = 0, totalG = 0;

                    lblQtyA.Text = intQtyA.ToString();
                    totalA = intQtyA * PriceA;
                    lblAm_A.Text = totalA.ToString();

                    lblQtyB.Text = intQtyB.ToString();
                    totalB = intQtyB * PriceB;
                    lblAm_B.Text = totalB.ToString();

                    lblQtyC.Text = intQtyC.ToString();
                    totalC = intQtyC * PriceC;
                    lblAm_C.Text = totalC.ToString();

                    lblQtyD.Text = intQtyD.ToString();
                    totalD = intQtyD * PriceD;
                    lblAm_D.Text = totalD.ToString();

                    lblQtyE.Text = intQtyE.ToString();
                    totalE = intQtyE * PriceE;
                    lblAm_E.Text = totalE.ToString();

                    lblQtyF.Text = intQtyF.ToString();
                    totalF = intQtyF * PriceF;
                    lblAm_F.Text = totalF.ToString();

                    lblQtyG.Text = intQtyG.ToString();
                    totalG = intQtyG * PriceG;
                    lblAm_G.Text = totalG.ToString();

                    lblTotalAm.Text = (totalA + totalB + totalC + totalD + totalE + totalF + totalG).ToString();
                    

                }
            }
        }
    }
}
