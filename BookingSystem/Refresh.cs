using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    
    class Refresh
    {
        public static int refresh = 0;
       
        public void GetRefreshFrame(int r)
        {
            refresh = r;
        }
        public int SetRefreshFrame()
        {
            return refresh;
        }
    }
}
