using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();
        System.Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();
        System.Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
}