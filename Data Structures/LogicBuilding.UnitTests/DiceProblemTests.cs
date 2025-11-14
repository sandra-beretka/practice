using System;

namespace LogicBuilding.UnitTests
{
    [TestClass]
    public class DiceProblemTests
    {

        [TestMethod]
        [DataRow(1, 6)]
        [DataRow(2, 5)]
        [DataRow(3, 4)]
        [DataRow(4, 3)]
        [DataRow(5, 2)]
        [DataRow(6, 1)]
        public void Dice_ByParameters_ReturnsTheExpectedValue(int n, int expected)
        {
            // Act
            int actual = DiceProblem.Dice(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(7)]
        public void Dice_For0_ThrowsException(int n)
        {
            // Act + Assert
            Assert.ThrowsException<InvalidOperationException>(() => DiceProblem.Dice(n));
        }
    }
}
