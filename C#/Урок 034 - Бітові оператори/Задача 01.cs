class Program
{
    static void Main()
    {
        byte number = 101;

        System.Console.WriteLine($"Your number is {((number & 1) == 1 ? "odd" : "even")}");
    }
}