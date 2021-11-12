using FluentAssertions;
using Xunit;

namespace FizzBuzzKata.Tests
{
    public class FizzBuzzTest
    {
        [Fact]
        public void SayOneForOne()
        {
            new FizzBuzz().Say(1).Should().Be("1");
        }

        [Fact]
        public void SayTwoForTwo()
        {
            new FizzBuzz().Say(2).Should().Be("2");
        }
    }

    public class FizzBuzz
    {
        public string Say(int number)
        {
            return number.ToString();
        }
    }
}