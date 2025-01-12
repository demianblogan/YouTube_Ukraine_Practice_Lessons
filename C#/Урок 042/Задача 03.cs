class Program
{
    static void Main()
    {
        while (true)
        {
            System.Console.WriteLine("1 - Start game");
            System.Console.WriteLine("2 - Load game");
            System.Console.WriteLine("3 - Exit");

            int menuItem = System.Convert.ToInt32(System.Console.ReadLine());

            if (menuItem == 1)
                System.Console.WriteLine("Game is started");
            else if (menuItem == 2)
                System.Console.WriteLine("Game is loaded");
            else if (menuItem == 3)
                break;
        }
    }
}