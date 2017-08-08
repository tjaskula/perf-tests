namespace perf_tests_csharp.Challenge13
{
    public class Left
    {
        public static void Run(int nbExecutions, int a, int b)
        {
            for (int i = 1; i <= nbExecutions; i++)
                GreatestCommonDivisor(a, b);
        }

        private static int GreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                var tmp = b;
                b = a % b;
                a = tmp;
            }
            return a;
        }
    }
}