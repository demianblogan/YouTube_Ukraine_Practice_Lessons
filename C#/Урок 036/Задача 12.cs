class Program
{
    static void Main()
    {
        System.Console.Write("Enter initial sum: ");
        decimal initialSum = System.Convert.ToDecimal(System.Console.ReadLine());

        System.Console.Write("Enter years: ");
        int years = System.Convert.ToInt32(System.Console.ReadLine());

        System.Console.Write("Enter deposit: ");
        decimal deposit = System.Convert.ToDecimal(System.Console.ReadLine());

        decimal sum = initialSum;
        for (int year = 1; year <= years; year++)
            sum += deposit;

        System.Console.WriteLine($"You will get {sum:C} in {years} years");
    }
}