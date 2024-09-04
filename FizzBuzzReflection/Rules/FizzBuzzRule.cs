using FizzBuzzReflection.Contracts;

namespace FizzBuzzReflection.Rules;

public class FizzBuzzRule : IFizzBuzzRule
{
    public bool IsMatch(int number) => number % 15 == 0;
    public string GetResult() => "FizzBuzz";
}


