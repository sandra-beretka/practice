using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.UnitTests
{

[TestClass]
    public class SumofDigitsTests
    {
        [TestMethod]
        [DataRow(33,6)]
        [DataRow(23,5)]
        [DataRow(0, 0)]
        [DataRow(159874, 34)]

        public void SumofDigits_ByParameters_ReturnsTheExpectedValue(int n, int expected)
        {
            // Act
            int actual = SumofDigits.SumofDigitsforn(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
