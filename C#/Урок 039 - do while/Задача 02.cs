class Program
{
    static void Main()
    {
        int minimum, maximum;

        do
        {
            System.Console.Write("Enter minimum and maximum numbers: ");
            minimum = System.Convert.ToInt32(System.Console.ReadLine());
            maximum = System.Convert.ToInt32(System.Console.ReadLine());

            if (minimum > maximum)
                System.Console.WriteLine("Minimum number can't be greater that maximun. Try again.");

        } while (minimum > maximum);

        int subMinimum, subMaximum;

        do
        {
            System.Console.Write($"Now enter sub minimum number and sub maximum numbers in this range [{minimum}, {maximum}]: ");
            subMinimum = System.Convert.ToInt32(System.Console.ReadLine());
            subMaximum = System.Convert.ToInt32(System.Console.ReadLine());

            if (subMinimum > subMaximum)
                System.Console.WriteLine("Sub minimum number can't be greater that sub maximun. Try again.");
            if (subMinimum < minimum)
                System.Console.WriteLine("Sub minimum mast be greater or equal to minimum. Try again.");
            if (subMaximum > maximum)
                System.Console.WriteLine("Sub maximum mast be less or equal to maximum. Try again.");

        } while (subMinimum > subMaximum || subMinimum < minimum || subMaximum > maximum);

        int number = minimum;
        do
        {
            if (number < subMinimum || number > subMaximum)
                System.Console.Write(number + " ");

            number++;

        } while (number <= maximum);
    }
}
