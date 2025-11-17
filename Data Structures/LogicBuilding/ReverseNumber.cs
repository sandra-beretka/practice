using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class ReverseNumber
    {
        public static int ReverseDigitsofaNumber(int n) 
        {
            int reverse = 0;
            while (n > 0) 
            {
                reverse = reverse * 10 + n % 10;
                n = n / 10;            
            }
            return reverse;
        }

    }
}
