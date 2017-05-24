using System.Collections.Generic;

namespace perf_tests_csharp.Challenge1
{
    public class Left
    {
        public static void Run(int value, HashSet<int> items)
        {
            var hasValue = items.Contains(value);
        }
    }
}