class Program
{
    static void Main()
    {
        System.Console.WriteLine("w - forward");
        System.Console.WriteLine("d - right");
        System.Console.WriteLine("a - left");
        System.Console.WriteLine("s - backward");

        char movementKey = System.Convert.ToChar(System.Console.ReadLine());
        switch (movementKey)
        {
            case 'w':
            case 'W':
                System.Console.WriteLine("Hero is moving forward");
                break;
            case 'd':
            case 'D':
                System.Console.WriteLine("Hero is moving right");
                break;
            case 's':
            case 'S':
                System.Console.WriteLine("Hero is moving backward");
                break;
            case 'a':
            case 'A':
                System.Console.WriteLine("Hero is moving left");
                break;
        }
    }
}
