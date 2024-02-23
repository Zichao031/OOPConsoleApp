using OOPConsoleApp.Interfaces;

namespace OOPConsoleApp.DataModel;

public class Instructor : Person, IInstructorService
{
    public string Department { get; set; }
    public bool IsHeadOfDepartmant { get; set; }
    public DateTime JoinDate { get; set; }
    
    public Instructor(DateTime birthdate, decimal salary, string department, bool isHeadOfDepartmant, DateTime joinDate) : base(birthdate, salary)
    {
        Department = department;
        IsHeadOfDepartmant = isHeadOfDepartmant;
        JoinDate = joinDate;
    }
    
    public override int CalculateAge()
    {
        return DateTime.Now.Year - Birthdate.Year;
    }
    public decimal CalculateBonus()
    {
        decimal bonus = CalculateYearsOfExperience() * 1000;
        return Salary + bonus;
    }
    public int CalculateYearsOfExperience()
    {
        return DateTime.Now.Year - JoinDate.Year;
    }
}