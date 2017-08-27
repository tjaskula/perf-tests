using System.Collections.Generic;

namespace perf_tests_csharp.Challenge15
{
    public class Right
    {
        public static void Run(List<int> values)
        {
            for (var index = 0; index < values.Count;)
            {
                if (values[index] % 10 != 0)
                {
                    values.RemoveAt(index);
                }
                else
                {
                    index++;
                }
            }
        }
    }
}