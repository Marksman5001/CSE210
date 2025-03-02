/// <summary>
/// Breathing activity class.
/// </summary>
class BreathingActivity : Activity{


    public BreathingActivity(string name="Breathing Activity", string description="This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") : base(name, description){
        
    }

    /// <summary>
    /// The main activity of Breathing Activity, prints a breathing excersize to the console for the duration specified by the startdisplay functio in activity.
    /// </summary>
    public void MainActivity(){
        DisplayStart();
        int duration = _Duration-3;
        while(duration>0){
            System.Console.WriteLine("Breathe in...");
            IdleAnimation(2);
            System.Console.WriteLine("Breathe out...");
            IdleAnimation(2);
            duration-=4;
        }
        DisplayEnd();
    }

}