using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace LinqBench
{
    [SimpleJob(RuntimeMoniker.Net80)]
    [SimpleJob(RuntimeMoniker.Net481)]
    [MemoryDiagnoser]
    public class LastOrDefault
    {
        private readonly string[] _fruits = { "apple", "banana", "orange", "grape" };

        [Benchmark]
        public string Kuso() => _fruits.Reverse().FirstOrDefault(x => x.Length == 6);

        [Benchmark]
        public string Normal() => _fruits.LastOrDefault(x => x.Length == 6);
    }
}
