using System.Linq;

namespace FizzBuzzKata
{
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
}