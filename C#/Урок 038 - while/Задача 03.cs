class Program
{
    static void Main()
    {
        System.Console.Write("Enter a positive number: ");
        int userNumber = System.Convert.ToInt32(System.Console.ReadLine());
        while (userNumber <= 0)
        {
            System.Console.WriteLine("Your number is not positive. Try again.");
            userNumber = System.Convert.ToInt32(System.Console.ReadLine());
        }

        int number = 0;
        while (number <= userNumber)
        {
            System.Console.Write(number + " ");
            number++;
        }
    }
}