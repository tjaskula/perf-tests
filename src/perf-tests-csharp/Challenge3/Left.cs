using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perf_tests_csharp.Challenge3
{
    public class Left
    {
        private static readonly List<double> _items;

        static Left()
        {
            _items = Enumerable.Repeat(42.0, 50).ToList();
        }

        public static void Run()
        {
            _items.Sum();
        }
    }
}