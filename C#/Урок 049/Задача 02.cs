class Program
{
    static void Main()
    {
        // Create array:
        int[,] array =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Output array:
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                System.Console.Write(array[i, j] + " ");
            System.Console.WriteLine();
        }

        // Calculate sum:
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                sum += array[i, j];
        }

        // Output sum:
        System.Console.WriteLine($"Sum of all array's elements = {sum}");
    }
}