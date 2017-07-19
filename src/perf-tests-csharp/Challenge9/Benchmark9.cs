using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;

namespace perf_tests_csharp.Challenge9
{
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    [MinColumn, MaxColumn]
    public class Benchmark9
    {
        [Params(10, 20, 100, 1000, 10000, 100000)]
        public static int Count { get; set; }

        [Benchmark]
        public void Division() => Left.Run(Count);

        [Benchmark]
        public void Sqrt() => Right.Run(Count);
    }
}