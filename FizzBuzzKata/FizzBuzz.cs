namespace FizzBuzzKata
{
    public static class FizzBuzz
    {
        public static string Say(int number)
        {
            if (number.IsMultipleOf(3) && number.IsMultipleOf(5))
                return "FizzBuzz";
            if (number.IsMultipleOf(3))
                return "Fizz";
            if (number.IsMultipleOf(5))
                return "Buzz";
            return number.ToString();
        }

        private static bool IsMultipleOf(this int number, int dividend)
        {
            return number % dividend == 0;
        }
    }
}