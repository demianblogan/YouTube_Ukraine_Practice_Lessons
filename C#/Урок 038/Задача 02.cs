class Program
{
    static void Main()
    {
        System.Console.Write("Enter a positive number: ");
        int userNumber = System.Convert.ToInt32(System.Console.ReadLine());

        if (userNumber <= 0)
        {
            System.Console.WriteLine("Your number is not positive");
        }
        else
        {
            int number = 0;
            while (number <= userNumber)
            {
                System.Console.Write(number + " ");
                number++;
            }
        }
    }
}