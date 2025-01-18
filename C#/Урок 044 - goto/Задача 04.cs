class Program
{
    static void Main()
    {
    EnteringNumbers:

        int number1, number2, number3, number4, number5;

        System.Console.Write("Enter first number: ");
        number1 = System.Convert.ToInt32(System.Console.ReadLine());

        System.Console.Write("Enter second number (must be greater that the previous one): ");
        number2 = System.Convert.ToInt32(System.Console.ReadLine());
        if (number2 <= number1)
            goto EnteringNumbers;

        System.Console.Write("Enter third number (must be greater that the previous one): ");
        number3 = System.Convert.ToInt32(System.Console.ReadLine());
        if (number3 <= number2)
            goto EnteringNumbers;

        System.Console.Write("Enter fourth number (must be greater that the previous one): ");
        number4 = System.Convert.ToInt32(System.Console.ReadLine());
        if (number4 <= number3)
            goto EnteringNumbers;

        System.Console.Write("Enter fifth number (must be greater that the previous one): ");
        number5 = System.Convert.ToInt32(System.Console.ReadLine());
        if (number5 <= number4)
            goto EnteringNumbers;
    }
}