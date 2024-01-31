using Calculator.Services;

CalculatorImplementation c = new CalculatorImplementation();

int num1 = 5;
int num2 = 15;

Console.WriteLine($"{num1} + {num2} = {c.Sum(num1, num2)}");