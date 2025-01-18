class Program
{
    static void Main()
    {
        System.Console.Write("Enter a number: ");
        int number = System.Convert.ToInt32(System.Console.ReadLine());

        if (number == 0)
        {
            System.Console.WriteLine("0 has 1 digit");
        }
        else
        {
            int digitsCount = 0;
            for (int tempNumber = number; tempNumber > 0; tempNumber /= 10)
                digitsCount++;

            System.Console.WriteLine($"{number} has {digitsCount} digit(s)");
        }
    }
}
