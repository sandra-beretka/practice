using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class SquareRootofInteger
    {
        public static int FloorSquareRoot(int n)
        {
            int lo = 1;
            int hi = n;
            int res = 1;

            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;

                if (mid * mid <= n)
                {
                    res = mid;
                    lo = mid + 1;
                }

                else
                {
                    hi = mid - 1;
                }
            }
            return res;
        }
    }
}
