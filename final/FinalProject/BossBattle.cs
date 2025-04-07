
class BossBattle : Event{
    public BossBattle() :base(){
        InitializeEvent();
    }


    protected override void SelectEvent()
    {
        System.Console.WriteLine("hi");
        Random rand = new Random();
        _ChosenEvent=_Eventtext.ElementAt(rand.Next(4)+16);
    }
}