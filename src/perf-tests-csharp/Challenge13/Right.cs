namespace perf_tests_csharp.Challenge13
{
    public class Right
    {
        public static void Run(int nbExecutions, int a, int b)
        {
            for (int i = 1; i <= nbExecutions; i++)
                GreatestCommonDivisor(a, b);
        }

        private static int GreatestCommonDivisor(int a, int b)
        {
            if (b == 0)
                return a;

            return GreatestCommonDivisor(b, a % b);
        }
    }
}