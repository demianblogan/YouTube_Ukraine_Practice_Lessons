class Program
{
    static void Main()
    {
        // Create arrays:
        int[][] studentsGrades =
        {
            [8, 10, 11, 9],
            [12, 10],
            [11, 10, 11, 6],
            [5, 2, 1]
        };

        string[] studentsNames =
        {
            "Demian Blogan",
            "Olga Vasilchuk",
            "Helena Hlopek",
            "Nazar Rayko"
        };

        int[] studentsAverageGrades = new int[studentsGrades.Length];

        // Output main info:
        System.Console.WriteLine("--- Main information about students ---");
        for (int i = 0; i < studentsGrades.Length; i++)
        {
            System.Console.WriteLine(studentsNames[i] + ":");

            for (int j = 0; j < studentsGrades[i].Length; j++)
                System.Console.Write(studentsGrades[i][j] + " ");
            System.Console.WriteLine();
        }
        System.Console.WriteLine();

        // Calculate and output average grades:
        System.Console.WriteLine("--- Average grades ---");
        for (int i = 0; i < studentsGrades.Length; i++)
        {
            int gradesSum = 0;
            for (int j = 0; j < studentsGrades[i].Length; j++)
                gradesSum += studentsGrades[i][j];

            studentsAverageGrades[i] = gradesSum / studentsGrades[i].Length;

            System.Console.WriteLine($"{studentsNames[i]}'s average grade = {studentsAverageGrades[i]}");
        }

        // Search best and worst students:
        int bestStudentIndex = 0, worstStudentIndex = 0;
        for (int i = 1; i < studentsAverageGrades.Length; i++)
        {
            if (studentsAverageGrades[bestStudentIndex] < studentsAverageGrades[i])
                bestStudentIndex = i;

            if (studentsAverageGrades[worstStudentIndex] > studentsAverageGrades[i])
                worstStudentIndex = i;
        }

        System.Console.WriteLine();

        System.Console.WriteLine($"Worst student of the class is {studentsNames[worstStudentIndex]}");
        System.Console.WriteLine($"Best student of the class is {studentsNames[bestStudentIndex]}");
    }
}