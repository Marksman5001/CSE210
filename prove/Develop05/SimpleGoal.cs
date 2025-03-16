/// <summary>
/// simple goal, can be marked completed, and is essentially dead at that point.
/// </summary>
class SimpleGoal : Goal{
    private bool _Completed;

    public SimpleGoal(){
        _Completed=false;
    }
    
    public SimpleGoal(string name, string desc, int rewardtier, bool completed = false) :base(name, desc, rewardtier){
        _Completed=completed;
    }
    public override string GetInfo()
    {
        return base.GetInfo()+$"Completed:{_Completed}";
    }
    public override string Save()
    {
        return "Simple|"+base.Save()+$";{_Completed}/";
    }
    public override void Update(Player player){
        bool qualify=true;
        if(_Completed==true){
            qualify=false;
        }
        _Completed=true;
        if(qualify){
            List<int> reward = new List<int>(Reward());
            player.AddDamage(reward.ElementAt(1));
            player.AddHealth(reward.ElementAt(0));
        }
    }
}