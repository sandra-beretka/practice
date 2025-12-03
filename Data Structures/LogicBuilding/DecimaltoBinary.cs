using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class DecimaltoBinary
    {
        public static string DectoBinConv(int n)
        {
            Stack<char> digits = new Stack<char>();

            while (n > 0)
            {
                int rem;
                n = Math.DivRem(n, 2, out rem);
                digits.Push(rem > 0 ? '1' : '0');
            }

            return new string(digits.ToArray());
        }
    }
}
