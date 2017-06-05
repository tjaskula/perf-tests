using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;

namespace perf_tests_csharp.Challenge3
{
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    [MinColumn, MaxColumn]
    public class Benchmark3
    {
        private List<double> _items1;
        private List<decimal> _items2;

        [Params(10, 20, 200, 2000, 20000, 200000, 2000000)]
        public static int NbElements { get; set; }

        [Setup]
        public void SetupBenchmark3()
        {
            _items1 = Enumerable.Repeat(42.0, NbElements).ToList();
            _items2 = Enumerable.Repeat(42m, NbElements).ToList();
        }

        [Benchmark]
        public void Double() => Left.Run(_items1);

        [Benchmark]
        public void Decimal() => Right.Run(_items2);
    }
}