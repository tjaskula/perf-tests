using BenchmarkDotNet.Running;
using perf_tests_csharp.Challenge1;
using perf_tests_csharp.Challenge2;

namespace perf_tests_csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var switcher = new BenchmarkSwitcher(new[] {
                typeof(Benchmark1),
                typeof(Benchmark2)
            });
            switcher.Run(args);
        }
    }
}