using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.UnitTests
{
    [TestClass]
    public class DistanceBetweenTwoPointsTests
    {
        [TestMethod]
        [DataRow(3,4,7,7,5)]
        [DataRow(3,4,4,3, 1.4142135623730951)]

        public void DistanceBetweenTwoPoints_ByParameters_ReturnsTheExpectedValue(int x1, int x2, int y1, int y2, double expected)
        {
            // Act
            double actual = DistanceBetweenTwoPoints.DistanceBetweenPoints(x1,x2,y1, y2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
