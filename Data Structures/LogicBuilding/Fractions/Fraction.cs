using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.Fractions
{
    public struct Fraction
    {
        private int nominator;
        private int denominator;

        public Fraction()
        {
        }

        public Fraction(int nominator, int denominator)
        {
            this.nominator = nominator;
            this.denominator = denominator;
        }
        public int Nominator
        {
            get { return nominator; }
            set { nominator = value; }
        }

        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }

        public override string ToString()
        {
            return $"{nominator}/{denominator}";
        }
    }
}
