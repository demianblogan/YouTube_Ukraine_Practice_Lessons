class Program
{
    static void Main()
    {
        double inches = 18.0;
        const double CM_IN_INCH = 2.54;

        double centimeters = inches * CM_IN_INCH;
        System.Console.WriteLine(inches + " inches = " + centimeters + " centimeters");
    }
}