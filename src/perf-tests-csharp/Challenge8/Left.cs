namespace perf_tests_csharp.Challenge8
{
    public class Left
    {
        public static void Run(int count, int[] x, int[] result)
        {
            for (var index = 1; index < count; index++)
            {
                result[index] = x[index] + result[index - 1];
            }
        }
    }
}