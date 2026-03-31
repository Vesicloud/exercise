using Xunit;
using ConsoleApp2; 
namespace ConsoleApp2.Tests;

public class ExerciseTests
{
    
    [Fact]
    public void Tool_GetFullDescription_ShouldReturnCombinedString()
    {
        
        var tool = new Tool { Brand = "Versace", Name = "Hammer" };

      
        var result = tool.GetFullDescription();

   
        Assert.Equal("Versace Hammer", result);
    }


    [Fact]
    public void Employee_CalculateBonus_ShouldReturnTenPercent()
    {

        var emp = new Employee();
        double salary = 1000;

     
        double bonus = emp.CalculateBonus(salary);


        Assert.Equal(100, bonus);
    }

    
    [Fact]
    public void MathHelper_Add_ShouldReturnCorrectSum()
    {
     
        int result = MathHelper.Add(5, 5);

   
        Assert.Equal(10, result);
    }
}