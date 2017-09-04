using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;

namespace perf_tests_csharp.Challenge15
{
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    [MinColumn, MaxColumn]
    public class Benchmark15
    {
        [Params(10, 20, 200, 500, 2000, 20000)]
        public static int NbElements { get; set; }

        [Benchmark]
        public void Left() => Challenge15.Left.Run(NbElements);

        [Benchmark]
        public void Right() => Challenge15.Right.Run(NbElements);
    }
}