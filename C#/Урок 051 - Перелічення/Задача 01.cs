class Program
{
    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }

    static void Main()
    {
        DayOfWeek today = DayOfWeek.Sunday;

        DayOfWeek[] workDays =
        {
            DayOfWeek.Monday,
            DayOfWeek.Tuesday,
            DayOfWeek.Wednesday,
            DayOfWeek.Thursday,
            DayOfWeek.Friday
        };

        const DayOfWeek FIRST_DAY_OF_WEEK = DayOfWeek.Monday;
        const DayOfWeek LAST_DAY_OF_WEEK = DayOfWeek.Sunday;

        System.Console.Write("Today is ");
        switch (today)
        {
            case DayOfWeek.Monday:
                System.Console.Write("Monday");
                break;
            case DayOfWeek.Tuesday:
                System.Console.Write("Tuesday");
                break;
            case DayOfWeek.Wednesday:
                System.Console.Write("Wednesday");
                break;
            case DayOfWeek.Thursday:
                System.Console.Write("Thursday");
                break;
            case DayOfWeek.Friday:
                System.Console.Write("Friday");
                break;
            case DayOfWeek.Saturday:
                System.Console.Write("Saturday");
                break;
            case DayOfWeek.Sunday:
                System.Console.Write("Sunday");
                break;
        }

        System.Console.Write("\nFirst day of week: ");
        switch (FIRST_DAY_OF_WEEK)
        {
            case DayOfWeek.Monday:
                System.Console.Write("Monday");
                break;
        }

        System.Console.Write("\nLast day of week: ");
        switch (LAST_DAY_OF_WEEK)
        {
            case DayOfWeek.Sunday:
                System.Console.Write("Sunday");
                break;
        }

        System.Console.Write("\nWork days are ");
        for (int i = 0; i < workDays.Length; i++)
        {
            switch (workDays[i])
            {
                case DayOfWeek.Monday:
                    System.Console.Write("Monday");
                    break;
                case DayOfWeek.Tuesday:
                    System.Console.Write("Tuesday");
                    break;
                case DayOfWeek.Wednesday:
                    System.Console.Write("Wednesday");
                    break;
                case DayOfWeek.Thursday:
                    System.Console.Write("Thursday");
                    break;
                case DayOfWeek.Friday:
                    System.Console.Write("Friday");
                    break;
                case DayOfWeek.Saturday:
                    System.Console.Write("Saturday");
                    break;
                case DayOfWeek.Sunday:
                    System.Console.Write("Sunday");
                    break;
            }

            if (i == workDays.Length - 2)
                System.Console.Write(", and ");
            else if (i == workDays.Length - 1)
                System.Console.WriteLine();
            else
                System.Console.Write(", ");
        }
    }
}