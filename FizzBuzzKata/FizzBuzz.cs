using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzKata
{
    public interface IRule
    {
        string Apply();
        bool IsValidForNumber(int number);
    }

    public class MultipleRule : IRule
    {
        private readonly int _baseNumber;
        private readonly string _whatToSay;

        public MultipleRule(int baseNumber, string whatToSay)
        {
            _baseNumber = baseNumber;
            _whatToSay = whatToSay;
        }

        public string Apply()
        {
            return _whatToSay;
        }

        public bool IsValidForNumber(int number)
        {
            return number % _baseNumber == 0;
        }
    }

    public class CompositeRule : IRule
    {
        private readonly IRule[] _rules;

        public CompositeRule(params IRule[] rules)
        {
            _rules = rules;
        }

        public string Apply()
        {
            return _rules.Select(rule => rule.Apply()).Aggregate(((s, s1) => s + s1));
        }

        public bool IsValidForNumber(int number)
        {
            return _rules.All(rule => rule.IsValidForNumber(number));
        }
    }

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