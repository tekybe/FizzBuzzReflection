using FizzBuzzReflection.Contracts;

namespace FizzBuzzReflection.Services
{
    public class FizzBuzz
    {
        private readonly IEnumerable<IFizzBuzzRule> _rules;

        public FizzBuzz()
        {
            _rules = RuleLoader.LoadRules();
        }

        public List<string> Generate(int start, int end)
        {
            var result = new List<string>();
            for (int i = start; i <= end; i++)
            {
                result.Add(GetFizzBuzzValue(i));
            }
            return result;
        }

        private string GetFizzBuzzValue(int number)
        {
            var rule = _rules.FirstOrDefault(r => r.IsMatch(number));
            return rule != null ? rule.GetResult() : number.ToString();
        }
    }
}

