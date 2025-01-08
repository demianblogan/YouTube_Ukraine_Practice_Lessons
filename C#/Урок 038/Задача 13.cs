class Program
{
    static void Main()
    {
        System.Console.Write("Enter initial sum: ");
        decimal initialSum = System.Convert.ToDecimal(System.Console.ReadLine());

        System.Console.Write("Enter years: ");
        int years = System.Convert.ToInt32(System.Console.ReadLine());

        decimal sum = initialSum;
        for (int year = 1; year <= years; year++)
        {
            System.Console.Write($"In {year} year(s) sum will be: {sum:C} + ({sum:C} + {sum:C} * 0.05) = ");
            sum += sum + sum * 0.05M;
            System.Console.WriteLine($"{sum:C}");
        }
    }
}