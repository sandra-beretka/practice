using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.Fractions.UnitTests
{
    [TestClass]
    public class AddTwoFractionsTests
    {
               
        [TestMethod]
        public void AddFractions_ForF1AndF2_ReturnsF3()
        {
            // Arrange
            Fraction expected = new Fraction(1, 2);
            Fraction F1 = new Fraction(1, 3);
            Fraction F2 = new Fraction(1, 6);

            // Act
            Fraction actual = AddTwoFractions.AddFractions(F1,F2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddFractions_Fordenominator0_1_ThrowsException()
        {
            // Act + Assert
            Assert.ThrowsException<InvalidOperationException>(InvalidCall1);
        }

        private Fraction F4 = new Fraction(1, 0);
        private Fraction F5 = new Fraction(1, 1);
        private void InvalidCall1()
        {
            AddTwoFractions.AddFractions(F4, F5);
        }

        [TestMethod]
        public void AddFractions_Fordenominator0_2_ThrowsException()
        {
            // Act + Assert
            Assert.ThrowsException<InvalidOperationException>(InvalidCall2);
        }

        private Fraction F6 = new Fraction(1, 0);
        private void InvalidCall2()
        {
            AddTwoFractions.AddFractions(F5, F6);
        }
    }
}
