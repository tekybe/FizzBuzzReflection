using FizzBuzzReflection.Contracts;
using System.Reflection;

namespace FizzBuzzReflection.Services
{
    /// <summary>
    /// Helper class for loading FizzBuzz rules using reflection.
    /// </summary>
    public static class RuleLoader
    {
        /// <summary>
        /// Loads all types that implement the <see cref="IFizzBuzzRule"/> interface from the current assembly.
        /// </summary>
        /// <returns>A collection of <see cref="IFizzBuzzRule"/> instances.</returns>
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
