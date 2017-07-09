namespace perf_tests_csharp.Challenge8
{
    public class Right
    {
        public static void Run(int count, int[] x, int[] result)
        {
            for (var index = 1; index < count; index++)
            {
                result[index] = x[index] + x[index - 1];
            }
        }
    }
}