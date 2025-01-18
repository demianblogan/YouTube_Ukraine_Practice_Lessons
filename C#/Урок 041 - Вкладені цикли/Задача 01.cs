class Program
{
    static void Main()
    {
        for (int leftNumber = 1; leftNumber <= 9; leftNumber++)
        {
            for (int rightNumber = 1; rightNumber <= 9; rightNumber++)
            {
                int result = leftNumber * rightNumber;
                System.Console.WriteLine($"{leftNumber} x {rightNumber} = {result}");
            }
            System.Console.WriteLine();
        }
    }
}