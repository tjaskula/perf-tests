using System;

namespace perf_tests_csharp.Challenge13
{
    public class Right
    {
        public static void Run(int nbExecutions)
        {
            DateTime? now = null;
            for (int i = 1; i <= nbExecutions; i++)
                now = DateTime.UtcNow;
        }        
    }
}