using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GeometryLibrary.Figures.Base
{
    public abstract class FigureBase
    {
        /// <summary>
        /// Имя фигуры.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Набор координат.
        /// </summary>
        public List<Point> Points { get; set; } = new List<Point>();

        protected FigureBase(IEnumerable<Point> points, string? name = null)
        {
            var doubles = points.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
            if (doubles.Any())
                throw new ArgumentException("Все точки должны быть уникальными.");

            Name = name ?? Guid.NewGuid().ToString();
            Points.AddRange(points);
        }

        /// <summary>
        /// Получить длину отрезка.
        /// </summary>
        /// <param name="point1">Точка 1</param>
        /// <param name="point2">Точка 2</param>
        /// <returns></returns>
        public double GetLineLength(Point point1, Point point2)
        {
            var diffBetweenX = point2.X - point1.X;
            var diffBetweenY = point2.Y - point1.Y;
            var op1 = Math.Pow(diffBetweenX, 2);
            var op2 = Math.Pow(diffBetweenY, 2);

            return Math.Sqrt(op1 + op2);
        }

        public abstract double GetSquare();
    }
}
