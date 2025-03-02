using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ListingActivity listingActivity = new ListingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        int input = 0;
        System.Console.WriteLine("Welcome to the Mindfulness Program! Please pick from the following options!");
        while(input!=4){
            System.Console.WriteLine("1: Breathing Activity. \n2: Listing Activity. \n3: Reflection Activity. \n4: Quit.");
            input=int.Parse(Console.ReadLine());
            if(input==1){
                breathingActivity.MainActivity();
            }
            else if(input==2){
                listingActivity.MainActivity();
            }
            else if(input==3){
                reflectionActivity.MainActivity();
            }
            
        }
    }
}