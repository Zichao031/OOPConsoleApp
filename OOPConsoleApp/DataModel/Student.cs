namespace OOPConsoleApp.DataModel;

public class Student: Person
{
    public List<Course> EnrolledCourses = new List<Course>();
    public double GPA { get; set; }
    
}