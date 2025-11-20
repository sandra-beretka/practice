using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.Fractions
{
    public class AddTwoFractions
    {
        public static Fraction AddFractions(Fraction a, Fraction b)
        {
            if (a.Denominator == 0 || b.Denominator ==  0)
            {
                throw new InvalidOperationException();
            }

            int gcd = GreatestCommonDivisor.GCD(a.Denominator, b.Denominator);
            int denominator = LeastCommonMultiplier.LCM(a.Denominator, b.Denominator);

            Fraction answer = new Fraction();
            answer.Denominator = denominator;
            answer.Nominator = (a.Nominator*b.Denominator / gcd) + (b.Nominator*a.Denominator / gcd);

            int simplificator = GreatestCommonDivisor.GCD(answer.Denominator, answer.Nominator);
            answer.Denominator = answer.Denominator / simplificator;
            answer.Nominator = answer.Nominator / simplificator;

            return answer;
        }
    }
}
