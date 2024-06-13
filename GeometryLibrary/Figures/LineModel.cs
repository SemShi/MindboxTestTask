using GeometryLibrary.Figures.Base;
using System.Drawing;

namespace GeometryLibrary.Figures
{
    /// <summary>
    /// Линия.
    /// </summary>
    public class LineModel : FigureBase
    {
        /// <summary>
        /// Конструктор фигуры. Положение здается двумя точками.
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        public LineModel(Point point1, Point point2)
        {
            Points.Add(point1);
            Points.Add(point2);
        }

        public override double GetSquare()
        {
            return 0;
        }
    }
}
