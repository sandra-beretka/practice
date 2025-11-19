namespace LogicBuilding.OverlappingRectangles
{
    public struct Point
    {
        private readonly int x;
        private readonly int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public bool Below(Point other)
        {
            return other.x < x;
        }

        public bool RightTo(Point other)
        {
            return other.y < y;
        }
    }
}
