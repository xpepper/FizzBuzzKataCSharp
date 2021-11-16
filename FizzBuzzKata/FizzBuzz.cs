using System;
using System.Collections.Generic;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        private readonly List<IRule> _rules;

        public FizzBuzz(List<IRule> rules)
        {
            _rules = rules;
        }

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