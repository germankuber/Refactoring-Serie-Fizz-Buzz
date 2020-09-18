namespace FizzBuzz.Parsers
{
    public class ParseIfIsFizz : IParseValue
    {
        private readonly IParseValue _next;

        public ParseIfIsFizz(IParseValue next)
        {
            _next = next;
        }
        public string Parse(int inputValue)
        {
            if (IsFizz(inputValue))
                return "Fizz";
            return _next.Parse(inputValue);
        }

        private bool IsFizz(int inputValue) =>
             inputValue % 3 == 0;
    }
}