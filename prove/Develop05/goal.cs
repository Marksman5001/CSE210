/// <summary>
/// A goal with specifications in a sting, a completed boolean, and a reward based on reward teir
/// </summary>
class Goal{
    private string _Name;
    private string _Description;
    private int _RewardTier;

    public Goal(){
        _Name="";
        _Description="blank goal";
        _RewardTier=0;
    }
    public Goal(string name, string desc, int rewardtier){
        _Name=name;
        _Description=desc;
        _RewardTier=rewardtier;
    }

    public virtual string GetInfo(){
        return $"{_Name}, {_Description}, Reward Tier:{_RewardTier} ";
    }
    public virtual void Update(Player player){

    }
    public List<int> Reward(){
        int health;
        int damage;
        if(_RewardTier<=0){
            health=2;
            damage=0;
            return new List<int> { health, damage };
        }
        else if(_RewardTier==1){
            health=5;
            damage=1;
            return new List<int> { health, damage };
        }
        else if(_RewardTier==2){
            health=10;
            damage=2;
            return new List<int> { health, damage };
        }
        else if(_RewardTier==3){
            health=15;
            damage=3;
            return new List<int> { health, damage };
        }
        else if (_RewardTier>3){
            health=_RewardTier*4+2;
            damage=_RewardTier-1;
            return new List<int> { health, damage };
        }
        else{
            return [0,0];
        }
    }
    public virtual string Save(){
        return $"{_Name};{_Description};{_RewardTier}";
    }
    public static void Load(string file, List<Goal> goallist){
        List<string> goals = new List<string>(file.Split("/"));
        int i=0;
        foreach(string goal in goals){
            List<string> typesplit=new List<string>(goals.ElementAt(i).Split("|"));
            if(typesplit.Count<2){
                break;
            }
            string type=typesplit.ElementAt(0);
            List<string> attributes = new List<string>(typesplit.ElementAt(1).Split(";"));
            if(type=="Checklist"){
                bool completed=false;
                if(attributes.ElementAt(5)=="True"){
                    completed=true;
                }
                ChecklistGoal checklistgoal=new ChecklistGoal(attributes.ElementAt(0), attributes.ElementAt(1), int.Parse(attributes.ElementAt(2)),  int.Parse(attributes.ElementAt(3)), int.Parse(attributes.ElementAt(4)),completed);
                goallist.Add(checklistgoal);
            }
            else if(type=="Simple"){
                bool completed = false;
                if(attributes.ElementAt(3)=="True"){
                    completed=true;
                }
                SimpleGoal goal1= new SimpleGoal(attributes.ElementAt(0), attributes.ElementAt(1), int.Parse(attributes.ElementAt(2)), completed);
                goallist.Add(goal1);
            }
            else if(type=="Eternal"){
                EternalGoal goal1 = new EternalGoal(attributes.ElementAt(0), attributes.ElementAt(1), int.Parse(attributes.ElementAt(2)), int.Parse(attributes.ElementAt(3)));
                goallist.Add(goal1);
            }
            i++;
        }
    }

}