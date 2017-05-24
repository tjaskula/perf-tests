using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Exporters;

namespace perf_tests_csharp.Challenge1
{
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    public class Benchmark1
    {
        private Random _rdn;
        private int _value;
        private HashSet<int> _items1;
        private List<int> _items2;

        [Params(10, 20, 200, 2000, 20000, 200000, 2000000)]
        public static int Range { get; set; }

        [Setup]
        public void SetupBenchmark1()
        {
            var range = Enumerable.Range(0, Range).ToList();
            _items1 = new HashSet<int>(range);
            _items2 = new List<int>(range);
            _rdn = new Random();
            _value = _rdn.Next(0, (int)(Range * 2.5));
        }

        [Benchmark]
        public void BenchmarkLeft() => Left.Run(_value, _items1);

        [Benchmark]
        public void BenchmarkRight() => Right.Run(_value, _items2);
    }
}