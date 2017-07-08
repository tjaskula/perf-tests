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
        private static int[][] _matrix;

        [Params(10, 20, 200, 2000, 20000, 200000, 2000000)]
        public static int NbRows { get; set; }

        [Setup]
        public void SetupBenchmark8()
        {
            _matrix = Enumerable.Range(0, NbRows)
                .Select(_ => Enumerable.Range(0, NbRows * 250).ToArray())
                .ToArray();
        }

        [Benchmark]
        public void RowEnumerate() => Left.Run(_matrix, NbRows, NbRows * 250);

        [Benchmark]
        public void ColumnEnumerate() => Right.Run(_matrix, NbRows, NbRows * 250);
    }
}