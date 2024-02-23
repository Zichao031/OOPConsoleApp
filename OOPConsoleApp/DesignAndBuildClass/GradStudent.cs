namespace OOPConsoleApp.DesignAndBuildClass;

public class GradStudent : Student
{
    public override void CheckGrades()
    {
        base.CheckGrades();
        Console.WriteLine($"Student {Name} is a graduate student.");
    }

    public GradStudent(int id, string name, string email, string phone) : base(id, name, email, phone)
    {
    }
}