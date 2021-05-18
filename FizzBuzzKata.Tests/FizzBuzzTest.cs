using System;
using FluentAssertions;
using Xunit;

namespace FizzBuzzKata.Tests
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        public void FizzBuzzChecker(int number, string expected) => new FizzBuzz().Say(number).Should().Be(expected);
    }
}