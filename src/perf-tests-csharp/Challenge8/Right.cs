namespace perf_tests_csharp.Challenge8
{
    public class Right
    {
        public static void Run(int[][] matrix, int rowCount, int columnCount)
        {
            var sum = 0;
            // begin
            for (var column = 0; column < columnCount; column++)
            {
                for (var row = 0; row < rowCount; row++)
                {
                    sum += matrix[row][column];
                }
            }
        }
    }
}