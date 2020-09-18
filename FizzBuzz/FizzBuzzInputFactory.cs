using FizzBuzz.Parsers;

namespace FizzBuzz
{
    public static class FizzBuzzInputFactory
    {
        public  static FizzBuzzInput Make (int input)=>
            new FizzBuzzInput(input, new ParseIfIsBuzzAndFizz(new ParseIfIsBuzz(new ParseIfIsFizz(new ParseToString()))));
    }
}