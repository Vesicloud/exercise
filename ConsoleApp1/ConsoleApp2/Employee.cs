public class Employee
{    
    private decimal salary;
    public Employee(decimal salary)
    {
        this.salary = salary;
    }
    public Employee()
    {
        this.salary = 30000m;
    }
   
    public decimal IncomeTax()
    {

   
        int vacationDays = VacationDays();
        decimal tax = this.salary * 0.3m * (20- vacationDays);
        return tax;
    }
    public double CalculateBonus(double salary) 
    {
        return salary * 0.1; // 10% bonus
    }

    private int VacationDays() => 21;
}