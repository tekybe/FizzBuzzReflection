namespace FizzBuzzReflection.Services
{
    public static class RuleLoader
    {
        public static IEnumerable<IFizzBuzzRule> LoadRules()
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
