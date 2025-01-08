class Program
{
    static void Main()
    {
        const double CM_IN_INCH = 2.54;
        const int INCH_IN_FOOT = 12;

        System.Console.Write("Enter your height in cm: ");
        int heightInCM = System.Convert.ToInt32(System.Console.ReadLine());
        int heightInInch = (int)(heightInCM / CM_IN_INCH);
        int heightInFeet = heightInInch / INCH_IN_FOOT;
        heightInInch %= INCH_IN_FOOT;

        System.Console.WriteLine($"Your height is {heightInFeet}'{heightInInch}''");
    }
}