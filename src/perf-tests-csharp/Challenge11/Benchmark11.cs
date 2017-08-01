using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;

namespace perf_tests_csharp.Challenge11
{
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    [MinColumn, MaxColumn]
    public class Benchmark11
    {
        [Params(1, 10, 20, 200, 2000, 20000, 200000, 2000000)]
        public static int ExecutionTimes { get; set; }

        [Benchmark]
        public void Iterative() => Left.Run(ExecutionTimes);

        [Benchmark]
        public void Recursive() => Right.Run(ExecutionTimes);
    }
}