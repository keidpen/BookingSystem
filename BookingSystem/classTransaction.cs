using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    class classTransaction
    {
        private static double TotalAmmount = 0, Cash = 0, Change;
        private static String ORNO = "", Date="", Name="";


        public classTransaction()
        {

        }

        public void ResetData()
        {
            TotalAmmount = 0;
            ORNO = "";
            Date = "";
            Name = "";
            Cash = 0;
            Change = 0;
        }

        public void setTotalAmmount(double totalAmmount )
        {
            TotalAmmount = totalAmmount;
        }

        public void setORNO(String ORno)
        {
            ORNO = ORno;
        }

        public void setDate(String date)
        {
            Date = date;
        }
        public void setCash(double cash)
        {
            Cash = cash;
        }
        public void setChange(double change)
        {
            Change = change;
        }
        public void setName(String name)
        {
            Name = name;
        }

        public double getTotalAmmount { get { return TotalAmmount; } }
        public String getORNO { get { return ORNO; } }
        public String getDate { get { return Date; } }
        public String getName { get { return Name; } }
        public double getCash{ get { return Cash; } }
        public double getChange{ get { return Change; } }

    }
}
