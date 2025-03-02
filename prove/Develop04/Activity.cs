/// <summary>
/// The base Activity class to build off of. Takes the type of activity as a string called _Name, and the description as a string called _Description.
/// </summary>

class Activity{
    private string _Name;

    private string _Description;

    private DateTime _Starttime;

    protected int _Duration;
    
    public Activity(){

    }

    public Activity(string name, string description){
        _Name=name;
        _Description=description;
        _Starttime = DateTime.Now;
        _Duration=10;
    }
    /// <summary>
    /// Displays the start of an activity
    /// </summary>
    public void DisplayStart(){
        System.Console.WriteLine($"Wecome to the {_Name} Activity.");
        System.Console.WriteLine();
        System.Console.WriteLine(_Description);
        System.Console.Write("How long do you want the activity to last in seconds? -");
        _Duration=int.Parse(Console.ReadLine());
        if(_Duration<=10){
            _Duration=10;
        }
        System.Console.WriteLine("Please prepare to begin...");
        IdleAnimation(1);


    }

    /// <summary>
    /// Takes a double of seconds and sleeps while playing an animation for that amount of time
    /// </summary>
    public void IdleAnimation(double seconds){
        
        double sleeptime=(seconds*1000)/10;
        int rounded = (int)Math.Round(sleeptime, 0);
        for(int i=0;i<2;i++){
            System.Console.Write("|");
            Thread.Sleep(rounded);
            System.Console.Write("\b \b");
            System.Console.Write("/");
            Thread.Sleep(rounded);
            System.Console.Write("\b \b");
            System.Console.Write("-");
            Thread.Sleep(rounded);
            System.Console.Write("\b \b");
            System.Console.Write("\\");
            Thread.Sleep(rounded);
            System.Console.Write("\b \b");
            System.Console.Write("|");
            Thread.Sleep(rounded);
            System.Console.Write("\b \b");
        }
    }
    /// <summary>
    /// Displays the end of the activity
    /// </summary>
    public void DisplayEnd(){
        System.Console.WriteLine("Well Done!");
        IdleAnimation(2);
        System.Console.WriteLine($"You completed the {_Name} Activity.");
        int timeelapsed = (DateTime.Now.Minute*60+DateTime.Now.Hour*3600+DateTime.Now.Day*86400+DateTime.Now.Second)-(_Starttime.Minute*60+_Starttime.Hour*3600+_Starttime.Day*86400+_Starttime.Second);

        System.Console.WriteLine($"This Activity took {_Duration} seconds!");
    }


}
