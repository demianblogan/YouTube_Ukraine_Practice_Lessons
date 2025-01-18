class Program
{
    static void Main()
    {
        int min = 1, max = 50;

        System.Console.Write($"Enter a number between {min} and {max}: ");
        int userNumber = System.Convert.ToInt32(System.Console.ReadLine());

        for (int number = min; number <= max; number++)
        {
            if (number == userNumber)
                continue;

            System.Console.Write(number + " ");
        }
    }
}