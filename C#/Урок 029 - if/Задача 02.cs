class Program
{
    static void Main()
    {
        double maximumNormalTemperature = 37.5;
        double userTemperature = 20.5;

        if (userTemperature > maximumNormalTemperature)
            System.Console.WriteLine("Call an ambulance");
    }
}