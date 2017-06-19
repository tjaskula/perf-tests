using System.Collections.Generic;

namespace perf_tests_csharp.Challenge5WorstCase
{
    public class Left
    {
        public static void Run(int value, List<int> items)
        {
            MoveToFirst(value, items);
        }

        private static void MoveToFirst(int value, List<int> items)
        {
            var valueIndex = items.IndexOf(value);
            if (valueIndex < 0)
                return;

            items.RemoveAt(valueIndex);
            items.Insert(0, value);
        }
    }
}