using Calculator.Services;

namespace CalculatorTests;

public class CalculatorTests
{
    private CalculatorImplementation _calculator;
    public CalculatorTests()
    {
        _calculator = new CalculatorImplementation();
    }
    [Fact]
    public void ShouldSum5With10AndReturns15()
    {
        //Arrange
        int num1=5;
        int num2=10;
        //Act
        int result = _calculator.Sum(num1, num2);
        //Assert
        Assert.Equal(15, result);
    }
}