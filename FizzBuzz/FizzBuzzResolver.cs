using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzResolver
    {
        public string PrintFizzBuzz(IEnumerable<FizzBuzzInput> inputs) =>
            string.Join(" ", inputs.ToList()
                .Select(x => x.ToString()));

        public string PrintFizzBuzz(FizzBuzzInput input) =>
            input.ToString();

    }
}
