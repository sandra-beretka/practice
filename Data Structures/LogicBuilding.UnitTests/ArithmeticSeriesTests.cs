using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.UnitTests
{
    [TestClass]
    public class ArithmeticSeriesTests
    {
        [TestMethod]
        [DataRow(2, 3, 4, 5)]
        [DataRow(1, 3, 10, 19)]

        public void ArithmeticSeries_ByParameters_ReturnsTheExpectedValue(int a1, int a2, int n, int expected)
        {
            // Act
            int actual = ArithmeticSeries.ArithmeticSeriesnthterm(a1,a2,n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
