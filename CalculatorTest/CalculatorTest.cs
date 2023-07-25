using CalculatorDomain;

namespace CalculatorTest;

public class CalculatorTest
{
    [Fact]
    public void Sum_Of_2_Plus_2_Should_Equal_4()
    {
        var calculator = new Calculator();
        var result = calculator.Sum(2, 2);
        if (result != 4)
        {
            throw new Exception($"The Sum(2,2) was expected to be 4 but it is {result}.");
        }
    }

    int Sum(int left, int right)
    {
        return left + right;
    }
}