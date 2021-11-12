namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string Say(int number)
        {
            if (isMultipleOfThreeAndFive(number)) return "FizzBuzz";
            if (number % 3 == 0) return "Fizz";
            if (number % 5 == 0) return "Buzz";
            return number.ToString();
        }

        private static bool isMultipleOfThreeAndFive(int number) => number % 15 == 0;
    }
}