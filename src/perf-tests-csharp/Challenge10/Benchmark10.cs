using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;

namespace perf_tests_csharp.Challenge10
{
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    [MinColumn, MaxColumn]
    public class Benchmark10
    {
        private Random _rdn;
        private int _value;

        [Setup]
        public void SetupBenchmark10()
        {
            _rdn = new Random();
            _value = _rdn.Next();
        }

        [Benchmark]
        public void Left() => Challenge10.Left.Run(_value);

        [Benchmark]
        public void Right() => Challenge10.Right.Run(_value);
    }
}