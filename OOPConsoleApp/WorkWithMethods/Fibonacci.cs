namespace OOPConsoleApp.WorkWithMethods;

public static class Fibonacci
{
    public static void Get(int k)
    {
        int a = 1, b = 1, c = 1;
        k -= 2;
        while (k-- > 0)
        {
            c = a + b;
            a = b;
            b = c;
        }
        Console.WriteLine(c);
    }
}