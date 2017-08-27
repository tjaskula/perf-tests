using System.Collections.Generic;

namespace perf_tests_csharp.Challenge15
{
    public class Left
    {
        public static void Run(List<int> values)
        {
            for (var index = values.Count - 1; index >= 0;)
            {
                if (values[index] % 10 != 0)
                {
                    values.RemoveAt(index);
                }
                index--;
            }
        }
    }
}