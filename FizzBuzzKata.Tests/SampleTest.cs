using System;
using FluentAssertions;
using Xunit;

namespace FizzBuzzKata.Tests
{
    public class SampleTest
    {
        [Fact]
        public void A_sample_test()
        {
            true.Should().Be(false);
        }
    }
}