using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.UnitTests
{
    [TestClass]
    public class Divisibleby4Tests
    {
        [TestMethod]
        [DataRow(1124, true)]
        [DataRow(4, true)]
        [DataRow(5, false)]
        [DataRow(589333862, false)]
        
        public void Divisibleby4_ByParameters_ReturnsTheExpectedValue(int n, bool expected)
        {
            // Act
            bool actual = Divisibleby4.nDivisibleby4(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
