using FizzBuzzReflection.Contracts;

namespace FizzBuzzReflection.Services
{
    /// <summary>
    /// Generates the FizzBuzz sequence using dynamically loaded rules.
    /// </summary>
    public class FizzBuzz
    {
        private readonly IEnumerable<IFizzBuzzRule> _rules;

        /// <summary>
        /// Initializes a new instance of the <see cref="FizzBuzz"/> class.
        /// </summary>
        public FizzBuzz()
        {
            _rules = RuleLoader.LoadRules();
        }

        /// <summary>
        /// Generates the FizzBuzz sequence for the specified range.
        /// </summary>
        /// <param name="start">The start of the range.</param>
        /// <param name="end">The end of the range.</param>
        /// <returns>A list of FizzBuzz results.</returns>
        public List<string> Generate(int start, int end)
        {
            var result = new List<string>();
            for (int i = start; i <= end; i++)
            {
                result.Add(GetFizzBuzzValue(i));
            }
            return result;
        }

        /// <summary>
        /// Gets the FizzBuzz value for a given number.
        /// </summary>
        /// <param name="number">The number to evaluate.</param>
        /// <returns>The FizzBuzz value.</returns>
        private string GetFizzBuzzValue(int number)
        {
            var rule = _rules.FirstOrDefault(r => r.IsMatch(number));
            return rule != null ? rule.GetResult() : number.ToString();
        }
    }
}

