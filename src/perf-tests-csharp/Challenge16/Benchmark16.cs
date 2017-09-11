using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;

namespace perf_tests_csharp.Challenge16
{
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    [MinColumn, MaxColumn]
    public class Benchmark16
    {
        private List<int> _items;

        [Params(10, 20, 200, 2000, 20000, 200000, 1000000, 2000000)]
        public static int NbElements { get; set; }

        [GlobalSetup]
        public void SetupBenchmark16()
        {
            _items = Enumerable.Range(0, NbElements).ToList();
        }

        [Benchmark]
        public void For() => Left.Run(_items);

        [Benchmark]
        public void Foreach() => Right.Run(_items);
    }
}