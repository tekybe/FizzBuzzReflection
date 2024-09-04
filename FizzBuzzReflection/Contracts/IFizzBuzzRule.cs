namespace FizzBuzzReflection.Contracts;

public interface IFizzBuzzRule
{
    bool IsMatch(int number);
    string GetResult();
}