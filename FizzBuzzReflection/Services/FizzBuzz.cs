using FizzBuzzReflection.Contracts;
using System.Reflection;

namespace FizzBuzzReflection.Services
{
    public class FizzBuzz
    {
        private readonly IEnumerable<IFizzBuzzRule> _rules;

        public FizzBuzz()
        {
            _rules = LoadRules();
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

        private IEnumerable<IFizzBuzzRule> LoadRules()
        {
            var ruleType = typeof(IFizzBuzzRule);
            var ruleTypes = Assembly.GetExecutingAssembly()
                                    .GetTypes()
                                    .Where(t => ruleType.IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

            return ruleTypes.Select(Activator.CreateInstance)
                            .Cast<IFizzBuzzRule>()
                            .ToList();
        }
    }
}

