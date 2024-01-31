using System.Globalization;

namespace Calculator.Services
{
    public class CalculatorImplementation
    {
        public int Sum(int sum1, int sum2)
        {
            return sum1 + sum2;
        }
        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
        public bool isOdd(int num)
        {
            return num % 2 == 0;
        }
    }
}