using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding.UnitTests
{
    [TestClass]
public class ValidTriangleTests
    {
        [TestMethod]
        [DataRow(3, 4, 5,true)]
        [DataRow(7, 10, 5, true)]
        [DataRow(1, 10, 12, false)]
        
        public void ValidTriangle_ByParameters_ReturnsTheExpectedValue(int a, int b, int c, bool expected)
        {
            // Act
            bool actual = ValidTriangle.CheckValidity(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidTriangle_Fornegativenumber_ThrowsException()
        {
            // Act + Assert
            Assert.ThrowsException<InvalidOperationException>(InvalidCall);
        }
        private void InvalidCall()
        {
            ValidTriangle.CheckValidity(-1, 4, 5);
        }
    }
}
