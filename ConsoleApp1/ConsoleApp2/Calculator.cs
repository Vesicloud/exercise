

namespace CalculatorApp;
public class Calculator
{
    public double Add(double a, double b) => a + b;
    public double Subtract(double a, double b) => a - b;
    public double Multiply(double a, double b) => a * b;

    public double Divide(double a, double b)
    {
        if (b == 0) throw new DivideByZeroException();



        return a / b;
    }
    public double Power(double @base, double exponent) 
    {
        return Math.Pow(@base, exponent); 
    }

    public double SquareRoot(double number)
    {
        if (number < 0) throw new ArgumentException("Cannot square root a negative!");
        return Math.Sqrt(number); 
    }
}