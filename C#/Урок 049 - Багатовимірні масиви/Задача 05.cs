class Program
{
    static void Main()
    {
        // Create array:
        int[,] symetricArray = new int[3, 3]
        {
            { 1, 20, 30 },
            { 20, 1, 50 },
            { 30, 50, 1 }
        };

        // Check if array is symetric:
        bool isArraySymetric = true;

        for (int i = 0; i < symetricArray.GetLength(0); i++)
        {
            for (int j = 0; j < symetricArray.GetLength(1); j++)
            {
                // Don't check diagonal elements:
                if (i == j)
                    continue;

                if (symetricArray[i, j] != symetricArray[j, i])
                {
                    isArraySymetric = false;
                    break;
                }
            }
        }

        // Output array:
        System.Console.WriteLine("symetricArray:");
        for (int i = 0; i < symetricArray.GetLength(0); i++)
        {
            for (int j = 0; j < symetricArray.GetLength(1); j++)
                System.Console.Write(symetricArray[i, j] + " ");
            System.Console.WriteLine();
        }

        // Output result of symetry:
        if (isArraySymetric)
            System.Console.WriteLine("This array is symetric\n");
        else
            System.Console.WriteLine("This array is not symetric\n");

        // Create another array:
        int[,] nonSymetricArray = new int[3, 3]
        {
            { 1, 650, 30 },
            { 20, 1, 50 },
            { 87, 50, 1 }
        };

        // Check if array is symetric:
        isArraySymetric = true;

        for (int i = 0; i < nonSymetricArray.GetLength(0); i++)
        {
            for (int j = 0; j < nonSymetricArray.GetLength(1); j++)
            {
                // Don't check diagonal elements:
                if (i == j)
                    continue;

                if (nonSymetricArray[i, j] != nonSymetricArray[j, i])
                {
                    isArraySymetric = false;
                    break;
                }
            }
        }

        // Output array:
        System.Console.WriteLine("nonSymetricArray:");
        for (int i = 0; i < nonSymetricArray.GetLength(0); i++)
        {
            for (int j = 0; j < nonSymetricArray.GetLength(1); j++)
                System.Console.Write(nonSymetricArray[i, j] + " ");
            System.Console.WriteLine();
        }

        // Output result of symetry:
        if (isArraySymetric)
            System.Console.WriteLine("This array is symetric");
        else
            System.Console.WriteLine("This array is not symetric");
    }
}