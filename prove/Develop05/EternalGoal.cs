/// <summary>
/// Eternal goals, spiritual in nature, cannot be completed, but holds the number of completions instead
/// </summary>
class EternalGoal : Goal{
    private int _Completions;

    public EternalGoal(){
        _Completions=0;
    }

    public EternalGoal(string name, string desc, int rewardtier, int completions = 0) : base(name, desc, rewardtier){
        _Completions=completions;
    }

    public override string GetInfo()
    {
        return base.GetInfo()+$"Completions:{_Completions}";
    }

    public override void Update(Player player){
        _Completions++;
        List<int> reward = new List<int>(Reward());
        player.AddDamage(reward.ElementAt(1));
        player.AddHealth(reward.ElementAt(0));
    }

    public string GetCompletions(){
        return $"{_Completions}";
    }
    public override string Save()
    {
        return "Eternal|"+base.Save()+$";{_Completions}/";
    }
}