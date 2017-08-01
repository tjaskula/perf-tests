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
        public void IterativeSmall() => Left.Run(ExecutionTimes, 1245654, 45621);

        [Benchmark]
        public void RecursiveSmall() => Right.Run(ExecutionTimes, 1245654, 45621);

        [Benchmark]
        public void IterativeBig() => Left.Run(ExecutionTimes, 3918848, 1653264);

        [Benchmark]
        public void RecursiveBig() => Right.Run(ExecutionTimes, 3918848, 1653264);
    }
}