class Program
{
    static void Main()
    {
        System.Console.WriteLine(SumOfDigits(1234));
        System.Console.WriteLine(Fibonacci(6));
    }

    static int SumOfDigits(int number)
    {
        if (number < 0)
            number = -number; // Remove negative sign.

        return number == 0 ? 0 : (number % 10 + SumOfDigits(number / 10));
    }

    static int Fibonacci(int index)
    {
        // Base cases: Fibonacci(0) = 0, Fibonacci(1) = 1
        if (index == 0)
            return 0;
        if (index == 1)
            return 1;

        // Recursive case: Fibonacci(n) = Fibonacci(n-1) + Fibonacci(n-2)
        return Fibonacci(index - 1) + Fibonacci(index - 2);
    }
}