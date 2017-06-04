using System.Collections.Generic;

namespace perf_tests_csharp.Challenge2bis
{
    public class Right
    {
        public static void Run(int value, List<int> items)
        {
            items.Contains(value);
        }
    }
}