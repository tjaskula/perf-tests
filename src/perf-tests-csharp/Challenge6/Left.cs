namespace perf_tests_csharp.Challenge6
{
    public class Left
    {
        public static void Run(int[,] matrix)
        {
            var sum = 0;
            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                for (var column = 0; column < matrix.GetLength(1); column++)
                {
                    sum += matrix[row, column];
                }
            }
        }
    }
}