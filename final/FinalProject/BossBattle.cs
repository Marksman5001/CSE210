
class BossBattle : Event{
    public BossBattle() :base(){
        
    }


    protected override void SelectEvent()
    {
        Random rand = new Random();
        _ChosenEvent=_Eventtext.ElementAt(rand.Next(4)+16);
    }
}