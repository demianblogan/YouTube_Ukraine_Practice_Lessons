class Program
{
    static void Main()
    {
        System.Console.OutputEncoding = System.Text.Encoding.Unicode;

        System.Console.WriteLine(@"+---------------------------------------------------------------------+");
        System.Console.WriteLine(@"| \n - переводить курсор на новий рядок                               |");
        System.Console.WriteLine(@"| \t - переводить курсор на наступну позицію горизонтальної табуляції |");
        System.Console.WriteLine(@"| \a - запускає системний звук                                        |");
        System.Console.WriteLine(@"| \b - переносить курсор на одну позицію назад                        |");
        System.Console.WriteLine(@"| \f - переносить курсор на наступну сторінку                         |");
        System.Console.WriteLine(@"| \r - переносить курсор на початок даного рядка                      |");
        System.Console.WriteLine(@"| \v - переводить курсор на наступну позицію вертикальної табуляції   |");
        System.Console.WriteLine(@"| \' - виводить на екран одинарні лапки                               |");
        System.Console.WriteLine(@"| \"" - виводить на екран подвійні лапки                              |");
        System.Console.WriteLine(@"| \\ - виводить на екран обернену риску                               |");
        System.Console.WriteLine(@"| \? - виводить на екран знак питання                                 |");
        System.Console.WriteLine(@"+---------------------------------------------------------------------+");
    }
}