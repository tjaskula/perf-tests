using System.Linq;

namespace perf_tests_csharp.Challenge14
{
    public class Right
    {
        private readonly int[] _values;

        public Right(int nbElements)
        {
            _values = Enumerable.Range(0, nbElements).ToArray();
        }

        public void Run()
        {
            var sum = 0L;
            for (var i = 0; i < _values.Length; i++)
            {
                sum += _values[i];
            }
        }
    }
}