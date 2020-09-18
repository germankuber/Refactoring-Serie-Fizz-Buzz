namespace FizzBuzz.Parsers
{
    public class ParseToString : IParseValue
    {

        public ParseToString()
        {
        }
        public string Parse(int inputValue) => 
            inputValue.ToString();

    }
}