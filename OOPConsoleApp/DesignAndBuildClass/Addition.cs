namespace OOPConsoleApp.DesignAndBuildClass;

public static class Addition
{
    public static int AddNumbers(int a, int b)
    {
        return a + b;
    }
    public static double AddNumbers(double a, double b)
    {
        return a + b;
    }
    public static decimal AddNumbers(decimal a, decimal b)
    {
        return a + b;
    }

    public static int AddNumbers(params int[] nums)
    {
        var sum = 0;
        foreach (var n in nums)
        {
            sum += n;
        }
        return sum;
    }
}