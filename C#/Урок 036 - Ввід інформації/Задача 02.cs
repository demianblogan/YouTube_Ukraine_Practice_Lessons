﻿class Program
{
    static void Main()
    {
        const string ADMIN_LOGIN = "admin";
        const string ADMIN_PASSWORD = "111222";

        System.Console.Write("Enter login: ");
        string userLogin = System.Console.ReadLine();
        System.Console.Write("Enter password: ");
        string userPassword = System.Console.ReadLine();

        if (userLogin != ADMIN_LOGIN || userPassword != ADMIN_PASSWORD)
            System.Console.WriteLine("Login or Password is incorrect");
        else
            System.Console.WriteLine("You signed in");
    }
}