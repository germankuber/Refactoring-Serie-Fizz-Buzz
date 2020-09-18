using System.Collections.Generic;

namespace FizzBuzz
{
    public static class NumberGenerator
    {
        public static IEnumerable<int> Generate(int count)
        {
            for (var i = 1; i <= count; i++)
                yield return i;
        }
    }
}
