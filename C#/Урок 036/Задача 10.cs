class Program
{
    static void Main()
    {
        while (true)
        {
            System.Console.Write("Enter first number: ");
            double number1 = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("Enter second number: ");
            double number2 = System.Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("1 - addition");
            System.Console.WriteLine("2 - subtraction");
            System.Console.WriteLine("3 - multiplication");
            System.Console.WriteLine("4 - division");

            System.Console.Write("Choose operation: ");
            char operation = System.Convert.ToChar(System.Console.ReadLine());

            double result;

            switch (operation)
            {
                case '1':
                    result = number1 + number2;
                    System.Console.WriteLine($"{number1} + {number2} = {result}");
                    break;

                case '2':
                    result = number1 - number2;
                    System.Console.WriteLine($"{number1} - {number2} = {result}");
                    break;

                case '3':
                    result = number1 * number2;
                    System.Console.WriteLine($"{number1} * {number2} = {result}");
                    break;

                case '4':
                    if (number2 == 0)
                    {
                        System.Console.WriteLine("You can't divide by zero");
                    }
                    else
                    {
                        result = number1 / number2;
                        System.Console.WriteLine($"{number1} / {number2} = {result}");
                    }
                    break;

                default:
                    System.Console.WriteLine("Incorrect character. Try again");
                    break;
            }
        }
    }
}