using System.Collections.Generic;
using System.Linq;

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
            return _rules
                .FirstOrDefault(rule => rule.IsValidForNumber(number))
                ?.Apply();
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