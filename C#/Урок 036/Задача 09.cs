class Program
{
    static void Main()
    {
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;

        double balance = 0;

        // Question #1:
        System.Console.WriteLine("Питання 1 (на 100 000 доларів): Скільки буде 2 + 2?");
        System.Console.WriteLine("a) 4");
        System.Console.WriteLine("b) 8");
        System.Console.WriteLine("c) 2");
        System.Console.WriteLine("d) 4");

        char answer = System.Convert.ToChar(System.Console.ReadLine());

        switch (answer)
        {
            case 'a':
            case 'A':
                balance += 10_000;
                System.Console.WriteLine($"Правильна відповідь! На вашому рахунку {balance} доларів!");

                // Question #2:
                System.Console.WriteLine("Питання 2 (на 900 000 доларів): Скільки планет є в сонячній системі?");
                System.Console.WriteLine("a) 7");
                System.Console.WriteLine("b) 8");
                System.Console.WriteLine("c) 9");
                System.Console.WriteLine("d) 10");

                answer = System.Convert.ToChar(System.Console.ReadLine());

                switch (answer)
                {
                    case 'b':
                    case 'B':
                        balance += 90_000;
                        System.Console.WriteLine($"Правильна відповідь! На вашому рахунку {balance} доларів!");

                        // Question #3:
                        System.Console.WriteLine("Питання 3 (на 9 000 000 доларів): Яка порода собак схожа на сосиску?");
                        System.Console.WriteLine("a) Бульдог");
                        System.Console.WriteLine("b) Мопс");
                        System.Console.WriteLine("c) Такса");
                        System.Console.WriteLine("d) Лабрадор");

                        answer = System.Convert.ToChar(System.Console.ReadLine());

                        switch (answer)
                        {
                            case 'c':
                            case 'C':
                                balance += 900_000;
                                System.Console.WriteLine("Правильна відповідь! Ви виграли мільйон!");
                                System.Console.WriteLine("Ваш баланс: $" + balance);
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
