using System.Collections.Generic;
using System.Linq;

namespace perf_tests_csharp.Challenge4
{
    public class Right
    {
        public static void Run(LinkedList<int> items)
        {
            items.Max();
        }
    }
}