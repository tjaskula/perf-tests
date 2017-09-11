using System.Collections.Generic;

namespace perf_tests_csharp.Challenge16
{
    public class Right
    {
        public static void Run(List<int> values)
        {
            var sum = 0L;

            foreach (var value in values)
            {
                sum += value;
            }
        }
    }
}