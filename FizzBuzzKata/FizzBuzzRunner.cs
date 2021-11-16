using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzKata
{
    public static class FizzBuzzRunner
    {
        public static readonly IRule Fizz = new MultipleRule(3, "Fizz");
        public static readonly IRule Buzz = new MultipleRule(5, "Buzz");
        public static readonly IRule Bang = new MultipleRule(7, "Bang");
        public static readonly IRule SayNumber = new SayNumberRule();
        
        public static void Main()
        {
            var fizzBuzz = new FizzBuzz(new List<IRule>
            {
                new CompositeRule(Fizz, Buzz, Bang),
                new CompositeRule(Fizz, Buzz),
                new CompositeRule(Fizz, Bang),
                new CompositeRule(Buzz, Bang),
                Fizz,
                Buzz,
                Bang,
                SayNumber
            });
            
            foreach (var number in Enumerable.Range(1, 100))
            {
                var say = fizzBuzz.Say(number);
                System.Console.Out.WriteLine("for {0} we say {1}", number, say);
            }
        }
    }
}