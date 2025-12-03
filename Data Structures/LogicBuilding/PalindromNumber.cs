using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class PalindromNumber
    {
        public static int CreatePalindrom(int n) 
        {
            int palindrom = 0;
            int temp = n;
            int rem = 0;

            while (temp > 0) 
            {
                rem = temp % 10;
                palindrom = palindrom * 10 + rem;
                temp= temp / 10;
            }

            return palindrom;        
        }

        public static bool CheckPalindrom(int n)
        { 
            int palindrom=CreatePalindrom(n);
            return palindrom == n;        
        }
    }
}
