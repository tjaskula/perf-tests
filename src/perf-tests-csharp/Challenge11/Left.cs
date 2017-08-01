namespace perf_tests_csharp.Challenge11
{
    public class Left
    {
        public static void Run(int nbExecutions)
        {
            for (int i = 1; i <= nbExecutions; i++)
                GreatestCommonDivisor(1245654, 45621);
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