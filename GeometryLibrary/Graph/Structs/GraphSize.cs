using System.Drawing;

namespace GeometryLibrary.Graph.Structs
{
    public struct GraphSize
    {
        public Axis AxisX;
        public Axis AxisY;

        public bool IsPointInside(Point point)
        {
            if (point.X < AxisX.Min || point.X > AxisX.Max) return false;
            if (point.Y < AxisY.Min || point.Y > AxisY.Max) return false;
            return true;
        }
    }
}
