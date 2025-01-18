class Program
{
    static void Main()
    {
        System.Console.WriteLine("Signing up...");

        System.Console.Write("Enter login: ");
        string registrationLogin = System.Console.ReadLine();
        System.Console.Write("Enter password: ");
        string registrationPassword = System.Console.ReadLine();

        System.Console.WriteLine("\nSigning in...");

        System.Console.Write("Enter login: ");
        string userLogin = System.Console.ReadLine();
        System.Console.Write("Enter password: ");
        string userPassword = System.Console.ReadLine();

        if (userLogin != registrationLogin || userPassword != registrationPassword)
            System.Console.WriteLine("Login or Password is incorrect");
        else
            System.Console.WriteLine("You signed in");
    }
}