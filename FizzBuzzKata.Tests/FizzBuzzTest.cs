using System;
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
    }

    public class FizzBuzz
    {
        public string Say(int number)
        {
            return "1";
        }
    }
}