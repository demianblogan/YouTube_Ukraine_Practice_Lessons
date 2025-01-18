class Program
{
    static void Main()
    {
        int rhombusHeight = 11;

        int charsInRow = 1;
        int spacesInRow = rhombusHeight / 2;

        for (int row = 0; row < rhombusHeight; row++)
        {
            for (int i = 0; i < spacesInRow; i++)
                System.Console.Write(" ");

            for (int i = 0; i < charsInRow; i++)
                System.Console.Write("*");

            System.Console.WriteLine();

            if (row < rhombusHeight / 2)
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
