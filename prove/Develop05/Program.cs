using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        System.Console.WriteLine("Welcome to GoalGame! Select an option!");
        int input=0;
        int saveinput=0;
        int gameinput=-1;
        List<Goal> goals=new List<Goal>();
        while(input!=5){
            List<string> saves=new List<string>(Directory.GetFiles("./Saves"));
            System.Console.WriteLine("1. Load\n2. Start Game\n3. Create new goals\n4. Complete goals\n5. Quit");
            input=int.Parse(Console.ReadLine());
            if (input==1){
                System.Console.WriteLine("Please choose a save.");
                int i =1;
                foreach(string save in saves){
                    
                    System.Console.WriteLine($"{i}: {save}");
                    i++;
                }
                i=1;
                saveinput=int.Parse(Console.ReadLine())-1;
                List<string> save1 = new List<string>(File.ReadAllText(saves.ElementAt(saveinput)).Split("-"));
                int health =int.Parse(save1.ElementAt(1).Split(";").ElementAt(0));
                int damage =int.Parse(save1.ElementAt(1).Split(";").ElementAt(1));
                player.AddDamage(damage);
                player.AddHealth(health);
                Goal.Load(File.ReadAllText(saves.ElementAt(saveinput)), goals);
                
                continue;
            }
            if(input==2){
                ///initialization of a new game would go here, but is not required for assignment, so it will be added later
                
            }
            if(input==3){
                int goalinput=-1;
                System.Console.WriteLine("type 0 to exit, or choose the goal type you want to make.");
                while(goalinput!=0){
                    System.Console.WriteLine("1. Simple\n2. Eternal\n3. Checklist");
                    goalinput=int.Parse(Console.ReadLine());
                    if(goalinput==0){
                        break;
                    }
                    System.Console.WriteLine("What is the name of the goal? ");
                    string name=Console.ReadLine();
                    System.Console.WriteLine("Add a description. ");
                    string desc= Console.ReadLine();
                    System.Console.WriteLine("Enter a number from 1-3 for the difficulty of the goal.");
                    int rewardtier=int.Parse(Console.ReadLine());
                    if(goalinput==1){
                        SimpleGoal goal = new SimpleGoal(name, desc, rewardtier);
                        goals.Add(goal);
                    }
                    else if(goalinput==2){
                        EternalGoal goal = new EternalGoal(name, desc, rewardtier);
                        goals.Add(goal);
                    }
                    else if(goalinput==3){
                        System.Console.WriteLine("How many times should this goal be completed? ");
                        int completions = int.Parse(Console.ReadLine());
                        ChecklistGoal goal = new ChecklistGoal(name, desc, rewardtier, 0, completions);
                        goals.Add(goal);
                    }
                }
                continue;
            }
            if(input==4){
                System.Console.WriteLine("Here are you goal, which one do you want to complete? ");
                int i=0;
                foreach(Goal goal in goals){
                    i++;
                    System.Console.WriteLine($"{i}: {goal.GetInfo()}");
                }
                int goalinput=int.Parse(Console.ReadLine());
                goals.ElementAt(goalinput-1).Update(player);
                continue;
            }
            if(input==5){
                Environment.Exit(0);
            }
            System.Console.WriteLine("Enjoy the game! At any time, type 0 to exit, or type 10 for save");
            gameinput=-1;
            while(gameinput!=0){
                //foreach(Goal goal in goals){
                    //System.Console.WriteLine(goal.GetInfo());
                //}
                System.Console.WriteLine($"Damage: {player.GetDamage()}, Health: {player.GetHealth()}");
                ///Game code would go here, not required for assignment, so it will be added later.
                gameinput=int.Parse(Console.ReadLine());
                if(gameinput==10){
                    string writestring="";
                    foreach(Goal goal in goals){
                        writestring+=goal.Save();
                    }
                    writestring+=$"-{player.GetHealth()};{player.GetDamage()}";
                    System.Console.WriteLine("Type the number of the file you want to overwrite, or type the name of a new file.");
                    int i=0;
                    foreach(string file in saves){
                        i++;
                        System.Console.WriteLine($"{i}: {file}");
                    }
                    string save=Console.ReadLine();
                    i=0;
                    bool written=false;
                    foreach(string file in saves){
                        i++;
                        if(save==$"{i}"){
                            File.WriteAllText(file, writestring);
                            written=true;
                        }
                    }
                    if(!written){
                        File.WriteAllText($"./Saves/{save}", writestring);
                    }
                }
            }
        }
    }
}