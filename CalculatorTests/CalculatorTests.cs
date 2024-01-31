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
    [Fact]
    public void ShouldSubtract15With5AndReturns10()
    {
        int num1=15;
        int num2=5;
        int result = _calculator.Subtraction(num1, num2);
        Assert.Equal(10, result);
    }
    [Fact]
    public void ShouldVerifyIf4IsOddAndReturnTrue()
    {
        int num = 4;
        bool result = _calculator.isOdd(num);
        Assert.True(result);
    }
}