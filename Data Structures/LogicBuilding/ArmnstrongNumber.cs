using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class ArmnstrongNumber
    {
        public static int Lengtofn(int n)
        {
            int t = 0;
            while (n != 0)
            {
                t++;
                n /= 10;
            }
            return t;
        }
        public static int CreateArmnstrongNumber(int n)
        {
            int an = 0;
            int rem = 0;
            int t=Lengtofn(n);
            while (n != 0)
            {
                rem = n % 10;
                an = an + (int)Math.Pow(rem, t);
                n /= 10;
            }
            return an;
        }
        public static bool CheckArmnstrongNumber(int n)
        {
            if (n <= 0)
            {
                throw new InvalidOperationException();
            }

           int an=CreateArmnstrongNumber(n);

            //CheckThenumbern
            return an == n;
        }
    }
}
