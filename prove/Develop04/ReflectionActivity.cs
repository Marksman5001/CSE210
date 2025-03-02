
/// <summary>
/// The Reflection activity built of off the base Activity class.
/// </summary>
class ReflectionActivity : Activity{
    private List<string> _Promptlist;
    private List<string> _Reflectlist;

    public ReflectionActivity(string name="Reflection", string description="This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") : base(name, description){
        _Promptlist=new List<string>(["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."] );
        _Reflectlist = new List<string>(["Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"]);
    }

    /// <summary>
    /// The main activity of the Reflection Activity, prints a series of statments walking through a reflection of an event.
    /// </summary>
    public void MainActivity(){
        DisplayStart();
        int duration = _Duration-3;
        Random rand = new Random();
        System.Console.WriteLine(_Promptlist.ElementAt(rand.Next(_Promptlist.Count)));
        IdleAnimation(2);
        while(duration-2>0){
            int i=0;
            System.Console.WriteLine(_Reflectlist.ElementAt(i));
            i++;
            IdleAnimation(5);
            duration-=5;
        }
        DisplayEnd();
    }

}