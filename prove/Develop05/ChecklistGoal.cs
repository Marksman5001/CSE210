/// <summary>
/// goal that is completed multiple times before considered completed.
/// </summary>
class ChecklistGoal : Goal{
    private bool _Completed;
    private int _Progress;
    private int _Total;

    public ChecklistGoal() : base(){
        _Completed=false;
        _Progress=0;
        _Total=0;
    }

    public ChecklistGoal(string name, string desc, int rewardtier, int count, int total, bool completed = false) : base(name, desc, rewardtier){
        _Completed=completed;
        _Progress=count;
        _Total=total;
    }

    public override string GetInfo()
    {
        return base.GetInfo()+$"Number of completion: {_Progress}, Required completions: {_Total}, Completed: {_Completed}";
    }

    public  override void  Update(Player player){
        _Progress++;
        if(_Progress==_Total){
            _Completed=true;
            player.AddDamage(10);
            player.AddHealth(10);
        }
    }
    public override string Save()
    {
        return "Checklist|"+base.Save()+$";{_Progress};{_Total};{_Completed}/";
    }

}