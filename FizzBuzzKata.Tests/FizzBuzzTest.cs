using System;
using FluentAssertions;
using Xunit;

namespace FizzBuzzKata.Tests
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Say_1_for_1()
        {
            new FizzBuzz().Say(1).Should().Be("1");
        }

        [Fact]
        public void Say_2_for_2()
        {
            new FizzBuzz().Say(2).Should().Be("2");
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        public void FizzBuzzChecker(int number, string expected) => new FizzBuzz().Say(number).Should().Be(expected);
    }
}