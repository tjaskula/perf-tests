namespace perf_tests_csharp.Challenge2
{
    public class Left
    {
        public static unsafe void Run(int value, int[] items)
        {
            var hasValue = false;
            fixed (int* p = items)
            {
                for (var index = 0; index < items.Length; index++)
                {
                    if (p[index] == value)
                    {
                        hasValue = true;
                        break;
                    }
                }
            }
        }
    }
}