namespace perf_tests_csharp.Challenge7
{
    public class Left
    {
        public static void Run(int[][] matrix, int rowCount, int columnCount)
        {
            var sum = 0;
            for (var row = 0; row < rowCount; row++)
            {
                for (var column = 0; column < columnCount; column++)
                {
                    sum += matrix[row][column];
                }
            }
        }
    }
}