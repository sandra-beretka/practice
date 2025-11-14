using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class DiceProblem
    {
        public static int Dice(int n)
        {
            if (n > 6 || n < 1)
            {
                throw new InvalidOperationException();
            }
            else
            {
                return 7 - n;
            }
        }
    }
}
