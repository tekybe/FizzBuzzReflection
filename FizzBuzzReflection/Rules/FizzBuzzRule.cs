using FizzBuzzReflection.Contracts;

namespace FizzBuzzReflection.Rules;

/// <summary>
/// Rule for numbers that are multiples of 15.
/// </summary>
public class FizzBuzzRule : IFizzBuzzRule
{
    /// <inheritdoc />
    public bool IsMatch(int number) => number % 15 == 0;

    /// <inheritdoc />
    public string GetResult() => "FizzBuzz";
}


