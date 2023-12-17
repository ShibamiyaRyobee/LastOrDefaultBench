using BenchmarkDotNet.Running;
using LinqBench;

namespace LastOrDefaultBench
{
    public class Program
    {
        private static void Main()
        {
            BenchmarkRunner.Run<LastOrDefault>();
        }
    }
}