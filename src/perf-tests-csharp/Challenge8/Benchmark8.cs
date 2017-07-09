using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;

namespace perf_tests_csharp.Challenge8
{
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    [MinColumn, MaxColumn]
    public class Benchmark8
    {
        private static int[] _x;
        private static int[] _result;

        [Params(10, 20, 200, 2000, 20000, 200000, 2000000)]
        public static int Count { get; set; }

        [Setup]
        public void SetupBenchmark8()
        {
            _x = Enumerable.Range(0, Count).ToArray();
            _result = Enumerable.Range(0, Count).ToArray();
            Array.Clear(_result, 0, Count);
        }

        [Benchmark]
        public void Left() => Challenge8.Left.Run(Count, _x, _result);

        [Benchmark]
        public void Right() => Challenge8.Right.Run(Count, _x, _result);
    }
}