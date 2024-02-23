namespace OOPConsoleApp.DesignAndBuildClass;

public abstract class Person
{
    public int Id { get; set; }
    public string Name { get; set; }

    public abstract void Perform();
}