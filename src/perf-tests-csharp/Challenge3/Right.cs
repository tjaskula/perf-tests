using System.Collections.Generic;
using System.Linq;

namespace perf_tests_csharp.Challenge3
{
    public class Right
    {
        private static readonly List<decimal> items;

        static Right()
        {
            items = Enumerable.Repeat(42m, 50).ToList();
        }

        public static void Run()
        {
            items.Sum();
        }
    }
}