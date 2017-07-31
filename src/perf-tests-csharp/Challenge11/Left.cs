namespace perf_tests_csharp.Challenge11
{
    public class Left
    {
        public static void Run()
        {
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