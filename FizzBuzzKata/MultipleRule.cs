namespace FizzBuzzKata
{
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
}