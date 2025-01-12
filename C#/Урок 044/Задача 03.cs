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
        int divisor = 2;
            if (number % divisor == 0)
                isPrimeNumber = false;

        divisor++;

        if (divisor * divisor < number)
            goto CheckingIfNumberIsPrime;

        if (isPrimeNumber)
            System.Console.WriteLine("Your number is prime");

        goto EnteringPositiveNumber;
    }
}