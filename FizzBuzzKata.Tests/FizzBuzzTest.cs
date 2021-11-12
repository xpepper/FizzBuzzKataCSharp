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
        [InlineData(6, "Fizz")]
        public void SayFizzBuzzOrNumber(int inputNumber, string outputString)
        {
            new FizzBuzz().Say(inputNumber).Should().Be(outputString);
        }
    }
}