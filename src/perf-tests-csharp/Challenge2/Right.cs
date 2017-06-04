using System.Collections.Generic;

namespace perf_tests_csharp.Challenge2
{
    public class Right
    {
        public static void Run(int value, HashSet<int> items)
        {
            items.Contains(value);
        }
    }
}