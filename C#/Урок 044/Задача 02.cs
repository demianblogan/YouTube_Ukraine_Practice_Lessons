class Program
{
    static void Main()
    {
    Menu:
        System.Console.WriteLine("1 - Say Hello");
        System.Console.WriteLine("2 - Show date");
        System.Console.WriteLine("3 - Quit");

        System.Console.Write("Enter a number: ");
        int menuItem = System.Convert.ToInt32(System.Console.ReadLine());

        if (menuItem == 1)
        {
            System.Console.WriteLine("HELLO!");
            goto Menu;
        }

        if (menuItem == 2)
        {
            System.Console.WriteLine("It's 12th of January 2025.");
            goto Menu;
        }

        if (menuItem != 3)
        {
            System.Console.WriteLine("Incorrect number");
            goto Menu;
        }
    }
}