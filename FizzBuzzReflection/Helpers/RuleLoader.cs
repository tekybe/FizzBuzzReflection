using FizzBuzzReflection.Contracts;
using System.Reflection;

namespace FizzBuzzReflection.Services
{
    public static class RuleLoader
    {
        public static IEnumerable<IFizzBuzzRule> LoadRules()
        {
            var ruleType = typeof(IFizzBuzzRule);
            return Assembly.GetExecutingAssembly()
                           .GetTypes()
                           .Where(t => ruleType.IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                           .Select(Activator.CreateInstance)
                           .Cast<IFizzBuzzRule>()
                           .ToList();
        }
    }
}
