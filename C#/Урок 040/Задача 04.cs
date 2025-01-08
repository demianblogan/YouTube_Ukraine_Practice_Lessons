class Program
{
    static void Main()
    {
        System.Console.Write("Enter a positive number: ");
        int userNumber = System.Convert.ToInt32(System.Console.ReadLine());

        int sum = 0;
        for (int number = 1; number <= userNumber; number++)
            sum += number;

        System.Console.WriteLine("Sum = " + sum);
    }
}