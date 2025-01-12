class Program
{
    static void Main()
    {
        System.Console.Write("Enter number of rows of the triangle: ");
        int rows = System.Convert.ToInt32(System.Console.ReadLine());

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col <= row; col++)
                System.Console.Write("*");
            System.Console.WriteLine();
        }
    }
}