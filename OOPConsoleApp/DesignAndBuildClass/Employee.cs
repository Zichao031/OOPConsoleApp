namespace OOPConsoleApp.DesignAndBuildClass;

public abstract class Employee
{
    public int Id { get; set; }
    public int Name { get; set; }

    public abstract void GetInfo();
}