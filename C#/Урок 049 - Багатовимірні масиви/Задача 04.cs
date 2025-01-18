class Program
{
    static void Main()
    {
        // Create array:
        int[,] array = new int[3, 4]
        {
            { 2, 3, -5, 10 },
            { 6, 7, 100, 20 },
            { 1, 87, -2, 1 }
        };

        // Calculate min and max elements:
        int minElementIndexI = 0, minElementIndexJ = 0;
        int maxElementIndexI = 0, maxElementIndexJ = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[minElementIndexI, minElementIndexJ] > array[i, j])
                {
                    minElementIndexI = i;
                    minElementIndexJ = j;
                }

                if (array[maxElementIndexI, maxElementIndexJ] < array[i, j])
                {
                    maxElementIndexI = i;
                    maxElementIndexJ = j;
                }
            }
        }

        // Output array:
        System.Console.WriteLine("Array's elements (before swaping):");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                System.Console.Write(array[i, j] + " ");
            System.Console.WriteLine();
        }
        System.Console.WriteLine();

        // Output min and max elements:
        System.Console.Write($"Min element is array[{minElementIndexI}, {minElementIndexJ}] = ");
        System.Console.WriteLine(array[minElementIndexI, minElementIndexJ]);

        System.Console.Write($"Max element is array[{maxElementIndexI}, {maxElementIndexJ}] = ");
        System.Console.WriteLine(array[maxElementIndexI, maxElementIndexJ]);

        // Swap elements:
        int temp = array[minElementIndexI, minElementIndexJ];
        array[minElementIndexI, minElementIndexJ] = array[maxElementIndexI, maxElementIndexJ];
        array[maxElementIndexI, maxElementIndexJ] = temp;

        // Output array:
        System.Console.WriteLine("\nArray's elements (after swaping):");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                System.Console.Write(array[i, j] + " ");
            System.Console.WriteLine();
        }
    }
}