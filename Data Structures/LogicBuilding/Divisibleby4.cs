using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class Divisibleby4
    {
        public static bool twodigitnumberdivisibleby4(int n)
        {
            if (n % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool nDivisibleby4 (int n)
        {
            int tdn = 0;
            if (n > -99 || n < 99)
            {
                return twodigitnumberdivisibleby4(n);
            }
            else 
            {
                for (int i = 1; i <= 2; i++) 
                {
                    tdn = tdn * 10 + n % 10;
                    n /= 10;
                }
                return twodigitnumberdivisibleby4(tdn);
            }
        }
    }
}
