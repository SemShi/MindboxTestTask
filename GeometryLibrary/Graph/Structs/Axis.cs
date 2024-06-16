namespace GeometryLibrary.Graph.Structs
{
    public struct Axis
    {
        public int Max;
        public int Min;

        public Axis(int min, int max)
        {
            Min = min;
            Max = max;

            if (Min > Max)
                throw new ArgumentException("Ошибка. Проверьте правильность введённых данных.");
        }
    }
}
