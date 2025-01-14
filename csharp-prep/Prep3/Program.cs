using System;
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int magicNumber= rand.Next(100);
        int guess=0;
        while(guess!=magicNumber){
            System.Console.Write("What is the magic number? ");
            guess=int.Parse(Console.ReadLine());
            if(guess<magicNumber){
                System.Console.WriteLine("Higher!");
            }
            if(guess>magicNumber){
                System.Console.WriteLine("Lower!");
            }
        }
        System.Console.WriteLine("You got it!");
    }
}