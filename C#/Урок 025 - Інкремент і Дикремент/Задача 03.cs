class Program
{
    static void Main()
    {
        int value = 10;
        value = value++ + --value;
        System.Console.WriteLine(value);
    }
}