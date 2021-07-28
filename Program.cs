using BenchmarkDotNet.Running;
using LinqBenchmark.Benchmark;

namespace LinqBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var switcher = new BenchmarkSwitcher(new[]
            {
                typeof(SpeedBenchmark),
                typeof(HeapAllocBenchmark)
            });

            switcher.Run(args);
        }
    }
}
