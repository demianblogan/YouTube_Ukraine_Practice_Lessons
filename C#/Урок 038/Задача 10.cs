class Program
{
    static void Main()
    {
        System.Console.Write("Enter initial sum: ");
        decimal initialSum = System.Convert.ToDecimal(System.Console.ReadLine());

        System.Console.Write("Enter years: ");
        int years = System.Convert.ToInt32(System.Console.ReadLine());

        decimal sum = initialSum;

        int currentYear = 1;
        while (currentYear <= years)
        {
            sum += initialSum + sum * 0.05M;
            currentYear++;
        }

        System.Console.WriteLine($"You will get {sum:C} in {years} years");
    }
}
