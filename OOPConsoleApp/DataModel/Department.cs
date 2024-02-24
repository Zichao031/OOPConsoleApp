using OOPConsoleApp.Interfaces;

namespace OOPConsoleApp.DataModel;

public class Department : IDepartmentService
{
    public Instructor HeadInstructor { get; set; }
    public decimal Budget { get; set; }
    public List<Course> OfferedCourses { get; set; }

    public Department(Instructor headInstructor, decimal budget, List<Course> offeredCourses)
    {
        HeadInstructor = headInstructor;
        Budget = budget;
        OfferedCourses = offeredCourses;
    }
}