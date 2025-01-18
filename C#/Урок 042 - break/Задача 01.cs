class Program
{
    static void Main()
    {
        while (true)
        {
            System.Console.Write("Enter a number (0 to stop): ");
            int number = System.Convert.ToInt32(System.Console.ReadLine());

            if (number == 0)
                break;

            System.Console.WriteLine($"{number}^2 = {number * number}");
        }
    }
}