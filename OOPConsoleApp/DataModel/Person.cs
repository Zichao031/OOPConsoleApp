using OOPConsoleApp.Interfaces;

namespace OOPConsoleApp.DataModel;

public abstract class Person : IPersonService
{
    public DateTime Birthdate { get; set; }
    public decimal Salary { get; set; }
    private List<string> Addresses { get; set; }

    public Person(DateTime birthdate, decimal salary)
    {
        Birthdate = birthdate;
        Salary = salary;
        Addresses = new List<string>();
    }

    public abstract int CalculateAge();

    public decimal CalculateSalary()
    {
        if (Salary < 0)
        {
            throw new ArgumentException("Salary cannot be negative");
        }

        return Salary;
    }

    public List<string> GetAddresses()
    {
        return Addresses;
    }
}