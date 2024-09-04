using FizzBuzzReflection.Rules;
using FluentAssertions;

namespace FizzBuzzTests
{
    public class BuzzRuleTests
    {
        [Fact]
        public void Should_Return_Buzz_For_Multiples_Of_Five()
        {
            var rule = new BuzzRule();
            rule.IsMatch(5).Should().BeTrue();
            rule.IsMatch(10).Should().BeTrue();
            rule.IsMatch(20).Should().BeTrue();
        }

        [Fact]
        public void Should_Not_Return_Buzz_For_Non_Multiples_Of_Five()
        {
            var rule = new BuzzRule();
            rule.IsMatch(1).Should().BeFalse();
            rule.IsMatch(2).Should().BeFalse();
            rule.IsMatch(3).Should().BeFalse();
        }
    }
}
