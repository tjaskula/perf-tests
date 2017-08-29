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
        private List<int> _values = new List<int>();

        [Params(10, 20, 200, 500, 2000, 20000, 200000, 2000000)]
        public static int NbElements { get; set; }

        [Setup]
        public void SetupBenchmark15()
        {
            _values.Clear();
            _values.AddRange(Enumerable.Range(0, NbElements));
        }

        [Benchmark]
        public void Left() => Challenge15.Left.Run(_values);

        [Benchmark]
        public void Right() => Challenge15.Right.Run(_values);
    }
}