class Program
{
    static void Main()
    {
        int size;

        do
        {
            System.Console.Write("Enter size of the array (must be positive number): ");
            size = System.Convert.ToInt32(System.Console.ReadLine());
        }
        while (size <= 0);

        int[] array = new int[size];

        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write($"Enter value of element #{i + 1}: ");
            array[i] = System.Convert.ToInt32(System.Console.ReadLine());
        }

        System.Console.WriteLine("\nHere's your array:");
        for (int i = 0; i < array.Length; i++)
            System.Console.WriteLine($"array[{i}] = {array[i]}");

        // Creating array with moved duplicates to the end of it:
        int[] tempArray = new int[size];
        int newSize = 0;

        for (int i = 0; i < array.Length; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < newSize; j++)
            {
                if (array[i] == tempArray[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                tempArray[newSize] = array[i];
                newSize++;
            }
        }

        // Create the final array with the correct size:
        int[] uniqueArray = new int[newSize];
        for (int i = 0; i < newSize; i++)
            uniqueArray[i] = tempArray[i];

        array = uniqueArray;

        System.Console.WriteLine("\nAfter removing all duplicates:");
        for (int i = 0; i < array.Length; i++)
            System.Console.WriteLine($"array[{i}] = {array[i]}");
    }
}