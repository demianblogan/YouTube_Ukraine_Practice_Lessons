class Program
{
    static void Main()
    {
        double myCoordinateKM = 2.5;
        double cityCoordinateKM = myCoordinateKM + 7.4;
        double forrestCoordinateKM = -cityCoordinateKM;

        System.Console.WriteLine("My coordinate: " + myCoordinateKM + "km.");
        System.Console.WriteLine("City's coordinate: " + cityCoordinateKM + "km.");
        System.Console.WriteLine("Forrest's coordinate: " + forrestCoordinateKM + "km.");
    }
}