using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LinqBenchmark.Benchmark
{
    [Config(typeof(BenchmarkConfig))]
    public class HeapAllocBenchmark
    {
        private int[] numbersArray;
        
        private List<int> numbersList;

        private IEnumerable<int> numbers;

        private const int DATA_SIZE = 100_000;

        [GlobalSetup]
        public void Setup()
        {
            numbersArray = Enumerable.Range(0, DATA_SIZE).ToArray();
            numbersList = Enumerable.Range(0, DATA_SIZE).ToList();
            numbers = Enumerable.Range(0, DATA_SIZE);
        }

        [Benchmark]
        public void ArrayAlloc()
        {
            var query = numbersArray.Where(i => i % 2 == 0);
        }

        [Benchmark]
        public void ListAlloc()
        {
            var query = numbersList.Where(i => i % 2 == 0);
        }

        [Benchmark]
        public void IEnuerableAlloc()
        {
            var query = numbers.Where(i => i % 2 == 0);
        }
    }
}
