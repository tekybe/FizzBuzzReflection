using FizzBuzzReflection.Contracts;

namespace FizzBuzzReflection.Rules;

public class FizzRule : IFizzBuzzRule
{
    public bool IsMatch(int number) => number % 3 == 0;
    public string GetResult() => "Fizz";
}

