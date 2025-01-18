class Program
{
    static void Main()
    {
        string[][] bookcase =
        {
            // shelf #1:
            [
                "One of the Kind",
                "The Lord of the Rings",
            ],
            
            // shelf #2:
            [
                "The Last Hope",
                "The Batman",
                "Never Enough",
            ],
            
            // shelf #3:
            [
                "Trying be like others",
                "12 Rules of Life",
                "Stop looking back",
                "That One Lover",
            ],
        };

        System.Console.WriteLine("All books from our library:");
        for (int i = 0; i < bookcase.Length; i++)
        {
            System.Console.WriteLine($"\tShelf #{i + 1}:");
            for (int j = 0; j < bookcase[i].Length; j++)
                System.Console.WriteLine($"\t\tBook #{j + 1}: " + bookcase[i][j]);
        }
        System.Console.WriteLine();

        System.Console.Write("What book are you looking for?: ");
        string userBook = System.Console.ReadLine();

        bool libraryHasTheBook = false;
        int shelfWithUserBook = 0;
        for (int i = 0; i < bookcase.Length; i++)
        {
            for (int j = 0; j < bookcase[i].Length; j++)
            {
                if (userBook == bookcase[i][j])
                {
                    shelfWithUserBook = i;
                    libraryHasTheBook = true;
                    break;
                }
            }
        }

        if (libraryHasTheBook)
            System.Console.WriteLine($"We have your book. It's on a shelf #{shelfWithUserBook + 1}");
        else
            System.Console.WriteLine("Sorry. We don't have your book");
    }
}