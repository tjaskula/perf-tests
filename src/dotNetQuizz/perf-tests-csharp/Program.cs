using BenchmarkDotNet.Running;
using perf_tests_csharp.Challenge1;

namespace perf_tests_csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = BenchmarkRunner.Run<Benchmark1>();
        }
    }
}