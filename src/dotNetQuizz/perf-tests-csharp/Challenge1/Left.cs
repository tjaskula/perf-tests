using System;
using System.Collections.Generic;
using System.Linq;

namespace perf_tests_csharp.Challenge1
{
    public class Left
    {
        private static readonly HashSet<int> Items;
        private static readonly Random Random;

        static Left()
        {
            Items = new HashSet<int>(Enumerable.Range(0, EnumerableRange));
            Random = new Random();
        }

        public static void Run()
        {
            var value = Random.Next(0, RandomRange);
            // begin
            var hasValue = Items.Contains(value);
            // end
            Logger.Log(hasValue ? "Found!" : "Not found :'(");
        }

        public static int EnumerableRange { get; set; }

        public static int RandomRange { get; set; }
    }
}