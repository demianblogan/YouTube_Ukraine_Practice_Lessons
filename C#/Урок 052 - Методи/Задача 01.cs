class Program
{
    static void Main()
    {
        Test();
        ShowText("Hello");
        ShowDate(12, 4, 2008);
        System.Console.WriteLine($"6^2 = {Square(6)}");
        System.Console.WriteLine($"Area of rectangle with sides 2 and 3 = {RectangleArea(2, 3)}");
    }

    static void Test() => System.Console.WriteLine("Test");
    static void ShowText(string text) => System.Console.Write(text);
    static void ShowDate(int day, int month, int year) => System.Console.WriteLine($"{day}.{month}.{year}");
    static int Square(int number) => number * number;
    static int RectangleArea(int side1, int side2) => side1 * side2;
}