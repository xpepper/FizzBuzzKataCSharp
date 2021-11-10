using FluentAssertions;
using Xunit;

namespace FizzBuzzKata.Tests
{
    public class FizzBuzzTest
    {
        [Fact]
        public void SayOneForOne()
        {
            new FizzBuzz().say(1).Should().Be("1");
        }
    }

    public class FizzBuzz
    {
        public string say(int number)
        {
            return "1";
        }
    }
}