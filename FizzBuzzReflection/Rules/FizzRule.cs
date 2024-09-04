using FizzBuzzReflection.Contracts;

namespace FizzBuzzReflection.Rules;

/// <summary>
/// Rule for numbers that are multiples of 3.
/// </summary>
public class FizzRule : IFizzBuzzRule
{
    /// <inheritdoc />
    public bool IsMatch(int number) => number % 3 == 0;

    /// <inheritdoc />
    public string GetResult() => "Fizz";
}

