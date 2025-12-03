using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.UnitTests
{
    [TestClass]
    public class ArmnstrongNumberTests
    {
        [TestMethod]
        [DataRow(153,true)]
        [DataRow(9474, true)]
        [DataRow(123, false)]

        public void ArmnstrongNumber_ByParameters_ReturnsTheExpectedValue(int n, bool expected)
        {
            // Act
            bool actual = ArmnstrongNumber.CheckArmnstrongNumber(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(-2)]
        public void ArmnstrongNumber_For0_ThrowsException(int n)
        {
            // Act + Assert
            Assert.ThrowsException<InvalidOperationException>(() => ArmnstrongNumber.CheckArmnstrongNumber(n));
        }
    }
}
