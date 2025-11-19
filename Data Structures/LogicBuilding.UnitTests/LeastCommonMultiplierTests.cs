using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.UnitTests
{
    [TestClass]
    public class LeastCommonMultiplierTests
    {
        [TestMethod]
        [DataRow(10, 5, 10)]
        [DataRow(11, 5, 55)]

        public void LeastCommonMultiplier_ByParameters_ReturnsTheExpectedValue(int a, int b, int expected)
        {
            // Act
            int actual = LeastCommonMultiplier.LCM(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
