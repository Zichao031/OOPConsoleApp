namespace OOPConsoleApp.DataModel;

public class Department
{
    public Instructor head { get; set; }
    public DateTime SchoolYear { get; set; }
    public List<Course> OfferedCourses { get; set; } 
}