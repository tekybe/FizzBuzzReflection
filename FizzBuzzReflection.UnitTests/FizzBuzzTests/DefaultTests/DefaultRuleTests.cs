using FizzBuzzReflection.Services;
using FluentAssertions;

namespace FizzBuzzTests
{
    public class DefaultRuleTests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        public void Should_Return_Number_If_No_Rule_Matches(int number, string expected)
        {
            var fizzBuzz = new FizzBuzz();
            fizzBuzz.Generate(number, number)[0].Should().Be(expected);
        }
    }
}
