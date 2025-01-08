class Program
{
    static void Main()
    {
        for (int number = 1, value = 2; number <= 20; number++, value *= 2)
            System.Console.WriteLine(value);
    }
}