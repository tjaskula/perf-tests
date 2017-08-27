using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;

namespace perf_tests_csharp.Challenge15
{
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    [MinColumn, MaxColumn]
    public class Benchmark15
    {
        private List<int> _values;

        [Params(10, 20, 200, 2000, 20000, 200000, 2000000)]
        public static int NbElements { get; set; }

        [Setup]
        public void SetupBenchmark15()
        {
            _values = Enumerable.Range(0, NbElements).ToList();
        }

        [Benchmark]
        public void List() => Left.Run(_values);

        [Benchmark]
        public void LinkedList() => Right.Run(_values);
    }
}