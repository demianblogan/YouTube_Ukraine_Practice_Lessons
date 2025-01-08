/*
 * 13. Вернемося до того дебільного вентилятора з уроку про біти? Тримайте саму складну задачу :)
    Спитайте в користувача наступні речі:
    1. Чи включений вентилятор?
    2. Чи повертається вентилятор?
    3. З якою швидкістю крутиться вентилятор?

    Що має вводити користувач і що просити в нього вводити - вирішуйте самі.
    Головне не забувайте, що:
    1. стан включення вентилятору - це змінна типу bool.
    2. стан повороту вентилятору - це змінна типу bool.
    3. Швидкість вентилятора - це 1 (низька), 2 (середня), або 3 (висока).

    Проаналізуйте ці змінні і створіть змінну byte fanSettings і включіть у ній відповідні
    біти згідно тієї інформації, яку ввів користувач. Нагадую, що змінна типу byte має 8 бітів.
    Ваша задача:
    1. включити перший/самий правий біт, якщо вентилятор включений.
    2. включити другий біт, якщо вентилятор крутиться
    3. Встановити значення 1,2 чи 3 третьому і четвертому бітам.

    Все, біти встановлені, тепер перевіряйте кожний біт і виводьте на екран відповідну інформацію.
    Тобто якщо змінна має вигляд в двійковій системі числення:
    00000111 - вентилятор включений, повертається, швидкість низька
    00000000 - вентилятор виключений
    00000101 - вентилятор включений, не повертається, швидкість середня
    і так далі.

    Не розумієте, що я несу? Гляньте заново урок по бітовим операторам. Це якраз таки попередній урок.
 */
class Program
{
    static void Main()
    {
        bool isFanTurnedOn = false;
        bool isFanSpinning = false;
        byte fanSpeed = 0;

        System.Console.Write("Is the fan turned on? (1 - yes, 0 - no): ");
        isFanTurnedOn = System.Convert.ToBoolean(System.Console.ReadLine());
        if (isFanTurnedOn)
        {
            System.Console.Write("Is the fan spinning on? (1 - yes, 0 - no): ");
            isFanSpinning = System.Convert.ToBoolean(System.Console.ReadLine());
            if (isFanSpinning)
            {
                System.Console.Write("What is the fan's speed? (1 - low, 2 - normal, 3 - high): ");
                fanSpeed = System.Convert.ToByte(System.Console.ReadLine());
            }
        }

        byte fanSeetings = 0;

        if (isFanTurnedOn)
        {
            fanSeetings |= 0b_0000_0001;

            if (isFanSpinning)
            {
                fanSeetings |= 0b_0000_0010;

                if (fanSpeed != 0)
                    fanSeetings |= (byte)(fanSpeed << 2);
            }
        }

        if ((fanSeetings & 0b_0000_0001) == 0b_0000_0001)
        {
            System.Console.WriteLine("Fan is turned on.");

            if ((fanSeetings & 0b_0000_0010) == 0b_0000_0010)
            {
                System.Console.WriteLine("Fan is spinning.");

                switch (fanSeetings >> 2)
                {
                    case 1:
                        System.Console.WriteLine("Low speed");
                        break;
                    case 2:
                        System.Console.WriteLine("Normal speed");
                        break;
                    case 3:
                        System.Console.WriteLine("High speed");
                        break;
                }
            }
        }
    }
}
