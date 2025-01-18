class Program
{
    enum Class
    {
        Human = 1,
        Ork = 2,
        Elf = 3
    }

    static void Main()
    {
        const int HUMAN_STRENGTH = 50;
        const int HUMAN_ENDURANCE = 60;
        const int HUMAN_HEALTH_POINTS = 70;

        const int ORK_STRENGTH = 90;
        const int ORK_ENDURANCE = 40;
        const int ORK_HEALTH_POINTS = 90;

        const int ELF_STRENGTH = 40;
        const int ELF_ENDURANCE = 95;
        const int ELF_HEALTH_POINTS = 40;

        System.Console.Write("Choose your class (1 - human, 2 - ork, 3 - elf): ");
        int userClassNumber = System.Convert.ToInt32(System.Console.ReadLine());

        if (userClassNumber >= 1 && userClassNumber <= 3)
        {
            Class userClass = (Class)userClassNumber;
            int userStrength = 0;
            int userEndurance = 0;
            int userHealthPoints = 0;

            switch (userClass)
            {
                case Class.Human:
                    userStrength = HUMAN_STRENGTH;
                    userEndurance = HUMAN_ENDURANCE;
                    userHealthPoints = HUMAN_HEALTH_POINTS;
                    break;

                case Class.Ork:
                    userStrength = ORK_STRENGTH;
                    userEndurance = ORK_ENDURANCE;
                    userHealthPoints = ORK_HEALTH_POINTS;
                    break;

                case Class.Elf:
                    userStrength = ELF_STRENGTH;
                    userEndurance = ELF_ENDURANCE;
                    userHealthPoints = ELF_HEALTH_POINTS;
                    break;
            }

            System.Console.WriteLine("--- YOUR CHARACTERISTICS ---");
            System.Console.Write("Class: ");
            switch (userClass)
            {
                case Class.Human:
                    System.Console.WriteLine("Human");
                    break;
                case Class.Ork:
                    System.Console.WriteLine("Ork");
                    break;
                case Class.Elf:
                    System.Console.WriteLine("Elf");
                    break;
            }
            System.Console.WriteLine("Strength:      " + userStrength);
            System.Console.WriteLine("Endurance:     " + userEndurance);
            System.Console.WriteLine("Health points: " + userHealthPoints);
        }
        else
        {
            System.Console.WriteLine("Incorrect number");
        }
    }
}