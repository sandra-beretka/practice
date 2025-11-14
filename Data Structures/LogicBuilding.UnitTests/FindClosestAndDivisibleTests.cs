using LogicBuilding;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LogicBuilding.UnitTests
{
    [TestClass]
    public sealed class FindClosestAndDivisibleTests
    {
        [TestMethod]
        public void Search_For17And0_ThrowsException()
        {
            // Act + Assert
            Assert.ThrowsException<InvalidOperationException>(InvalidCall);
        }

        private void InvalidCall()
        {
            FindClosestAndDivisible.Search(17, 0);
        }

        [TestMethod]
        public void Search_For17And5_Returns15()
        {
            // Arrange
            int expected = 15;
            int n = 17;
            int m = 5;

            // Act
            int actual = FindClosestAndDivisible.Search(n, m);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Search_For19And5_Returns20()
        {
            // Arrange
            int expected = 20;
            int n = 19;
            int m = 5;

            // Act
            int actual = FindClosestAndDivisible.Search(n, m);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Search_ForNegative17And5_Returns15()
        {
            // Arrange
            int expected = -15;
            int n = -17;
            int m = 5;

            // Act
            int actual = FindClosestAndDivisible.Search(n, m);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Search_ForNegative19And5_ReturnsNegative20()
        {
            // Arrange
            int expected = -20;
            int n = -19;
            int m = 5;

            // Act
            int actual = FindClosestAndDivisible.Search(n, m);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Search_ForNegative15And6_ReturnsNegative18()
        {
            // Arrange
            int expected = -18;
            int n = -15;
            int m = 6;

            // Act
            int actual = FindClosestAndDivisible.Search(n, m);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(17, 5, 15)]
        [DataRow(19, 5, 20)]
        [DataRow(-17, 5, -15)]
        [DataRow(-19, 5, -20)]
        [DataRow(15, 6, 18)]
        [DataRow(-15, 6, -18)]
        public void Search_ByParameters_ReturnsTheExpectedValue(int n, int m, int expected)
        {
            // Act
            int actual = FindClosestAndDivisible.Search(n, m);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
