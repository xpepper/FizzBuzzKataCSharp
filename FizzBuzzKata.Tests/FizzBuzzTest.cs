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
    }
}