﻿using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;

namespace perf_tests_csharp.Challenge2bis
{
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    [MinColumn, MaxColumn]
    public class Benchmark2bis
    {
        private Random _rdn;
        private int _value;
        private int[] _items1;
        private List<int> _items2;

        [Params(10, 20, 200, 2000, 20000, 200000, 2000000)]
        public static int NbElements { get; set; }

        [Setup]
        public void SetupBenchmark2bis()
        {
            var range = Enumerable.Range(0, NbElements).ToArray();
            _items1 = range;
            _items2 = new List<int>(range);
            _rdn = new Random();
            _value = _rdn.Next(0, (int)(NbElements * 2.5));
        }

        [Benchmark]
        public void UnsafeLoop() => Left.Run(_value, _items1);

        [Benchmark]
        public void List() => Right.Run(_value, _items2);
    }
}