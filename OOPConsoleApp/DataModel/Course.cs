using OOPConsoleApp.Interfaces;

namespace OOPConsoleApp.DataModel;

public class Course: ICourseService
{
    public List<Student> EnrolledStudents { get; set; }
}