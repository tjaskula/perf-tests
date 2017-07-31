using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;

namespace perf_tests_csharp.Challenge11
{
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    [MinColumn, MaxColumn]
    public class Benchmark11
    {
        [Benchmark]
        public void Iterative() => Left.Run();

        [Benchmark]
        public void Recursive() => Right.Run();
    }
}