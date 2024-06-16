using GeometryLibrary.Figures;

namespace Tests
{
    public class FigureTests
    {
        /// <summary>
        /// ���������� ������� ������������ �� �����������.
        /// </summary>
        [Fact]
        public void Get_Square_Triangle_By_Coordinates()
        {
            //ARRANGE
            var triangle = new TriangleModel(new(0, 0), new(0, 10), new(5, 5));
            
            //ACT
            var result = triangle.GetSquare();

            //ASSERT
            Assert.Equal(25, result);
        }

        /// <summary>
        /// ���������� ������� ����� �� �������=5.
        /// </summary>
        [Fact]
        public void Get_Square_Circle_By_Radius()
        {
            //ARRANGE
            var circle = new CircleModel(new(0, 0), new(0, 5));

            //ACT
            var result = circle.GetSquare();

            //ASSERT
            Assert.Equal(78.54d, result);
        }

        /// <summary>
        /// ���������� ���������� ��� �������� ������ � ����������� �������.
        /// </summary>
        [Fact]
        public void Get_Exception_With_Not_Unique_Points()
        {
            Assert.Throws<ArgumentException>(
                () => new CircleModel(new(0, 0), new(0, 0))
                );
        }
    }
}
