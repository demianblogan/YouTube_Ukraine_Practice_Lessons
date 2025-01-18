class Program
{
    static void Main()
    {
        System.Console.Write("Enter lower bound: ");
        int min = System.Convert.ToInt32(System.Console.ReadLine());

        System.Console.Write("Enter upper bound: ");
        int max = System.Convert.ToInt32(System.Console.ReadLine());

        for (int number = min; number <= max; number += 7)
        {
            System.Console.Write(number + " ");

            if (number % 9 == 0)
                break;
        }
    }
}