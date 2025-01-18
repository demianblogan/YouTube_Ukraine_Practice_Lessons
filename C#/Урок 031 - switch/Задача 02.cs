class Program
{
    static void Main()
    {
        string name = "David";

        switch (name)
        {
            case "David":
                System.Console.WriteLine("Father must go to work");
                break;
            case "Emma":
                System.Console.WriteLine("Mother must go shopping");
                break;
            case "Jonathan":
                System.Console.WriteLine("Son must go to school");
                break;
            case "Celisia":
                System.Console.WriteLine("Daughter must go to sleep");
                break;
        }
    }
}