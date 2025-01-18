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

        int oddValuesCount = 0;
        System.Console.WriteLine("\nHere's elements with only even values:");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
                System.Console.WriteLine($"array[{i}] = {array[i]}");
            else
                oddValuesCount++;
        }

        System.Console.WriteLine($"Number of odd values = {oddValuesCount}");
    }
}