class Program
{
    static void Main()
    {
        sbyte originNumber = -100;
        sbyte resultNumber = (sbyte)((~originNumber) + 1);

        System.Console.WriteLine(resultNumber);
    }
}