class Program
{
    static void Main()
    {
        System.Console.Write("Enter number of rows: ");
        int rows = System.Convert.ToInt32(System.Console.ReadLine());

        System.Console.Write("Enter number of columns: ");
        int columns = System.Convert.ToInt32(System.Console.ReadLine());

        System.Console.Write("Enter character to output: ");
        char ch = System.Convert.ToChar(System.Console.ReadLine());

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
                System.Console.Write(ch);
            System.Console.WriteLine();
        }
    }
}