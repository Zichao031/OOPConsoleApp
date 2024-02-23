using OOPConsoleApp.DataModel;

namespace OOPConsoleApp.Interfaces;

public interface IInstructorService: IPersonService<Instructor>
{
    bool IsHeadOfDepartmant(Instructor obj);
    decimal CalculateBonus(Instructor obj);
    int CalculateYearsOfExperience(Instructor obj);
}