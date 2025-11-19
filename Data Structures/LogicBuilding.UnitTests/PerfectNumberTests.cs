using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.UnitTests
{
    [TestClass]
    public class PerfectNumberTests
    {
        [TestMethod]
        [DataRow(15, false)]
        [DataRow(6, true)]

        public void PerfectNumber_ByParameters_ReturnsTheExpectedValue(int n, bool expected)
        {
            // Act
            bool actual = PerfectNumber.isPerfect(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
