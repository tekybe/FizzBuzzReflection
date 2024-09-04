using FizzBuzzReflection.Rules;
using FluentAssertions;

namespace FizzBuzzTests
{
    public class FizzRuleTests
    {
        [Fact]
        public void Should_Return_Fizz_For_Multiples_Of_Three()
        {
            var rule = new FizzRule();
            rule.IsMatch(3).Should().BeTrue();
            rule.IsMatch(6).Should().BeTrue();
            rule.IsMatch(9).Should().BeTrue();
        }

        [Fact]
        public void Should_Not_Return_Fizz_For_Non_Multiples_Of_Three()
        {
            var rule = new FizzRule();
            rule.IsMatch(1).Should().BeFalse();
            rule.IsMatch(2).Should().BeFalse();
            rule.IsMatch(4).Should().BeFalse();
        }
    }
}
