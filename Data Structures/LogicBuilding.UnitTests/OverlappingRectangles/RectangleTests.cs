namespace LogicBuilding.OverlappingRectangles.UnitTests
{
    [TestClass]
    public class RectangleTests
    {
        private readonly Point p1 = new Point(0, 0);
        private readonly Point p2 = new Point(5, 5);
        private readonly Point p3 = new Point(2, 7);
        private readonly Point p4 = new Point(3, 10);

        [TestMethod]
        public void MyTestMethod()
        {
            // Arrange
            Rectangle r1 = new Rectangle(p1, p2);
            Rectangle r2 = new Rectangle(p3, p4);

            // Act
            bool actual = r1.Overlaps(r2);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void MyTestMethod2()
        {
            // Arrange
            Rectangle r1 = new Rectangle(p1, p4);
            Rectangle r2 = new Rectangle(p3, p2);

            // Act
            bool actual = r1.Overlaps(r2);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}
