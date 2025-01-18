class Program
{
    static void Main()
    {
        double cost = 12345.00;                             // in hrn
        double discount = (cost >= 10000.00) ? 0.10 : 0.05; // in %
        double price = cost - cost * discount;              // in hrn

        System.Console.WriteLine($"You must pay {price} hrn");
    }
}