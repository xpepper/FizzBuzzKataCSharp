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
        [InlineData(6, "Fizz")]
        [InlineData(9, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void FizzBuzzChecker(int number, string expected) => FizzBuzz.Say(number).Should().Be(expected);
    }
}