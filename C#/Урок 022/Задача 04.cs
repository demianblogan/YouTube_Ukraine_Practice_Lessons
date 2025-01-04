class Program
{
    static void Main()
    {
        int catet1 = 10, catet2 = 12;
        int subExpression = catet1 * catet1 + catet2 * catet2;
        double diagonal = System.Math.Sqrt(subExpression);

        System.Console.WriteLine("Triangle's catets = " + catet1 + " and " + catet2);
        System.Console.WriteLine("Triangle's diagonal = " + diagonal);
    }
}