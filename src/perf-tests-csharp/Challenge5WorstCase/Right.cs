using System.Collections.Generic;

namespace perf_tests_csharp.Challenge5WorstCase
{
    public class Right
    {
        public static void Run(int value, LinkedList<int> items)
        {
            MoveToFirst(value, items);
        }

        private static void MoveToFirst(int value, LinkedList<int> items)
        {
            var node = items.Find(value);
            if (node == null)
                return;

            items.Remove(node);
            items.AddFirst(node);
        }
    }
}