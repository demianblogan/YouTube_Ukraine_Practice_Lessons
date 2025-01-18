class Program
{
    static void Main()
    {
    EnteringPositiveNumber:
        System.Console.Write("Enter a positive number: ");
        int number = System.Convert.ToInt32(System.Console.ReadLine());
        if (number <= 0)
            goto EnteringPositiveNumber;

        bool isPrimeNumber = true;

    CheckingIfNumberIsPrime:
        if (number == 2)
        {
            System.Console.WriteLine("Your number is prime");
            goto EnteringPositiveNumber;
        }

        int divisor = 2;
        if (number % divisor == 0)
            isPrimeNumber = false;

        divisor++;

        if (isPrimeNumber && divisor * divisor < number)
            goto CheckingIfNumberIsPrime;

        if (isPrimeNumber)
            System.Console.WriteLine("Your number is prime");
        else
            System.Console.WriteLine("Your number isn't prime");

        goto EnteringPositiveNumber;
    }
}
