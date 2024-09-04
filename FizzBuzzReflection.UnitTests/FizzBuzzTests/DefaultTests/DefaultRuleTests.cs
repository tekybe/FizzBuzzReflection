using FizzBuzzReflection.Rules;
using FluentAssertions;

namespace FizzBuzzTests
{
    public class DefaultRuleTests
    {
        [Fact]
        public void Should_Return_Number_If_No_Rule_Matches()
        {
            var fizzBuzz = new FizzBuzz();
            fizzBuzz.Generate(1, 1)[0].Should().Be("1");
            fizzBuzz.Generate(2, 2)[0].Should().Be("2");
            fizzBuzz.Generate(4, 4)[0].Should().Be("4");
        }
    }
}
