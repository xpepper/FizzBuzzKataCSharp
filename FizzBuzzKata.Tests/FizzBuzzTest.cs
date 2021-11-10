using FluentAssertions;
using Xunit;

namespace FizzBuzzKata
{
}

namespace FizzBuzzKata.Tests
{
    public class FizzBuzzTest
    {
        [Fact]
        public void SayOneForOne()
        {
            new FizzBuzz().say(1).Should().Be("1");
        }
        [Fact]
        public void SayTwoForTwo()
        {
            new FizzBuzz().say(2).Should().Be("2");
        }
    }
}