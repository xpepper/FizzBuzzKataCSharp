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
            return _rules
                .Select(rule => rule.Apply())
                .Aggregate(((acc, each) => acc + each));
        }

        public bool IsValidForNumber(int number)
        {
            return _rules.All(rule => rule.IsValidForNumber(number));
        }
    }
}