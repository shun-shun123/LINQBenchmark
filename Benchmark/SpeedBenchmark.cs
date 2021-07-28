using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using LinqBenchmark.Model;

namespace LinqBenchmark.Benchmark
{
    [Config(typeof(BenchmarkConfig))]
    public class SpeedBenchmark
    {
        private List<UserAccount> UserList;

        private List<Score> ScoreList;

        private const int DATA_SIZE = 50_000;
        
        [GlobalSetup]
        public void Setup()
        {
            UserList = Enumerable.Range(0, DATA_SIZE).Select(i => new UserAccount(i, $"user_{i}", (uint)i)).ToList();
            ScoreList = Enumerable.Range(0, DATA_SIZE).Select(i => new Score((uint)i, (float) i)).ToList();
        }

        [Benchmark]
        public void PureClassIterate()
        {
            for (var i = 0; i < UserList.Count; i++)
            {
                if (UserList[i].UserId % 2 == 0)
                {
                    // Do something
                }
            }
        }

        [Benchmark]
        public void LinqClassIterate()
        {
            var query = UserList.Where(user => user.UserId % 2 == 0);
            foreach (var user in query)
            {
                // Do something
            }
        }

        [Benchmark]
        public void PureStructIterate()
        {
            for (var i = 0; i < ScoreList.Count; i++)
            {
                if (ScoreList[i].Point % 2 == 0)
                {
                    // Do something
                }
            }
        }

        [Benchmark]
        public void LinqStructIterate()
        {
            var query = ScoreList.Where(score => score.Point % 2 == 0);
            foreach (var score in query)
            {
                // Do something
            }
        }
    }
}
