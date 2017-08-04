namespace perf_tests_csharp.Challenge12
{
    public class Left
    {
        public static void Run(ref int[] vals)
        {
            var sum = 0L;
            var values = vals;
            for (var i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
        }
    }
}