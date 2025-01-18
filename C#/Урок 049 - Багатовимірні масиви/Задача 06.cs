class Program
{
    static void Main()
    {
        // Enter array's sizes:
        int rows, columns;
        do
        {
            System.Console.Write("Enter sizes of the arrays (it's two numbers that must be greater that 0): ");
            rows = System.Convert.ToInt32(System.Console.ReadLine());
            columns = System.Convert.ToInt32(System.Console.ReadLine());
        }
        while (rows <= 0 || columns <= 0);

        // Create array:
        int[,] array = new int[rows, columns];

        // Enter array's elements:
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                System.Console.WriteLine($"Enter value of array[{i}, {j}]: ");
                array[i, j] = System.Convert.ToInt32(System.Console.ReadLine());
            }
        }

        // Output array:
        System.Console.WriteLine("Here's your array:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                System.Console.Write(array[i, j] + " ");
            System.Console.WriteLine();
        }
    }
}