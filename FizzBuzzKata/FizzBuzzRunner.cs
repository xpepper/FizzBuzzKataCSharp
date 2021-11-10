using System.Linq;

namespace FizzBuzzKata
{
    internal static class FizzBuzzRunner
    {
        public static void Main()
        {
            var fizzBuzz = new FizzBuzz();
            foreach (var number in Enumerable.Range(1, 20))
            {
                var say = fizzBuzz.Say(number);
                System.Console.Out.WriteLine("for {0} we say {1}", number, say);
            }
        }
    }
}