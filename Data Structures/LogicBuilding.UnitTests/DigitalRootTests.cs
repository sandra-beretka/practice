using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.UnitTests
{
    [TestClass]
    public class DigitalRootTests
    {
        [TestMethod]
        [DataRow(1234, 1)]
        [DataRow(5674, 4)]

        public void DigitalRoot_ByParameters_ReturnsTheExpectedValue(int n, int expected)
        {
            // Act
            int actual = DigitalRoot.SingleDigit(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
