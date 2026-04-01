using CalculatorApp;
using ConsoleApp2;
using Xunit;

namespace CalculatorTests;
public class CalculatorTests
{   public readonly Calculator calc = new Calculator() ;
    [Fact]
    private void Add_ShouldReturnCorrectSum()
    {
        Assert.Equal(10, calc.Add(7, 3));
    }

    [Fact]
    public void Divide_ByZero_ShouldReturnZero()
    {
        var calc = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calc.Divide(10, 0));
    }
}

