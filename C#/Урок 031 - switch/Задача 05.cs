class Program
{
    static void Main()
    {
        int direction = 1;
        const int UP = 1, RIGHT = 2, LEFT = 3, DOWN = 4;

        switch (direction)
        {
            case UP:
                System.Console.WriteLine("Up");
                break;
            case RIGHT:
                System.Console.WriteLine("Right");
                break;
            case LEFT:
                System.Console.WriteLine("Left");
                break;
            case DOWN:
                System.Console.WriteLine("Down");
                break;
            default:
                System.Console.WriteLine("Incorrect number");
                break;
        }
    }
}