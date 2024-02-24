using OOPConsoleApp.Interfaces;

namespace OOPConsoleApp.DataModel;

public class Student: Person, IStudentService
{

    public List<Course> EnrolledCourses { get; set; }
    public Student(DateTime birthdate, decimal salary, List<Course> enrolledCourse) : base(birthdate, salary)
    {
        EnrolledCourses = enrolledCourse;
    }

    public override int CalculateAge()
    {
        return DateTime.Now.Year - Birthdate.Year;
    }
    
    public double CalculateGPA(Dictionary<string, char> courseGrades)
    {
        int totalPoints = 0;
        int totalCourse = 0;
        foreach (var grade in courseGrades.Values)
        {
            totalPoints += GetGradePoints(grade);
            totalCourse++;
        }

        return totalCourse > 0 ? (double)totalPoints / totalCourse : 0.0;
    }

    private int GetGradePoints(char grade)
    {
        switch (grade)
        {
            case 'A': return 4;
            case 'B': return 3;
            case 'C': return 2;
            case 'D': return 1;
            case 'E': return 0;
            default: return 0;
        }
    }
}