using System.Linq;

namespace perf_tests_csharp.Challenge14
{
    public class Left
    {
        private readonly int[] _values;

        public Left(int nbElements)
        {
            _values = Enumerable.Range(0, nbElements).ToArray();
        }

        public unsafe void Run()
        {
            var sum = 0L;
            fixed (int* values = _values)
            {
                for (var i = 0; i < _values.Length; i++)
                {
                    sum += values[i];
                }
            }
        }
    }
}