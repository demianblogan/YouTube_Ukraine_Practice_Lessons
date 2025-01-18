class Program
{
    static void Main()
    {
        int myCash = 580;
        const int COPEK_IN_HRN = 100;
        int moneyToTake = 5;

        myCash %= moneyToTake * COPEK_IN_HRN;

        System.Console.WriteLine($"I have {myCash} copek");
    }
}