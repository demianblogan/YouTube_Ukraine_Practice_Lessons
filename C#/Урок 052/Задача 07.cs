class Program
{
    enum Month
    {
        January = 1,
        February,
        March,
        April,
        June,
        July,
        August,
        September,
        October,
        November,
        December,
    }

    static void Main()
    {
        for (int monthNumber = 1; monthNumber <= 12; monthNumber++)
            System.Console.WriteLine(MonthToString((Month)monthNumber));
    }

    static string MonthToString(Month month) => month switch
    {
        Month.January => "January",
        Month.February => "February",
        Month.March => "March",
        Month.April => "April",
        Month.June => "June",
        Month.July => "July",
        Month.August => "August",
        Month.September => "September",
        Month.October => "October",
        Month.November => "November",
        Month.December => "December",
        _ => "",
    };
}