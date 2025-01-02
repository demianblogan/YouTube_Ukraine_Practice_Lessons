class Program
{
    static void Main()
    {
        int kilometers = 15;
        const int M_IN_KM = 1000;

        int meters = kilometers * M_IN_KM;
        System.Console.WriteLine(kilometers + "km = " + meters + "m");
    }
} 