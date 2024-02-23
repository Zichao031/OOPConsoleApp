namespace OOPConsoleApp.DesignAndBuildClass;

public class UndergradStudent : Student
{
    public UndergradStudent(int id, string name, string email, string phone) : base(id, name, email, phone) {}
  
    public override void CheckGrades()
    {
        base.CheckGrades();
        Console.WriteLine($"Student {Name} is a undergrad student.");
    }
}