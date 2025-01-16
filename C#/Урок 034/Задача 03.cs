class Program
{
    static void Main()
    {
        uint number = 213521;

        const int BITS_IN_UINT_TYPE = 32;

        // I can't write "number = number >> BITS_IN_UINT_TYPE" because the C# language
        // specification states that the shift count is reduced modulo the bit width of
        // the type. For a uint, this is 32, so shifting by 32 % 32 results in a shift
        // count of 0. Thus, the value of number remains unchanged.

        number = number >> (BITS_IN_UINT_TYPE - 1);
        number = number >> 1;

        System.Console.WriteLine(number);
    }
}
