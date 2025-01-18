class Program
{
    static void Main()
    {
        const int M_IN_KM = 1000;

        int distanceInM = 53665;
        int distanceInKM = distanceInM / M_IN_KM;
        int restDistanceInM = distanceInM % M_IN_KM;

        System.Console.WriteLine("Distance = " + distanceInKM + "km " + restDistanceInM + "m");
    }
}