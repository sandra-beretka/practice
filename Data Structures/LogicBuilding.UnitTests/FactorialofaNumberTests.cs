using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.UnitTests
{
    [TestClass]
    public class FactorialofaNumberTests
    {
        [TestMethod]
        public void FactorialofaNumber_Fornegativenumber_ThrowsException()
        {
            // Act + Assert
            Assert.ThrowsException<InvalidOperationException>(InvalidCall);
        }
        private void InvalidCall()
        {
            FactorialofaNumber.Factorial(-3);
        }

        [TestMethod]
        [DataRow(2, 2)]
        [DataRow(3, 6)]
        [DataRow(4, 24)]
        public void FactorialofaNumber_ByParameters_ReturnsTheExpectedValue(int n, int expected)
        {
            // Act
            int actual = FactorialofaNumber.Factorial(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
