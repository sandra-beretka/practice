using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class PairCubeCount
    {
        public static int CubeCount(int n)
        {
            int count = 0;

            for (int i = 1; i <= Math.Cbrt(n); i++)
            {
                int cube = i * i * i;
                int diff = n - cube;
                if(diff==0)
                {
                    continue;
                }

                int cbrtDiff = (int) Math.Cbrt(diff);

                if (cbrtDiff * cbrtDiff * cbrtDiff == diff)
                { 
                    count++; 
                }
                                   
            }
            return count;
        }
    }
}
