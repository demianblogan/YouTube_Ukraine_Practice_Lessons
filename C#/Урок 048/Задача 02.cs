class Program
{
    static void Main()
    {
        double[] numbers = new double[6];

        double value = 0.01;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = value;
            value += 0.01;
        }

        for (int i = 0; i < numbers.Length; i++)
            System.Console.WriteLine(numbers[i]);
    }
}