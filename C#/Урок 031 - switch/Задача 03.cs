class Program
{
    static void Main()
    {
        int direction = 1;

        switch (direction)
        {
            case 1:
                System.Console.WriteLine("Up");
                break;
            case 2:
                System.Console.WriteLine("Right");
                break;
            case 3:
                System.Console.WriteLine("Left");
                break;
            case 4:
                System.Console.WriteLine("Down");
                break;
            default:
                System.Console.WriteLine("Incorrect number");
                break;
        }
    }
}