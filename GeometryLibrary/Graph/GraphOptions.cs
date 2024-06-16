using GeometryLibrary.Graph.Structs;
using System.Drawing;

namespace GeometryLibrary.Graph
{
    /// <summary>
    /// Класс настроек для создания графика.
    /// </summary>
    public class GraphOptions
    {
        /// <summary>
        /// Размер сетки графика.
        /// </summary>
        public GraphSize GraphSize { get; set; }

        /// <summary>
        /// Фигуры, расположенные на графике.
        /// </summary>
        public Point CentralPoint { get; set; }
    }
}
