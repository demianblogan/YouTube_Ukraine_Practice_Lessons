class Program
{
    static void Main()
    {
        const decimal DEPOSIT_FACTOR = 0.05M;

        System.Console.Write("Enter initial sum: ");
        decimal initialSum = System.Convert.ToDecimal(System.Console.ReadLine());

        System.Console.Write("Enter years: ");
        int years = System.Convert.ToInt32(System.Console.ReadLine());

        decimal sum = initialSum;

        int currentYear = 1;
        while (currentYear <= years)
        {
            System.Console.Write($"In {currentYear} year(s) sum will be: {sum:C} + ({sum:C} + {sum:C} * {DEPOSIT_FACTOR}) = ");
            sum += sum + sum * DEPOSIT_FACTOR;
            System.Console.WriteLine($"{sum:C}");

            currentYear++;
        }
    }
}
