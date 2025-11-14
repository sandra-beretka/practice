using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class ArithmeticSeries
    {
        public static int ArithmeticSeriesnthterm(int a1, int a2, int n)
        {
            return (a1 + (n - 1) * (a2 - a1));
        }
    }
}
