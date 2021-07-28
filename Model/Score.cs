namespace LinqBenchmark.Model
{
    public readonly struct Score
    {
        public readonly uint Point;

        public readonly float ClearTime;

        public Score(uint point, float clearTime)
        {
            Point = point;
            ClearTime = clearTime;
        }
    }
}
