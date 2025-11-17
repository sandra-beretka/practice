using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.UnitTests
{
    [TestClass]
    public class ReverseNumberTests
    {
        [TestMethod]
        [DataRow(33, 33)]
        [DataRow(23, 32)]
        [DataRow(0, 0)]
        [DataRow(231, 132)]
        [DataRow(200, 2)]
        [DataRow(12345, 54321)]

        public void ReverseNumber_ByParameters_ReturnsTheExpectedValue(int n, int expected)
        {
            // Act
            int actual = ReverseNumber.ReverseDigitsofaNumber(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
