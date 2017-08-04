namespace perf_tests_csharp.Challenge12
{
    public class Right
    {
        public static void Run(ref int[] vals)
        {
            var sum = 0L;
            for (var i = 0; i < vals.Length; i++)
            {
                sum += vals[i];
            }
        }
    }
}