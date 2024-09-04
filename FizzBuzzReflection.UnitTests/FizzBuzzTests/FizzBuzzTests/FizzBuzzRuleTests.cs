using FizzBuzzReflection.Rules;
using FluentAssertions;

namespace FizzBuzzTests
{
    public class FizzBuzzRuleTests
    {
        [Fact]
        public void Should_Return_FizzBuzz_For_Multiples_Of_Fifteen()
        {
            var rule = new FizzBuzzRule();
            rule.IsMatch(15).Should().BeTrue();
            rule.IsMatch(30).Should().BeTrue();
            rule.IsMatch(45).Should().BeTrue();
        }

        [Fact]
        public void Should_Not_Return_FizzBuzz_For_Non_Multiples_Of_Fifteen()
        {
            var rule = new FizzBuzzRule();
            rule.IsMatch(1).Should().BeFalse();
            rule.IsMatch(2).Should().BeFalse();
            rule.IsMatch(3).Should().BeFalse();
        }
    }
}
