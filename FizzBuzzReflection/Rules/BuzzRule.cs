using FizzBuzzReflection.Contracts;

namespace FizzBuzzReflection.Rules;

/// <summary>
/// Rule for numbers that are multiples of 5.
/// </summary>
public class BuzzRule : IFizzBuzzRule
{
    /// <inheritdoc />
    public bool IsMatch(int number) => number % 5 == 0;

    /// <inheritdoc />
    public string GetResult() => "Buzz";
}

