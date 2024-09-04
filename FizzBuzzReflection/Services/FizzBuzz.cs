using FizzBuzzReflection.Contracts;

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
            throw new NotImplementedException();
        }

        private string GetFizzBuzzValue()
        {
            throw new NotImplementedException();
        }

        private IEnumerable<IFizzBuzzRule> LoadRules()
        {
            throw new NotImplementedException();
        }
    }
}

