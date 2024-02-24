using OOPConsoleApp.DataModel;

namespace OOPConsoleApp.Interfaces;

public interface IStudentService : IPersonService
{
    List<Course> EnrolledCourses { get; set; }
    double CalculateGPA(Dictionary<string, char> courseGrades);
}