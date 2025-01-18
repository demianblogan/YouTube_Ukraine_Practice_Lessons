class Program
{
    static void Main()
    {
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Question #1:
        System.Console.WriteLine("Питання 1: Скільки буде 2 + 2?");
        System.Console.WriteLine("a) 4");
        System.Console.WriteLine("b) 8");
        System.Console.WriteLine("c) 2");
        System.Console.WriteLine("d) 4");

        char answer = System.Convert.ToChar(System.Console.ReadLine());

        switch (answer)
        {
            case 'a':
            case 'A':
                System.Console.WriteLine("Правильна відповідь!");

                // Question #2:
                System.Console.WriteLine("Питання 2: Скільки планет є в сонячній системі?");
                System.Console.WriteLine("a) 7");
                System.Console.WriteLine("b) 8");
                System.Console.WriteLine("c) 9");
                System.Console.WriteLine("d) 10");

                answer = System.Convert.ToChar(System.Console.ReadLine());

                switch (answer)
                {
                    
                    case 'b':
                    case 'B':
                        System.Console.WriteLine("Правильна відповідь!");

                        // Question #3:
                        System.Console.WriteLine("Питання 3: Яка порода собак схожа на сосиску?");
                        System.Console.WriteLine("a) Бульдог");
                        System.Console.WriteLine("b) Мопс");
                        System.Console.WriteLine("c) Такса");
                        System.Console.WriteLine("d) Лабрадор");

                        answer = System.Convert.ToChar(System.Console.ReadLine());

                        switch (answer)
                        {
                            case 'c':
                            case 'C':
                                System.Console.WriteLine("Правильна відповідь! Ви виграли!");
                                break;

                            case 'a':
                            case 'A':
                            case 'b':
                            case 'B':
                            case 'd':
                            case 'D':
                                System.Console.WriteLine("Неправильна відповідь. Ви програли.");
                                break;

                            default:
                                System.Console.WriteLine("Некоректний символ. Ви програли.");
                                break;
                        }

                        break;

                    case 'a':
                    case 'A':
                    case 'c':
                    case 'C':
                    case 'd':
                    case 'D':
                        System.Console.WriteLine("Неправильна відповідь. Ви програли.");
                        break;

                    default:
                        System.Console.WriteLine("Некоректний символ. Ви програли.");
                        break;
                }

                break;

            case 'b':
            case 'B':
            case 'c':
            case 'C':
            case 'd':
            case 'D':
                System.Console.WriteLine("Неправильна відповідь. Ви програли.");
                break;

            default:
                System.Console.WriteLine("Некоректний символ. Ви програли.");
                break;
        }
    }
}