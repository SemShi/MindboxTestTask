using GeometryLibrary.Figures.Base;
using System.Drawing;

namespace GeometryLibrary.Figures
{
    public class TriangleModel : FigureBase
    {
        /// <summary>
        /// Конструктор фигуры. Положение здается тремя точками.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <param name="name"></param>
        public TriangleModel(Point p1, Point p2, Point p3, string? name = null) : base(new Point[] { p1, p2, p3 }, name)
        {

        }

        public override double GetSquare()
        {
            Point point1 = Points[0];
            Point point2 = Points[1];
            Point point3 = Points[2];
            return 0.5 * Math.Abs(point1.X * (point2.Y-point3.Y) + point2.X * (point3.Y - point1.Y) + point3.X * (point1.Y - point2.Y));
        }
    }
}
