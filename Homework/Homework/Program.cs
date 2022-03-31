EmployeeDetails financeManager = new EmployeeDetails(new FinanceManager(50));
EmployeeDetails projectManager = new EmployeeDetails(new ProjectManager(50));   //In here dependency inversion principle added
EmployeeDetails marketingManager = new EmployeeDetails(new MarketingManager(50));


Console.WriteLine("If the finance manager works 50 hours he/she charges $" + financeManager.getSalary());
Console.WriteLine("If the project manager works 50 hours he/she charges $" + projectManager.getSalary());
Console.WriteLine("If the marketing manager works 50 hours he/she charges $" + marketingManager.getSalary());





public interface ISalaryCalculater
{
    double CalculateSalary();                 
}

public static class CalculateHelper         // This helper class is for single responsibility principle
{
    public static double CalculateSalary(int hoursWorked,int perHour)  
    {
        return hoursWorked * perHour;  
    }
}

public class FinanceManager : ISalaryCalculater
{
    private int _hoursWorked;
    private const int perHour = 17;   //This perHour amount is different for each employee
    public FinanceManager(int hoursWorked)
    {
        _hoursWorked = hoursWorked;
    }

    public double CalculateSalary()
    {
        return CalculateHelper.CalculateSalary(_hoursWorked, perHour);
    }

}



public class ProjectManager: ISalaryCalculater
{
    private int _hoursWorked;
    private const int perHour = 25;
    public ProjectManager(int hoursWorked)
    {
        _hoursWorked = hoursWorked;
    }

    public double CalculateSalary()
    {
        return CalculateHelper.CalculateSalary(_hoursWorked, perHour);
    }

}

public class MarketingManager: ISalaryCalculater
{
    private int _hoursWorked;
    private const int perHour = 20;
    public MarketingManager(int hoursWorked)
    {
        _hoursWorked = hoursWorked;
    }

    public double CalculateSalary()
    {
        return CalculateHelper.CalculateSalary(_hoursWorked, perHour);
    }

}





public class EmployeeDetails
{
    private readonly ISalaryCalculater _salaryCalculater;

    public EmployeeDetails(ISalaryCalculater salaryCalculater)
    {
        _salaryCalculater = salaryCalculater;
      
    }

    public double getSalary()
    {
        return _salaryCalculater.CalculateSalary();
    }
}


