using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class SumofDigits
    {
        public static int SumofDigitsforn(int n)
        {
            int sum = 0;

            while (n != 0) 
            {
                int lastdigit = n % 10;
                sum = sum + lastdigit;
                n = n / 10;
            }

            return sum;
        }
    }
}
