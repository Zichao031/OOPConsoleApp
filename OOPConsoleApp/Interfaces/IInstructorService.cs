using OOPConsoleApp.DataModel;

namespace OOPConsoleApp.Interfaces;

public interface IInstructorService: IPersonService
{
    string Department { get; set; }
    bool IsHeadOfDepartmant { get; set; }
    decimal CalculateBonus();
    int CalculateYearsOfExperience();
}