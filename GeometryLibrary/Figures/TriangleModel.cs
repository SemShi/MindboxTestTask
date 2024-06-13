using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLibrary.Figures.Base;

namespace GeometryLibrary.Figures
{
    public class TriangleModel : FigureBase
    {
        public TriangleModel(Point point1, Point point2, Point point3)
        {
            Points.Add(point1);
            Points.Add(point2);
            Points.Add(point3);
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
