using FizzBuzzReflection.Rules;
using FluentAssertions;

namespace FizzBuzzTests
{
    public class FizzRuleTests
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void Should_Return_Fizz_For_Multiples_Of_Three(int number)
        {
            var rule = new FizzRule();
            rule.IsMatch(number).Should().BeTrue();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        public void Should_Not_Return_Fizz_For_Non_Multiples_Of_Three(int number)
        {
            var rule = new FizzRule();
            rule.IsMatch(number).Should().BeFalse();
        }
    }
}
