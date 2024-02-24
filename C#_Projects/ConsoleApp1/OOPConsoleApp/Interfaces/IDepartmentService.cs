using OOPConsoleApp.DataModel;

namespace OOPConsoleApp.Interfaces;

public interface IDepartmentService
{
    Instructor HeadInstructor { get; set; }
    decimal Budget { get; set; }
    List<Course> OfferedCourses { get; set; }
}