using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class GreatestCommonDivisor
    {
        public static int GCD(int a, int b) 
        {
            if (a == 0) return b;

            if (b == 0) return a;

            if (a == b) return a;

            if (a > b)
                return GCD(a - b, b);

            return GCD(a, b - a);
        }
    }
}
