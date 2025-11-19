using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.UnitTests
{
    [TestClass]
    public class PairCubeCountTests
    {
        [TestMethod]
        [DataRow(9, 2)]
        [DataRow(28, 2)]
        [DataRow(27, 0)]
        public void PairCubeCount_ByParameters_ReturnsTheExpectedValue(int n, int expected)
        {
            // Act
            int actual = PairCubeCount.CubeCount(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
