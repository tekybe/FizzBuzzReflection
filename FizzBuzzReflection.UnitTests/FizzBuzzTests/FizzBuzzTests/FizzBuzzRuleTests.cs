using FizzBuzzReflection.Rules;
using FluentAssertions;

namespace FizzBuzzTests
{
    public class FizzBuzzRuleTests
    {
        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void Should_Return_FizzBuzz_For_Multiples_Of_Fifteen(int number)
        {
            var rule = new FizzBuzzRule();
            rule.IsMatch(number).Should().BeTrue();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void Should_Not_Return_FizzBuzz_For_Non_Multiples_Of_Fifteen(int number)
        {
            var rule = new FizzBuzzRule();
            rule.IsMatch(number).Should().BeFalse();
        }
    }
}
