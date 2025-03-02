using System.Diagnostics;

/// <summary>
/// Listing Activity class, built off of Activity.
/// </summary>
class ListingActivity : Activity{

    private List<string> _Promptlist;

    public ListingActivity(string name = "Listing", string description="This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") : base (name, description){
        _Promptlist= new List<string>{
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        
    }

    /// <summary>
    /// Main activity of the Listing Activity class
    /// </summary>
    public void MainActivity(){
        DisplayStart();
        int inputs=0;
        long duration=_Duration-3;
        Random rand = new Random();
        System.Console.WriteLine(_Promptlist.ElementAt(rand.Next(_Promptlist.Count)));
        System.Console.WriteLine("\nThink about what you will list...");
        IdleAnimation(3);
        System.Console.WriteLine("Write as many answers as you can think of.");
        Stopwatch stopwatch = new Stopwatch();
        while(duration-3>0){
            stopwatch.Start();
            Console.ReadLine();
            inputs++;
            stopwatch.Stop();
            duration-=stopwatch.ElapsedMilliseconds/1000;
            if(stopwatch.ElapsedMilliseconds>1000){
            stopwatch.Reset();
            }
        }
        System.Console.WriteLine($"You listed {inputs} things.");
        DisplayEnd();
    }




}