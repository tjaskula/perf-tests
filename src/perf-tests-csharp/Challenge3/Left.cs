using System.Collections.Generic;
using System.Linq;

namespace perf_tests_csharp.Challenge3
{
    public class Left
    {
        private static readonly List<double> items;

        static Left()
        {
            items = Enumerable.Repeat(42.0, 50).ToList();
        }

        public static void Run()
        {
            items.Sum();
        }
    }
}