using CalculatorDomain;

namespace CalculatorTest;

public class CalculatorTest
{
    [Fact]
    public void Test_2_Plus_2_Equals_4()
    {
        var calculator = new Calculator();
        if (calculator.Sum(2, 2) != 4)
        {
            throw new Exception();
        }
    }
}