class Program
{
    static void Main()
    {
        int a = 3, b = -4, c = -7;
        double D = b * b - 4 * a * c;

        double x1 = (-b + System.Math.Sqrt(D)) / (2 * a);
        double x2 = (-b - System.Math.Sqrt(D)) / (2 * a);

        System.Console.WriteLine("x1 = " + x1);
        System.Console.WriteLine("x2 = " + x2);
    }
}