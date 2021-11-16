namespace FizzBuzzKata
{
    public interface IRule
    {
        string Apply();
        bool IsValidForNumber(int number);
    }
}