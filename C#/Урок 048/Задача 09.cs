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

        int[] copyArray = new int[array.Length];
        for (int i = 0; i < copyArray.Length; i++)
            copyArray[i] = array[i];

        System.Console.WriteLine("\nHere's your array:");
        for (int i = 0; i < array.Length; i++)
            System.Console.WriteLine($"array[{i}] = {array[i]}");

        System.Console.WriteLine("\nHere's copy array:");
        for (int i = 0; i < copyArray.Length; i++)
            System.Console.WriteLine($"copyArray[{i}] = {copyArray[i]}");
    }
}