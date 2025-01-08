class Program
{
    static void Main()
    {
        System.Console.Write("Enter a number: ");
        double number = System.Convert.ToDouble(System.Console.ReadLine());

        System.Console.Write("Enter a power: ");
        int power = System.Convert.ToInt32(System.Console.ReadLine());

        if (number == 0 && power == 0)
        {
            System.Console.WriteLine("You can't calculate 0^0.");
        }
        else if (power == 0)
        {
            System.Console.WriteLine($"{number}^{power} = 1");
        }
        else if (number == 0)
        {
            System.Console.WriteLine($"{number}^{power} = 0");
        }
        else if (power > 0)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
                result *= number;

            System.Console.WriteLine($"{number}^{power} = {result}");
        }
        else // if power < 0
        {
            power = -power;

            double result = 1;
            for (int i = 0; i < power; i++)
                result *= number;
            result = 1.0 / result;

            System.Console.WriteLine($"{number}^{power} = {result}");
        }
    }
}