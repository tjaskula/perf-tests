using System.Collections.Generic;
using System.Linq;

namespace perf_tests_csharp.Challenge15
{
    public class Left
    {
        public static void Run(int nbElements)
        {
            var values = new List<int>();
            values.AddRange(Enumerable.Range(0, nbElements));

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