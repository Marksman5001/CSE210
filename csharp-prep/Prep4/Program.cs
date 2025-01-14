using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int usernumber=1;
        System.Console.Write("Enter a list of numbers, type 0 when finished. ");
        while(usernumber!=0){
            try{
            usernumber=int.Parse(Console.ReadLine());
            }
            catch{
                System.Console.WriteLine("An error occured with what you entered.");
                Environment.Exit(0);
            }
            if(usernumber==0){
                break;
            }
            numbers.Add(usernumber);
        }
        System.Console.WriteLine($"The sum is: {numbers.Sum()}");
        System.Console.WriteLine($"The average is: {numbers.Average()}");
        System.Console.WriteLine($"The largest number is: {numbers.Max()}");
    }
}