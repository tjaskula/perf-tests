using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;

namespace perf_tests_csharp.Challenge6
{
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    [MinColumn, MaxColumn]
    public class Benchmark6
    {
        private static int[,] _matrix1;
        private static int[][] _matrix2;

        [Params(10, 20, 200, 2000, 20000, 200000, 2000000)]
        public static int NbColumns { get; set; }

        [Setup]
        public void SetupBenchmark6()
        {
            _matrix1 = new int[NbColumns, NbColumns * 5];
            for (var row = 0; row < _matrix1.GetLength(0); row++)
            {
                for (var column = 0; column < _matrix1.GetLength(1); column++)
                {
                    _matrix1[row, column] = column;
                }
            }

            _matrix2 = Enumerable.Range(0, NbColumns)
                .Select(_ => Enumerable.Range(0, NbColumns * 5).ToArray())
                .ToArray();
        }

        [Benchmark]
        public void Multidimensional() => Left.Run(_matrix1);

        [Benchmark]
        public void Jagged() => Right.Run(_matrix2);
    }
}