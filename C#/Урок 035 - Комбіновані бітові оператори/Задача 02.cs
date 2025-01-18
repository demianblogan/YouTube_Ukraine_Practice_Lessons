class Program
{
    static void Main()
    {
        // Задачу 3 можна переписати з використанням комбінованих операторів:
        uint number = 213521;
        const int BITS_IN_UINT_TYPE = 32;
        number >>= (BITS_IN_UINT_TYPE - 1);
        number >>= 1;
        System.Console.WriteLine(number);

        // Задачу 4 можна переписати з використанням комбінованих операторів:
        byte num1 = 111, num2 = 89, num3 = 12, num4 = 2;
        uint key = 0;
        key |= (uint)(num1 << 24);
        key |= (uint)(num1 << 16);
        key |= (uint)(num1 << 8);
        key |= num4;
        System.Console.WriteLine(key);
    }
}