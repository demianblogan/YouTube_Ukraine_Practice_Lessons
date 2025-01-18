using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main()
    {
        int budget = 100_000;

        int computerCost = 43_500;
        int playStation5Cost = 25_000;
        int xboxSeriesX = 21_200;

        System.Console.WriteLine("Origin budget: " + budget + " hrn");
        budget -= computerCost;
        System.Console.WriteLine("Budget after buying a computer: " + budget + " hrn");
        budget -= playStation5Cost;
        System.Console.WriteLine("Budget after buying a PlayStation 5: " + budget + " hrn");
        budget -= xboxSeriesX;
        System.Console.WriteLine("Budget after buying an Xbox Series X: " + budget + " hrn");
    }
}