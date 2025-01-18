class Program
{
    static void Main()
    {
        bool amI20 = true;
        bool hasGrandmaCome = true;
        int balance = 5000; // in hrn

        balance += (amI20 && hasGrandmaCome) ? 1000 : 500;

        System.Console.WriteLine($"My balance = {balance}");
    }
}