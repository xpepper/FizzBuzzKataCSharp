using FluentAssertions;
using Xunit;
using static FizzBuzzKata.FizzBuzzRunner;

namespace FizzBuzzKata.Tests
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(7, "Bang")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(18, "Fizz")]
        [InlineData(21, "FizzBang")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(35, "BuzzBang")]
        [InlineData(105, "FizzBuzzBang")]
        public void Say(int number, string saidNumber)
        {
            new FizzBuzz(new()
            {
                new CompositeRule(Fizz, Buzz, Bang),
                new CompositeRule(Fizz, Buzz),
                new CompositeRule(Fizz, Bang),
                new CompositeRule(Buzz, Bang),
                Fizz,
                Buzz,
                Bang,
                SayNumber
            }).Say(number).Should().Be(saidNumber);
        }
    }
}