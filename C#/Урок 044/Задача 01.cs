class Program
{
    static void Main()
    {
    EnteringNonNegativeNumber:
        System.Console.Write("Enter a non-negative number: ");
        int number = System.Convert.ToInt32(System.Console.ReadLine());
        if (number < 0)
            goto EnteringNonNegativeNumber;
    }
}