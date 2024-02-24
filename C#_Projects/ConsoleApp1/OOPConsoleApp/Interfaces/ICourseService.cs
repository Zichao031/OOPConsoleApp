using OOPConsoleApp.DataModel;

namespace OOPConsoleApp.Interfaces;

public interface ICourseService
{
    List<Student> EnrolledStudents { get; set; }
}