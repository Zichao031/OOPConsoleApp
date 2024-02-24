namespace OOPConsoleApp.WorkWithMethods;

public static class ReverseArray
{
    

    public static int[] GenerateNumbers()
    {
        List<int> array = new List<int>();
        Console.Write("Type in your array: ");
        string[] strs = Console.ReadLine().Split(' ');
        foreach (string s in strs)
        {
            array.Add(Convert.ToInt32(s));
        }

        return array.ToArray();
    }

    public static void Reverse(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    public static void PrintNumbers(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        int[] numbers = GenerateNumbers();
        Reverse(numbers);
        PrintNumbers(numbers);
    }
}