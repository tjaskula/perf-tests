using System.Collections.Generic;

namespace perf_tests_csharp.Challenge16
{
    public class Left
    {
        public static void Run(List<int> values)
        {
            var sum = 0L;

            for (var i = 0; i < values.Count; i++)
            {
                sum += values[i];
            }
        }
    }
}