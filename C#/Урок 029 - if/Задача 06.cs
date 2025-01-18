class Program
{
    static void Main()
    {
        string userLogin = "admin";
        string userPassword = "admin111222";

        string adminLogin = "admin";
        string adminPassword = "admin111222";

        if (userLogin != adminLogin)
        {
            System.Console.WriteLine("Your login is incorrect");
        }
        else if (userPassword != adminPassword)
        {
            System.Console.WriteLine("Your password is incorrect");
        }
        else
        {
            System.Console.WriteLine("You have loggen in. Welcome, administrator");
        }
    }
}