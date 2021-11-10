using static System.Linq.Enumerable;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string Say(int number)
        {
            if (number % 3 == 0) return "Fizz";
            return number.ToString();
        }
    }
}