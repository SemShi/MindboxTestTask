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
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="name"></param>
        public LineModel(Point p1, Point p2, string? name = null) : base(new Point[] {p1, p2}, name) { }

        public override double GetSquare()
        {
            return 0;
        }
    }
}
