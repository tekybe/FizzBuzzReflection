namespace FizzBuzzReflection.Contracts;

/// <summary>
/// Interface for FizzBuzz rules.
/// </summary>
public interface IFizzBuzzRule
{
    /// <summary>
    /// Determines whether the specified number matches the rule.
    /// </summary>
    /// <param name="number">The number to evaluate.</param>
    /// <returns><c>true</c> if the number matches the rule; otherwise, <c>false</c>.</returns>
    bool IsMatch(int number);

    /// <summary>
    /// Gets the result for the rule.
    /// </summary>
    /// <returns>The result string.</returns>
    string GetResult();
}
