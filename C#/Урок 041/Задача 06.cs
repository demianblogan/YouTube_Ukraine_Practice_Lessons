class Program
{
    static void Main()
    {
        int rombusHeight = 5;

        int charsInRow = 1;
        int spacesInRow = rombusHeight / 2;

        for (int row = 0 ; row < rombusHeight; row++)
        {
            for (int i = 0; i < spacesInRow; i++)
                System.Console.Write(" ");

            for (int i = 0; i < charsInRow; i++)
                System.Console.Write("*");

            System.Console.WriteLine();

            if (row < rombusHeight / 2)
            {
                spacesInRow--;
                charsInRow += 2;
            }
            else
            {
                spacesInRow++;
                charsInRow -= 2;
            }
        }
    }
}