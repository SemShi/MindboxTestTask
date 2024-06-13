using GeometryLibrary.Figures.Base;
using GeometryLibrary.Graph;
using GeometryLibrary.Graph.Structs;
using System.Drawing;

namespace GeometryLibrary
{
    internal class GraphArea
    {
        /// <summary>
        /// Настройки.
        /// </summary>
        private GraphOptions _options;

        /// <summary>
        /// Фигуры, расположенные на графике.
        /// </summary>
        private List<FigureBase> _figures = new List<FigureBase>();

        #region Prop

        public int FiguresCount => _figures.Count;

        #endregion

        /// <summary>
        /// Конструктор создания графика. Принимает в себя объект <see cref="GraphOptions"/>. Разрешается оставлять пустым. Значения по умолчанию для оси X [100;-100], для оси Y [100;-100]. Центральная точка [0;0]
        /// </summary>
        /// <param name="options">Параметры</param>
        public GraphArea(GraphOptions? options = null)
        {
            options = options ?? new GraphOptions()
            {
                GraphSize = new GraphSize()
                {
                    AxisX = new Axis(-100, 100),
                    AxisY = new Axis(-100, 100)
                },
                CentralPoint = new Point(0,0),
            };

            _options = options;
        }

        #region Methods

        /// <summary>
        /// Добавление фигуры на график.
        /// </summary>
        /// <typeparam name="T">Экземпляр фигуры</typeparam>
        /// <param name="figure">Фигура</param>
        /// <returns></returns>
        public bool Push<T>(T figure) 
            where T : FigureBase
        {
            if (!IsFigureInsideGraph(figure.Points))
                throw new Exception($"Фигура не вписывается в график.");

            _figures.Add(figure);
            return true;
        }

        /// <summary>
        /// Удаление фигуры с графика.
        /// </summary>
        /// <typeparam name="T">Экземпляр фигуры</typeparam>
        /// <param name="figure">Фигура</param>
        /// <returns></returns>
        public void Pop<T>(T figure) 
            where T : FigureBase
        {
            _figures.Remove(figure);
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Находится ли фигура в границах графика
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        private bool IsFigureInsideGraph(List<Point> points)
        {
            return points.All(point => _options.GraphSize.IsPointInside(point));
        }

        #endregion
    }
}
