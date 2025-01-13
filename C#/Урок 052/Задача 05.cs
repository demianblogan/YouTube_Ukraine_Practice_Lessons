class Program
{
    static void Main()
    {
        ShowMessage("Enter a number: ");
        int number = EnterInt();

        ShowMessage($"Your number {(IsPrime(number) ? "is" : "isn't")} prime\n");
        ShowMessage($"Your number {(IsEven(number) ? "is" : "isn't")} even\n");
        ShowMessage($"Your number has {CountDigits(number)} digit(s)\n");
        ShowMessage($"Reversed number is {Reverse((uint)number)}\n");
        ShowMessage($"Factorial of {number} = {Factorial(number)}\n");
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int divisor = 2; divisor * divisor <= number; divisor++)
            if (number % divisor == 0)
                return false;

        return true;
    }

    static bool IsEven(int number) => (number % 2 == 0);

    static int CountDigits(int number)
    {
        int digits = 0;
        while (number != 0)
        {
            digits++;
            number /= 10;
        }
        return digits;
    }

    static uint Reverse(uint number)
    {
        uint reversedNumber = 0;

        while (number > 0)
        {
            // Get the last digit:
            uint digit = number % 10;

            // Add the digit to the reversed number:
            reversedNumber = reversedNumber * 10 + digit;

            // Remove the last digit from the original number
            number /= 10;
        }

        return reversedNumber;
    }

    static int Factorial(int number) => number > 1 ? number * Factorial(number - 1) : number;

    #region Tools
    static void ShowMessage(string text) => System.Console.Write(text);
    static string EnterString() => System.Console.ReadLine();
    static int EnterInt() => System.Convert.ToInt32(EnterString());
    #endregion
}