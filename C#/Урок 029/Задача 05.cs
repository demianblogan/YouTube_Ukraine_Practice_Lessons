class Program
{
    static void Main()
    {
        int sideA = 20, sideB = 30;

        if (sideA > 0 && sideB > 0)
        {
            int area = sideA * sideB;
            System.Console.WriteLine($"area = {area}");
        }
        else
        {
            System.Console.WriteLine("One or two sides are incorrect");
        }
    }
}