using System;

namespace LogicBuilding
{
    public static class FindClosestAndDivisible
    {
        public static int Search(int n, int m)
        {
            if (m == 0)
            {
                throw new InvalidOperationException();
            }

            int remainder = n % m;
            if (remainder == 0)
            {
                return n;
            }

            int delta = 0;
            if (remainder < 0)
            {
                delta = m + remainder;
                if (remainder > -delta)
                {
                    return n - remainder;
                }

                return n - delta;
            }

            delta = m - remainder;
            if (remainder < delta)
            {
                return n - remainder;
            }

            return n + delta;
        }
    }
}
