namespace OOPConsoleApp.Interfaces;

public interface IPersonService
{
    int CalculateAge();
    decimal CalculateSalary();
    List<string> GetAddresses();
}