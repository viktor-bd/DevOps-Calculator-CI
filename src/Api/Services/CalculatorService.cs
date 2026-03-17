namespace Api.Services;

public class CalculatorService : ICalculatorService
{
    public double Add(double a, double b) => a + b;
    public double Subtract(double a, double b) => a - b;
    public double Multiply(double a, double b) => a * b;
    public double Divide(double a, double b)
    {
        if (b == 0) throw new ArgumentException("Division by zero is not allowed!");
        return a / b;
    }
}
