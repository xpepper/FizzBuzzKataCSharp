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
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(10, "Buzz")]
        public void SayFizzBuzzOrNumber(int number, string saidNumber)
        {
            new FizzBuzz().Say(number).Should().Be(saidNumber);
        }
    }
}