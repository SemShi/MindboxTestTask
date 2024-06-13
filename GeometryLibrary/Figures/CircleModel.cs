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
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        public CircleModel(Point point1, Point point2)
        {
            Points.Add(point1);
            Points.Add(point2);
        }

        public override double GetSquare()
        {
            return Math.PI * Math.Pow(GetLineLength(Points[0], Points[1]), 2);
        }
    }
}
