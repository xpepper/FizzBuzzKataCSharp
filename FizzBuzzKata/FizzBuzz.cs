namespace FizzBuzzKata
{
    public static class FizzBuzz
    {
        public static string Say(int number)
        {
            if (number % 3 == 0)
                return "Fizz";
            if (number == 5)
                return "Buzz";
            return number.ToString();
        }
    }
}