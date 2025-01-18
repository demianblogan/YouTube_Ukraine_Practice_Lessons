class Program
{
    static void Main()
    {
        int variable = 10;
        const double CONSTANT = 20.5;

        System.Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(variable));
        System.Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(CONSTANT));
        System.Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf('g'));
    }
}