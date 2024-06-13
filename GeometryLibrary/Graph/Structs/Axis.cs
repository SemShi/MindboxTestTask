namespace GeometryLibrary.Graph.Structs
{
    internal struct Axis
    {
        public int Max;
        public int Min;

        public Axis(int min, int max)
        {
            Min = min;
            Max = max;

            if (Min > Max)
                throw new Exception("Ошибка. Проверьте правильность введённых данных.");
        }
    }
}
