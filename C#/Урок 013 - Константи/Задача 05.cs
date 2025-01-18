class Program
{
    static void Main()
    {
        double temperatureC = 21.0f;
        double temperatureF = temperatureC * (9.0f / 5.0f) + 32.0f;

        System.Console.WriteLine(temperatureC + "C = " + temperatureF + "F");
    }
}