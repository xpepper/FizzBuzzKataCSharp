namespace FizzBuzzKata
{
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