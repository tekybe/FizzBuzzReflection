using FizzBuzzReflection.Rules;
using FluentAssertions;

namespace FizzBuzzTests
{
    public class BuzzRuleTests
    {
        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void Should_Return_Buzz_For_Multiples_Of_Five(int number)
        {
            var rule = new BuzzRule();
            rule.IsMatch(number).Should().BeTrue();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void Should_Not_Return_Buzz_For_Non_Multiples_Of_Five(int number)
        {
            var rule = new BuzzRule();
            rule.IsMatch(number).Should().BeFalse();
        }
    }
}
