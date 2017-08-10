using BenchmarkDotNet.Running;
using perf_tests_csharp.Challenge1;
using perf_tests_csharp.Challenge10;
using perf_tests_csharp.Challenge11;
using perf_tests_csharp.Challenge12;
using perf_tests_csharp.Challenge13;
using perf_tests_csharp.Challenge2;
using perf_tests_csharp.Challenge2bis;
using perf_tests_csharp.Challenge3;
using perf_tests_csharp.Challenge4;
using perf_tests_csharp.Challenge5;
using perf_tests_csharp.Challenge5WorstCase;
using perf_tests_csharp.Challenge6;
using perf_tests_csharp.Challenge7;
using perf_tests_csharp.Challenge8;
using perf_tests_csharp.Challenge9;

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
                typeof(Benchmark5),
                typeof(Benchmark5WorstCase),
                typeof(Benchmark6),
                typeof(Benchmark7),
                typeof(Benchmark8),
                typeof(Benchmark9),
                typeof(Benchmark10),
                typeof(Benchmark11),
                typeof(Benchmark12),
                typeof(Benchmark13)
            });

            switcher.Run(args);
        }
    }
}