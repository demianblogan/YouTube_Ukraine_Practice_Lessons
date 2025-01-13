class Program
{
    static void Main()
    {

    }

    static string EnterString() => System.Console.ReadLine();
    static int EnterInt() => System.Convert.ToInt32(EnterString());
    static double EnterDouble() => System.Convert.ToDouble(EnterString());
}