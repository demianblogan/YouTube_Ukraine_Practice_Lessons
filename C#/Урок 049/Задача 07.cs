class Program
{
    static void Main()
    {
        // Create array:
        int[,] array = new int[3, 4]
        {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

        // Output array:
        System.Console.WriteLine("Here's your array:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                System.Console.Write(array[i, j] + "\t");
            System.Console.WriteLine();
        }
        System.Console.WriteLine();

        // Calculate and show sums of elements in each row:
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sumOfRowElements = 0;
            for (int j = 0; j < array.GetLength(1); j++)
                sumOfRowElements += array[i, j];

            System.Console.WriteLine($"Sum of element in row #{i} = {sumOfRowElements}");
        }

        System.Console.WriteLine();

        // Calculate and show sums of elements in each column:
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int sumOfColumnElements = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                sumOfColumnElements += array[i, j];

            System.Console.WriteLine($"Sum of element in column #{j} = {sumOfColumnElements}");
        }
    }
}