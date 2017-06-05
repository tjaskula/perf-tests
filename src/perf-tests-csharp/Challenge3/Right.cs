using System.Collections.Generic;
using System.Linq;

namespace perf_tests_csharp.Challenge3
{
    public class Right
    {
        public static void Run(List<decimal> items)
        {
            items.Sum();
        }
    }
}