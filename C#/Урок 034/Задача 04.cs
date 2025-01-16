class Program
{
    static void Main()
    {
        byte num1 = 111, num2 = 89, num3 = 12, num4 = 2;
        uint key = 0;

        key = (uint)(key | (num1 << 24));
        key = (uint)(key | (num2 << 16));
        key = (uint)(key | (num3 << 8));
        key = key | num4;

        System.Console.WriteLine(key);
    }
}
