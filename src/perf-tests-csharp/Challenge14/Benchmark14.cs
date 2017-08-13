using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;

namespace perf_tests_csharp.Challenge12
{
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    [MinColumn, MaxColumn]
    public class Benchmark14
    {
        private static int[] _values;

        [Params(10, 20, 100, 1000, 10000, 100000, 1000000, 10000000)]
        public static int NbElements { get; set; }

        [Setup]
        public void SetupBenchmark12()
        {
            _values = Enumerable.Range(0, NbElements).ToArray();
        }

        [Benchmark]
        public void Left() => Challenge14.Left.Run(ref _values);

        [Benchmark]
        public void Right() => Challenge14.Right.Run(ref _values);
    }
}