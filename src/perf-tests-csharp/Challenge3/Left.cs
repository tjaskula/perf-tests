using System.Collections.Generic;
using System.Linq;

namespace perf_tests_csharp.Challenge3
{
    public class Left
    {
        public static void Run(List<double> items)
        {
            items.Sum();
        }
    }
}