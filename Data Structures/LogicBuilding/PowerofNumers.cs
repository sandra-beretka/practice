using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class PowerofNumers
    {
        public static bool IsPower(int x, int y)
        {
            if (x == 1)
                return (y == 1);

            
            int power = 1;
            while (power < y)
                power *= x;

            
            return (power == y);
        }
    }
}
