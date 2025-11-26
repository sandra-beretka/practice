using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class Fibonacci
    {
        public static int NthFibonacciNumber(int n) 
        {
            
            if (n <= 1)
            {
                return n;
            }
            else 
            {
                return NthFibonacciNumber(n - 1) + NthFibonacciNumber(n - 2);
            }  
            
        }
    }
}
