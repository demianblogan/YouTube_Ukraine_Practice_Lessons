class Program
{
    static void Main()
    {
        int minutes = 123;
        const int SEC_IN_MIN = 60;

        int seconds = minutes * SEC_IN_MIN;
        System.Console.WriteLine(minutes + " minutes = " + seconds + " seconds");
    }
}