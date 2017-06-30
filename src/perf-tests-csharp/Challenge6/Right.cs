namespace perf_tests_csharp.Challenge6
{
    public class Right
    {
        public static void Run(int[][] matrix)
        {
            var sum = 0;
            for (var row = 0; row < matrix.Length; row++)
            {
                for (var column = 0; column < matrix[row].Length; column++)
                {
                    sum += matrix[row][column];
                }
            }
        }
    }
}