using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Exporters;

namespace perf_tests_csharp.Challenge1
{
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    public class Benchmark1
    {
        [Params(10, 20, 200, 2000, 20000, 200000, 2000000)]
        public static int EnumerableRange { get; set; }

        [Params(25, 50, 500, 5000, 50000, 500000, 5000000)]
        public static int RandomRange { get; set; }

        [Benchmark]
        public void BenchmarkLeft()
        {
            Left.EnumerableRange = EnumerableRange;
            Left.RandomRange = RandomRange;
            Left.Run();
        }

        [Benchmark]
        public void BenchmarkRight()
        {
            Right.EnumerableRange = EnumerableRange;
            Right.RandomRange = RandomRange;
            Right.Run();
        }
    }
}