class Program
{
    static void Main()
    {
        for (int number = 1, value = 2; number <= 20; number++, value *= value)
            System.Console.WriteLine(value);
    }
}