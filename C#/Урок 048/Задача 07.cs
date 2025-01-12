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
            System.Console.WriteLine("First array is bigger that second array");
        else if (array1.Length < array2.Length)
            System.Console.WriteLine("Second array is bigger that first array");
        else
            System.Console.WriteLine("Both arrays have same length");
    }
}