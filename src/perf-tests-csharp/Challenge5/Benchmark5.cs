using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;

namespace perf_tests_csharp.Challenge5
{
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    [MinColumn, MaxColumn]
    public class Benchmark5
    {
        private Random _rdn;
        private List<int> _items1;
        private LinkedList<int> _items2;
        private int _value;

        [Params(10, 20, 200, 2000, 20000, 200000, 2000000)]
        public static int NbElements { get; set; }

        [Setup]
        public void SetupBenchmark3()
        {
            var values = Enumerable.Range(0, NbElements).ToList();
            _value = _rdn.Next(0, NbElements);
            _items1 = values;
            _items2 = new LinkedList<int>(values);
        }

        [Benchmark]
        public void List() => Left.Run(_value, _items1);

        [Benchmark]
        public void LinkedList() => Right.Run(_value, _items2);
    }
}