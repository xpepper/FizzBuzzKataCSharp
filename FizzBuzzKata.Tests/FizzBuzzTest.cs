using FluentAssertions;
using Xunit;

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
        [InlineData(15, "FizzBuzz")]
        [InlineData(18, "Fizz")]
        [InlineData(30, "FizzBuzz")]
        public void Say(int number, string saidNumber)
        {
            new FizzBuzz().Say(number).Should().Be(saidNumber);
        }
    }
}