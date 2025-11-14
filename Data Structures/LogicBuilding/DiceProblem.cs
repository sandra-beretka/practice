using System;

namespace LogicBuilding
{
    public class DiceProblem
    {
        public static int Dice(int n)
        {
            if (n > 6 || n < 1)
            {
                throw new InvalidOperationException();
            }

            return 7 - n;
        }
    }
}
