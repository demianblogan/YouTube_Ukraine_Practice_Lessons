class Program
{
    static void Main()
    {
        bool isEnoughEmployees = true;
        bool isEnoughRobots = false;
        bool canFactoryWork = isEnoughEmployees || isEnoughRobots;

        System.Console.WriteLine(canFactoryWork);
    }
}