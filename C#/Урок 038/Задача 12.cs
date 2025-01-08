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
            sum += sum + sum * 0.05M;
            System.Console.WriteLine($"You will get {sum:C} in {year} year(s)");
        }
    }
}