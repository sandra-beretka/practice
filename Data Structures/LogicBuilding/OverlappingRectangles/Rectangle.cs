namespace LogicBuilding.OverlappingRectangles
{
    public sealed class Rectangle
    {
        private readonly Point ul;
        private readonly Point br;

        public Rectangle(Point ul, Point br)
        {
            this.ul = ul;
            this.br = br;
        }

        public Point UpperLeft
        {
            get { return ul; }
        }

        public Point BottomRight
        {
            get { return br; }
        }

        public bool Overlaps(Rectangle other)
        {
            return !RightOrBelow(other) && !other.RightOrBelow(this);
        }

        private bool RightOrBelow(Rectangle other)
        {
            return ul.Below(other.br) || ul.RightTo(other.br);
        }
    }
}
