class Program
{
    static void Main()
    {
        const int SQUARE_SIDES_COUNT = 4;
        int side = 5;
        int perimeter = side * SQUARE_SIDES_COUNT;
        int area = side * side;

        System.Console.WriteLine("Square side      = " + side);
        System.Console.WriteLine("Square perimeter = " + perimeter);
        System.Console.WriteLine("Square area      = " + area);
    }
}