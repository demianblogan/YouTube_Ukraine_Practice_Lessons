class Program
{
    static void Main()
    {
        int side1 = 3, side2 = 7;
        int perimeter = side1 * 2 + side2 * 2;
        int area = side1 * side2;

        System.Console.WriteLine("Rectangle's sides = " + side1 + " and " + side2);
        System.Console.WriteLine("Rectangle's perimeter = " + perimeter);
        System.Console.WriteLine("Rectangle's area = " + area);
    }
}