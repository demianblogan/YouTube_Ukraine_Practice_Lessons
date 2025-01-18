class Program
{
    static void Main()
    {
        const int MONTHS_IN_YEAR = 12;
        int workYears = 5;

        double monthSalary = 500.00;
        double annualSalary = monthSalary * MONTHS_IN_YEAR;
        double fullSalary = annualSalary * workYears;

        System.Console.WriteLine($"Month salary  = {monthSalary:C}");
        System.Console.WriteLine($"Annual salary = {annualSalary:C}");
        System.Console.WriteLine($"Full salary   = {fullSalary:C}");
    }
}