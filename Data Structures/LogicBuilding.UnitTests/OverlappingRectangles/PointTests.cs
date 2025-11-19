using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicBuilding.OverlappingRectangles.UnitTests
{
    [TestClass]
    public class PointTests
    {
        private readonly Point upperLeft = new Point(0, 0);
        private readonly Point bottomRight = new Point(5, 5);

        [TestMethod]
        public void Below_FiveIsBelowZero_ReturnsTrue()
        {
            // Act
            bool actual = bottomRight.Below(upperLeft);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void RightTo_FiveIsRightToZero_ReturnsTrue()
        {
            // Act
            bool actual = bottomRight.RightTo(upperLeft);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}
