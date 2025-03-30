
class Room{
    
    private Event _Event;
    private (int health, int damage, int money) _Effect;


    public Room(){
        _Event=new Event();
        _Effect=(_Event.GetHealthModifier(), _Event.GetDamageModifier(), _Event.GetMoneyModifier());
    }
    public (int,int,int) PlayEvent(){
        int playerinput=0;
        System.Console.WriteLine(_Event);
        playerinput=int.Parse(Console.ReadLine());
        
        System.Console.WriteLine();

        return _Effect;
    }



}