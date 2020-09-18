namespace FizzBuzz.Parsers
{
    public class ParseIfIsBuzzAndFizz : IParseValue
    {
        private readonly IParseValue _next;

        public ParseIfIsBuzzAndFizz(IParseValue next)
        {
            _next = next;
        }
        public string Parse(int inputValue)
        {
            if (IsBuzz(inputValue) && IsFizz(inputValue))
                return "FizzBuzz";
            return _next.Parse(inputValue);
        }

        private bool IsBuzz(int inputValue) =>
             inputValue % 5 == 0;

        private bool IsFizz(int inputValue) =>
          inputValue % 3 == 0;
    }
}