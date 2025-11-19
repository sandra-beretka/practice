using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class LeastCommonMultiplier
    {
        public static int LCM(int a, int b) 
        {
            int x = 0;
            if (a == 0 || b == 0)
            {
                return x;
            }
            else 
            {
                int y = GreatestCommonDivisor.GCD(a, b);
                x = (a * b) / y;
                return x;
            }                       
        }
    }
}
