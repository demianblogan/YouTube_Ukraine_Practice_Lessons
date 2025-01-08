class Program
{
    static void Main()
    {
        System.Console.Write("Enter first number: ");
        int number1 = System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Enter second number: ");
        int number2 = System.Convert.ToInt32(System.Console.ReadLine());

        if (number1 > number2)
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }

        int sum = 0;
        int number = number1;
        while (number <= number2)
        {
            sum += number;
            number++;
        }

        System.Console.WriteLine("Sum = " + sum);
    }
}