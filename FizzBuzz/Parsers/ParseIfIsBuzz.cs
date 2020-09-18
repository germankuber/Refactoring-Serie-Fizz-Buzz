namespace FizzBuzz.Parsers
{
    public class ParseIfIsBuzz : IParseValue
    {
        private readonly IParseValue _next;

        public ParseIfIsBuzz(IParseValue next)
        {
            _next = next;
        }
        public string Parse(int inputValue)
        {
            if (IsBuzz(inputValue))
                return "Buzz";
            return _next.Parse(inputValue);
        }

        private bool IsBuzz(int inputValue) =>
             inputValue % 5 == 0;
    }
}