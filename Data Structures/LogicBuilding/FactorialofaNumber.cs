using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class FactorialofaNumber
    {
        public static int Factorial(int n)
        {
            int fact = 1;

            if (n < 0)
            {
                throw new InvalidOperationException();
            }

            if (n == 1)
            {
                return fact;
            }

            for (int i = 2; i <= n; i++)
            {
                fact = fact * i;
            }

            return fact;
        }
    }
}
