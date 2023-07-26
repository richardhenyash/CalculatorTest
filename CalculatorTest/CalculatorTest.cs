using CalculatorDomain;
using FluentAssertions;

namespace CalculatorTest;

public class CalculatorTests
{
    [Fact]
    public void Sum_Of_2_And_2_Should_Equal_4()
        => new Calculator()
            .Sum(2, 2)
            .Should().Be(4);
}