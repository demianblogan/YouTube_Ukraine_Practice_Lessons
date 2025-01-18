class Program
{
    static void Main()
    {
        for (int number = 1; number <= 100; number++)
        {
            bool isPrimeNumber = true;
            for (int divisor = 2; isPrimeNumber && divisor * divisor < number; divisor++)
                if (number % divisor == 0)
                    isPrimeNumber = false;

            if (isPrimeNumber)
                System.Console.Write(number + " ");
        }
    }
}
