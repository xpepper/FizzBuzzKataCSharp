using System;
using System.Collections.Generic;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        private readonly List<IRule> _rules = new()
        {
            new CompositeRule(Fizz, Buzz, Bang),
            new CompositeRule(Fizz, Buzz),
            new CompositeRule(Fizz, Bang),
            new CompositeRule(Buzz, Bang),
            Fizz,
            Buzz,
            Bang,
            SayNumber
        };

        private static readonly IRule Fizz = new MultipleRule(3, "Fizz");
        private static readonly IRule Buzz = new MultipleRule(5, "Buzz");
        private static readonly IRule Bang = new MultipleRule(7, "Bang");
        private static readonly IRule SayNumber = new SayNumberRule();

        public string Say(int number)
        {
            foreach (var rule in _rules)
            {
                if (rule.IsValidForNumber(number)) return rule.Apply();
            }

            throw new Exception("cannot apply any rule");
        }
    }

    internal class SayNumberRule : IRule
    {
        private int _number;

        public string Apply()
        {
            return _number.ToString();
        }

        public bool IsValidForNumber(int number)
        {
            _number = number;
            return true;
        }
    }
}