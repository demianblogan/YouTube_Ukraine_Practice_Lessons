class Program
{
    static void Main()
    {
        int daysCount = 3;

        double temperatureDay1 = 38.5;
        double temperatureDay2 = 39.3;
        double temperatureDay3 = 40.2;

        double temperatureSum = temperatureDay1 + temperatureDay2 + temperatureDay3;
        double temperatureAverage = temperatureSum / daysCount;

        System.Console.WriteLine($"Day #1:  {temperatureDay1:N1}C");
        System.Console.WriteLine($"Day #2:  {temperatureDay2:N1}C");
        System.Console.WriteLine($"Day #3:  {temperatureDay3:N1}C");
        System.Console.WriteLine($"Average: {temperatureAverage:N1}C");
    }
}