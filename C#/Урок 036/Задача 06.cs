class Program
{
    static void Main()
    {
        const int START_NEW_GAME = 1;
        const int LOAD_GAME = 2;
        const int OPTIONS = 3;
        const int CREDITS = 4;
        const int GAME_EXIT = 5;

        System.Console.WriteLine($"{START_NEW_GAME} - Start new game");
        System.Console.WriteLine($"{LOAD_GAME} - Load game");
        System.Console.WriteLine($"{OPTIONS} - Options");
        System.Console.WriteLine($"{CREDITS} - Credits");
        System.Console.WriteLine($"{GAME_EXIT} - Exit");

        System.Console.Write("Enter number: ");
        int menuItem = System.Convert.ToInt32(System.Console.ReadLine());

        if (menuItem == START_NEW_GAME)
            System.Console.WriteLine("New game is started");
        else if (menuItem == LOAD_GAME)
            System.Console.WriteLine("Game is loaded");
        else if (menuItem == OPTIONS)
            System.Console.WriteLine("There isn't any options :(");
        else if (menuItem == CREDITS)
            System.Console.WriteLine("Author of this game Demian Blogan");
        else if (menuItem == GAME_EXIT)
            System.Console.WriteLine("Game is closing");
    }
}