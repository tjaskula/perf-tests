namespace perf_tests_csharp.Challenge14
{
    public class Left
    {
        public static unsafe void Run(ref int[] vals)
        {
            var sum = 0L;
            fixed (int* values = vals)
            {
                for (var i = 0; i < vals.Length; i++)
                {
                    sum += values[i];
                }
            }
        }
    }
}