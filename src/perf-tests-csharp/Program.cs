using BenchmarkDotNet.Running;
using perf_tests_csharp.Challenge1;
using perf_tests_csharp.Challenge2;
using perf_tests_csharp.Challenge2bis;
using perf_tests_csharp.Challenge3;
using perf_tests_csharp.Challenge4;
using perf_tests_csharp.Challenge5;

namespace perf_tests_csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var switcher = new BenchmarkSwitcher(new[] {
                typeof(Benchmark1),
                typeof(Benchmark2),
                typeof(Benchmark2bis),
                typeof(Benchmark3),
                typeof(Benchmark4),
                typeof(Benchmark5)
            });
            switcher.Run(args);
        }
    }
}