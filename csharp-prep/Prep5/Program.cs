using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome(){
            System.Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName(){
            System.Console.Write("Please enter your name: ");
            string name =Console.ReadLine();
            return name;
        }
        static int PromptUserNumber(){
            System.Console.Write("Please enter your number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquareNumber(int number){
            number=number*number;
            return number;
        }
        static void DisplayResults(string name, int number){
            System.Console.WriteLine($"{name}, the sqaure of your number is: {number.ToString()}");
        }
        try{
        DisplayWelcome();
        string name=PromptUserName();
        int number=PromptUserNumber();
        number=SquareNumber(number);
        DisplayResults(name, number);
        }
        catch{
            System.Console.WriteLine("An error occured with what you entered.");
        }
    }
}