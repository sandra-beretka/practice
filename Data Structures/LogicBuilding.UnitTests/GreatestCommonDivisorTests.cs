using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.UnitTests
{
    [TestClass]
    public class GreatestCommonDivisorTests
    {
        [TestMethod]
        [DataRow(20, 28, 4)]
        [DataRow(60, 36, 12)]

        public void GreatestCommonDivisor_ByParameters_ReturnsTheExpectedValue(int a, int b, int expected)
        {
            // Act
            int actual = GreatestCommonDivisor.GCD(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
