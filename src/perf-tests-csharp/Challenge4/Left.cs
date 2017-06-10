using System.Collections.Generic;
using System.Linq;

namespace perf_tests_csharp.Challenge4
{
    public class Left
    {
        public static void Run(List<int> items)
        {
            items.Max();
        }
    }
}