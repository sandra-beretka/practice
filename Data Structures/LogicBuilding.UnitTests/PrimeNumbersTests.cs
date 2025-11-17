using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.UnitTests
{
    [TestClass]
    public class PrimeNumbersTests
    {

        [TestMethod]
        [DataRow(0, false)]
        [DataRow(-1, false)]
        [DataRow(2, true)]
        [DataRow(3, true)]
        [DataRow(4, false)]
        [DataRow(5, true)]
        [DataRow(6, false)]
        [DataRow(7, true)]
        [DataRow(8, false)]
        [DataRow(9, false)]

        public void PrimeNumbers_ByParameters_ReturnsTheExpectedValue(int n, bool expected)
        {
            // Act
            bool actual = PrimeNumbers.IsPrime(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
