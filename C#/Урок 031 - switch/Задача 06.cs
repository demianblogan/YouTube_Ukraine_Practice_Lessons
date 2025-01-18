class Program
{
    static void Main()
    {
        int age = 200;

        switch (age)
        {
            case <= 0:
                System.Console.WriteLine("Incorrect age");
                break;
            case < 10:
                System.Console.WriteLine("Child");
                break;
            case < 60:
                System.Console.WriteLine("Adult");
                break;
            case <= 120:
                System.Console.WriteLine("Old");
                break;

            default:
                System.Console.WriteLine("Dead");
                break;
        }
    }
}