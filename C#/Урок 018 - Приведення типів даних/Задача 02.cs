class Program
{
    static void Main()
    {
        double number = 45.54;
        int integerPart = (int)number;
        double fractionPart = number - integerPart;

        System.Console.WriteLine("Number        = " + number);
        System.Console.WriteLine("Integer part  = " + integerPart);
        System.Console.WriteLine("Fraction part = " + fractionPart);
    }
}