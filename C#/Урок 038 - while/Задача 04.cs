﻿class Program
{
    static void Main()
    {
        System.Console.Write("Enter first number: ");
        int number1 = System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Enter second number: ");
        int number2 = System.Convert.ToInt32(System.Console.ReadLine());

        int number = number1;
        while (number <= number2)
        {
            System.Console.Write(number + " ");
            number++;
        }
    }
}