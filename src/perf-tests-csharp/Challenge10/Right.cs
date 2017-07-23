using System.Threading;

namespace perf_tests_csharp.Challenge10
{
    public class Right
    {
        public static void Run(int value)
        {
            var isValid = IsValid1(value) & IsValid2(value) & IsValid3(value);
        }

        private static bool IsValid1(int n)
        {
            return n < 100;
        }

        private static bool IsValid2(int n)
        {
            return n % 10 == 0;
        }

        private static bool IsValid3(int n)
        {
            Thread.Sleep(1);
            return n % 3 == 0;
        }
    }
}