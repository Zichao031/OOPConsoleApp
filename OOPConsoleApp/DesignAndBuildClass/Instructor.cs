namespace OOPConsoleApp.DesignAndBuildClass;

public class Instructor : Person
{
    public override void Perform()
    {
        Console.WriteLine("override the abstract method for Instructor");
    }
}