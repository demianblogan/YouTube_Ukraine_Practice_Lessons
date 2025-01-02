class Program
{
    static void Main()
    {
        float tempF, tempC;

        tempF = 50;
        tempC = (tempF - 32.0f) / (9.0f / 5.0f);
        System.Console.WriteLine(tempF + "F = " + tempC + "C");

        tempF = 81;
        tempC = (tempF - 32.0f) / (9.0f / 5.0f);
        System.Console.WriteLine(tempF + "F = " + tempC + "C");

        tempF = 27;
        tempC = (tempF - 32.0f) / (9.0f / 5.0f);
        System.Console.WriteLine(tempF + "F = " + tempC + "C");
    }
}