using GeometryLibrary;
using GeometryLibrary.Figures;
using GeometryLibrary.Graph;
using GeometryLibrary.Graph.Structs;
using System.Drawing;

namespace Tests
{
    public class GraphTests
    {
        /// <summary>
        /// Добавление фигуры на график.
        /// </summary>
        [Fact]
        public void Adding_Figure_To_Graph()
        {
            //ARRANGE
            var graph = new GraphArea();
            
            //ACT
            var circle = new CircleModel(new(0, 0), new(0, 10));
            graph.Push(circle);
            
            //ASSERT
            Assert.Equal(1, graph.FiguresCount);
        }

        /// <summary>
        /// Удаление фигуры с графика.
        /// </summary>
        [Fact]
        public void Remove_Figure_From_Graph()
        {
            //ARRANGE
            var graph = new GraphArea();

            //ACT
            var circle = new CircleModel(new(0, 0), new(0, 10));
            graph.Push(circle);
            graph.Pop(circle);

            //ASSERT
            Assert.Equal(0, graph.FiguresCount);
        }

        /// <summary>
        /// Не даем добавить объект, если он выходит за границы координатных осей.
        /// </summary>
        [Fact]
        public void Is_Points_Of_Figure_Outside_Graph()
        {
            //ARRANGE
            var graph = new GraphArea(new GraphOptions()
            {
                CentralPoint = new Point(0,0),
                GraphSize = new GraphSize()
                {
                    AxisX = new Axis(-50, 50),
                    AxisY = new Axis(-50, 50),
                }
            });

            //ACT + ASSERT
            var circle = new CircleModel(new(0, 0), new(60, 0));

            Assert.Throws<ArgumentOutOfRangeException>(() => graph.Push(circle));
        }
    }
}