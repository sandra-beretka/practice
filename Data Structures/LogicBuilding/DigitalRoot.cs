using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class DigitalRoot
    {
        public static int SingleDigit(int n)
        {                      
            if (n == 0)
                return 0;
                        
            if (n % 9 == 0)
                return 9;

            return (n % 9);
        }
    }
}
