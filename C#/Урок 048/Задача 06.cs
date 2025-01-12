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

        int sum = 0;
        for (int i = 0; i < array.Length; i++)
            sum += array[i];

        int min = array[0], max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (min > array[i])
                min = array[i];

            if (max < array[i])
                max = array[i];
        }

        double average = (double)sum / size;

        System.Console.WriteLine($"Sum of all elements  = {sum}");
        System.Console.WriteLine($"Average value        = {average}");
        System.Console.WriteLine($"The lowest element   = {min}");
        System.Console.WriteLine($"The greatest element = {max}");
    }
}