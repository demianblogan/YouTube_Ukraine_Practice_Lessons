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

        bool isArrayPalindrom = true;
        for (int i = 0, j = array.Length - 1; i < j; i++, j--)
        {
            if (array[i] != array[j])
            {
                isArrayPalindrom = false;
                break;
            }
        }

        if (isArrayPalindrom)
            System.Console.WriteLine("Your array is a palindrom");
        else
            System.Console.WriteLine("Your array isn't a palindrom");
    }
}