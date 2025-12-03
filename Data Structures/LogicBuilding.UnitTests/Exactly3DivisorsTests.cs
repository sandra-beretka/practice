using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.UnitTests
{
    [TestClass]
    public class Exactly3DivisorsTests
    {
        [TestMethod]
        [DataRow(16, 2)]
        [DataRow(100, 4)]

        public void Exactly3Divisors_ByParameters_ReturnsTheExpectedValue(int n, int expected)
        {
            // Act
            int actual = Exactly3Divisors.CountExactlz3Divisors(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
