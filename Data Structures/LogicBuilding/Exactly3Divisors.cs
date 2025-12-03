using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class Exactly3Divisors
    {
        public static int CountExactlz3Divisors(int n) 
        {
            int counter = 0;

            for (int i = 2; i <= n; i++) 
            {
                if (PrimeNumbers.IsPrime(i)) 
                {
                    if (i * i <= n) 
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }
    }
}
