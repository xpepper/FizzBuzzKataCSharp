using static System.Linq.Enumerable;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string Say(int number)
        {
            return number.ToString();
        }

        public static void Main()
        {
            var fizzBuzz = new FizzBuzz();
            foreach (var number in Range(1, 2))
            {
                var say = fizzBuzz.Say(number);
                System.Console.Out.WriteLine("for {0} we say {1}", number, say);
            }
        }
    }
}