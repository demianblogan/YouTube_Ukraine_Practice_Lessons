class Program
{
    static void Main()
    {
        // Create arrays:
        int[,] array1 = new int[2, 3]
        {
            { 10, 20, 30 },
            { 40, 50, 60 }
        };

        int[,] array2 = new int[2, 3]
        {
            { 100, 200, 300 },
            { 400, 500, 600 }
        };

        int[,] sumArray = new int[2, 3];

        // Calculate sum array:
        for (int i = 0; i < array1.GetLength(0); i++)
            for (int j = 0; j < array1.GetLength(1); j++)
                sumArray[i, j] = array1[i, j] + array2[i, j];

        // Output arrays:
        System.Console.WriteLine("Array #1:");
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
                System.Console.Write(array1[i, j] + " ");
            System.Console.WriteLine();
        }
        System.Console.WriteLine();

        System.Console.WriteLine("Array #2:");
        for (int i = 0; i < array2.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
                System.Console.Write(array2[i, j] + " ");
            System.Console.WriteLine();
        }
        System.Console.WriteLine();

        System.Console.WriteLine("Sum Array:");
        for (int i = 0; i < sumArray.GetLength(0); i++)
        {
            for (int j = 0; j < sumArray.GetLength(1); j++)
                System.Console.Write(sumArray[i, j] + " ");
            System.Console.WriteLine();
        }
    }
}