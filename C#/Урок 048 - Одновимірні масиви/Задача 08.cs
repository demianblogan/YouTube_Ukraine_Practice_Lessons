class Program
{
    static void Main()
    {
        int size1;
        do
        {
            System.Console.Write("Enter size of first array (must be positive number): ");
            size1 = System.Convert.ToInt32(System.Console.ReadLine());
        }
        while (size1 <= 0);

        int size2;
        do
        {
            System.Console.Write("Enter size of second array (must be positive number): ");
            size2 = System.Convert.ToInt32(System.Console.ReadLine());
        }
        while (size2 <= 0);

        int[] array1 = new int[size1];
        int[] array2 = new int[size2];

        if (array1.Length > array2.Length)
        {
            System.Console.WriteLine("First array is bigger that second array");
        }
        else if (array1.Length < array2.Length)
        {
            System.Console.WriteLine("Second array is bigger that first array");
        }
        else
        {
            System.Console.WriteLine("Filling of first array...");
            for (int i = 0; i < array1.Length; i++)
            {
                System.Console.Write($"Enter value of element #{i + 1}: ");
                array1[i] = System.Convert.ToInt32(System.Console.ReadLine());
            }

            System.Console.WriteLine("Filling of second array...");
            for (int i = 0; i < array2.Length; i++)
            {
                System.Console.Write($"Enter value of element #{i + 1}: ");
                array2[i] = System.Convert.ToInt32(System.Console.ReadLine());
            }

            bool areArraysTheSame = true;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    areArraysTheSame = false;
                    break;
                }
            }

            if (areArraysTheSame)
                System.Console.WriteLine("Arrays are the same");
            else
                System.Console.WriteLine("Arrays aren't the same");
        }
    }
}