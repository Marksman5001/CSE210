using System;
class Program
{
    static void Main(string[] args)
    {
        
        Random rand = new Random();
        int magicNumber= rand.Next(100);
        int guess=0;
        System.Console.Write("What is the magic number? ");
        while(guess!=magicNumber){
            
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