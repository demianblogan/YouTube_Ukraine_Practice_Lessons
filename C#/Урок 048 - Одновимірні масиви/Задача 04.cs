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
        System.Console.WriteLine($"Sum of all elements = {sum}");
    }
}