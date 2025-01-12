class Program
{
    static void Main()
    {
        int rhombusHeight;
        do
        {
            System.Console.Write("Enter rhombus's height (it must be an odd & positive number): ");
            rhombusHeight = System.Convert.ToInt32(System.Console.ReadLine());

        } while (rhombusHeight % 2 == 0 || rhombusHeight <= 0);

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