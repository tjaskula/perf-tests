using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;

namespace perf_tests_csharp.Challenge13
{
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    [MinColumn, MaxColumn]
    public class Benchmark13
    {
        [Params(1, 10, 20, 200, 2000, 20000, 200000, 2000000)]
        public static int ExecutionTimes { get; set; }

        [Benchmark]
        public void Now() => Left.Run(ExecutionTimes);

        [Benchmark]
        public void UtcNow() => Right.Run(ExecutionTimes);
    }
}