using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.UnitTests
{
    [TestClass]
    public class PalindromNumberTests
    {
        [TestMethod]
        [DataRow(12321, true)]
        [DataRow(1234, false)]
        [DataRow(5445, true)]

        public void Palindrom_ByParameters_ReturnsTheExpectedValue(int n, bool expected)
        {
            // Act
            bool actual = PalindromNumber.CheckPalindrom(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
