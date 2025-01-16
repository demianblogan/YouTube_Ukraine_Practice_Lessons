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
