using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.UnitTests
{
    [TestClass]
    public class SquareRootofIntegerTests
    {
        [TestMethod]
        [DataRow(11, 3)]
        [DataRow(4, 2)]

        public void SquareRoot_ByParameters_ReturnsTheExpectedValue(int n, int expected)
        {
            // Act
            int actual = SquareRootofInteger.FloorSquareRoot(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
