namespace OOPConsoleApp.Interfaces;

public interface IPersonService<T> where T: class
{
    int CalculateAge(T obj);
    decimal CalculateSalary(T obj);
    string GetAddress(T obj);
}