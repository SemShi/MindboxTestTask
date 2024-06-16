using System.Drawing;
using GeometryLibrary.Figures.Base;

namespace GeometryLibrary.Figures
{
    /// <summary>
    /// Круг.
    /// </summary>
    public class CircleModel : FigureBase
    {
        /// <summary>
        /// Конструктор фигуры. Положение и радиус задаются двумя точками.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="name"></param>
        public CircleModel(Point p1, Point p2, string? name = null) : base(new Point[] { p1, p2 }, name)
        {

        }

        public override double GetSquare()
        {
            return Math.Round(Math.PI * Math.Pow(GetLineLength(Points[0], Points[1]), 2), 2);
        }
    }
}
