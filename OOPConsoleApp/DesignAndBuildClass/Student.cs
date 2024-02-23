namespace OOPConsoleApp.DesignAndBuildClass;

public class Student : Person
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string Email { get; set; }
    public string Phone { get; set; }
    
    public Student(int id, string name, string email, string phone) 
    {
        Id = id;
        Name = name;
        Email = email;
        Phone = phone;
    }
    
    public override void Perform()
    {
        Console.WriteLine("overriding abstract base method for student class instance");
    }
    
    public virtual void CheckGrades()
    {
        Console.WriteLine("Student's grade is A+");
    }
}