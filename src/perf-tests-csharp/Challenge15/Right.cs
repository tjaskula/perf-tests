using System.Collections.Generic;
using System.Linq;

namespace perf_tests_csharp.Challenge15
{
    public class Right
    {
        public static void Run(int nbElements)
        {
            var values = new List<int>();
            values.AddRange(Enumerable.Range(0, nbElements));

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