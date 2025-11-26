using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.UnitTests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        [DataRow(2, 1)]
        [DataRow(5, 5)]

        public void NthFibonacci_ByParameters_ReturnsTheExpectedValue(int n, int expected)
        {
            // Act
            int actual = Fibonacci.NthFibonacciNumber(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
