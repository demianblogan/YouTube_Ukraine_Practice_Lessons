class Program
{
    static void Main()
    {
        int computerNumber = 27;
        int userNumber;
        int triesCount = 1;

        System.Console.Write("Try to guess computer number (from 0 to 100): ");
        userNumber = System.Convert.ToInt32(System.Console.ReadLine());
        while (userNumber != computerNumber)
        {
            System.Console.Write("You're wrong. Try again: ");
            userNumber = System.Convert.ToInt32(System.Console.ReadLine());
            triesCount++;
        }

        System.Console.WriteLine($"You win! Number of tries: {triesCount}");
    }
}