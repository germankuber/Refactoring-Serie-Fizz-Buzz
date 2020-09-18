using System.Runtime.CompilerServices;
using FizzBuzz.Parsers;

namespace FizzBuzz
{
    public class FizzBuzzInput
    {
        private readonly int _inputValue;
        private readonly IParseValue _parsers;

        public FizzBuzzInput(int inputValue, IParseValue parsers)
        {
            _inputValue = inputValue;
            _parsers = parsers;
        }

        private string GetResult() =>
            _parsers.Parse(_inputValue);

        public override string ToString() =>
            GetResult();
    }
}