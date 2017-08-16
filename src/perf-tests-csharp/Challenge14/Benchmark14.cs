using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;

namespace perf_tests_csharp.Challenge14
{
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    [MinColumn, MaxColumn]
    public class Benchmark14
    {
        private Left _left;
        private Right _right;

        [Params(10, 20, 100, 1000, 10000, 100000, 1000000, 10000000)]
        public static int NbElements { get; set; }

        [Setup]
        public void SetupBenchmark14()
        {
            _left = new Left(NbElements);
            _right = new Right(NbElements);
        }

        [Benchmark]
        public void Left() => _left.Run();

        [Benchmark]
        public void Right() => _right.Run();
    }
}