using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.UnitTests
{
    [TestClass]
    public class DecimaltoBinaryTests
    {
        [TestMethod]
        [DataRow(12, "1100")]
        [DataRow(33, "100001")]

        public void DecimaltoBinarz_ByParameters_ReturnsTheExpectedValue(int n, string expected)
        {
            // Act
            string actual = DecimaltoBinary.DectoBinConv(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
