using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.UnitTests
{
    [TestClass]
    public class PowerofNumbersTests
    {
        [TestMethod]
        [DataRow(1,1, true)]
        [DataRow(10, 1, true)]
        [DataRow(10, 1000, true)]
        [DataRow(10, 1001, false)]

        public void PowerofNumbers_ByParameters_ReturnsTheExpectedValue(int x, int y, bool expected)
        {
            // Act
            bool actual = PowerofNumers.IsPower(x,y);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
