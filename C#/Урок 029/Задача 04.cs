class Program
{
    static void Main()
    {
        int fatherAge = 38, motherAge = 29;

        if (fatherAge > motherAge)
            System.Console.WriteLine("Father is older");
        else if (fatherAge < motherAge)
            System.Console.WriteLine("Mother is older");
        else
            System.Console.WriteLine("Parents have same age");
    }
}