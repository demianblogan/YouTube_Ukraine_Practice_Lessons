class Program
{
    static void Main()
    {
        System.Console.Write("Enter a number: ");
        int number = System.Convert.ToInt32(System.Console.ReadLine());

        if (number == 0)
        {
            System.Console.WriteLine("Reversed number  = 0");
            System.Console.WriteLine("Number of digits = 0");
        }
        else
        {
            System.Console.Write("Reversed number  = ");
            if (number < 0)
                System.Console.Write("-");

            int digitsCount = 0;
            for (int tempNumber = (number >= 0 ? number : -number); tempNumber > 0; tempNumber /= 10)
            {
                System.Console.Write(tempNumber % 10);
                digitsCount++;
            }
            System.Console.WriteLine();

            System.Console.WriteLine("Number of digits = " + digitsCount);
        }
    }
}
