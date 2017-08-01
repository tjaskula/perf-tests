namespace perf_tests_csharp.Challenge11
{
    public class Right
    {
        public static void Run(int nbExecutions)
        {
            for (int i = 1; i <= nbExecutions; i++)
                GreatestCommonDivisor(1245654, 45621);
        }

        private static int GreatestCommonDivisor(int a, int b)
        {
            if (b == 0)
                return a;

            return GreatestCommonDivisor(b, a % b);
        }
    }
}