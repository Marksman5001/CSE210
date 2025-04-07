
using System.Security.Cryptography.X509Certificates;

class Room{
    
    private Event _Event;
    private bool _Boss;


    public Room(){
        _Event=new Event();
        _Boss=false;
    }
    public Room(bool boss){
        _Boss=boss;
        if(_Boss){
            _Event=new BossBattle();
        }
        
    }
    public void PlayEvent(Player player){
        int playerinput=0;
        Thread.Sleep(1500);
        System.Console.WriteLine(_Event.GetBeginningText());
        if(_Event.GetEventType()==1){
            System.Console.WriteLine("What do you want to do?");
            playerinput=int.Parse(Console.ReadLine());
            if(_Event.GetNumber()==1){
                if(playerinput==1){
                    player.TakeDamage(2);
                    player.AddMoney(10);
                    System.Console.WriteLine(_Event.GetEndText().Split("\n").ElementAt(playerinput-1));
                }
                if(playerinput==2){
                    player.TakeDamage(5);
                    player.AddMoney(10);
                    System.Console.WriteLine(_Event.GetEndText().Split("\n").ElementAt(playerinput-1));
                }
                if(playerinput==3){
                    System.Console.WriteLine(_Event.GetEndText().Split("\n").ElementAt(playerinput-1));
                }
                return;
            }
            if(_Event.GetNumber()==2){
                if(playerinput==1){
                    player.TakeDamage(10);
                    System.Console.WriteLine(_Event.GetEndText().Split("\n").ElementAt(playerinput-1));
                }
                if(playerinput==2){
                    System.Console.WriteLine(_Event.GetEndText().Split("\n").ElementAt(playerinput-1));
                }
                if(playerinput==3){
                    player.TakeDamage(1);
                    System.Console.WriteLine(_Event.GetEndText().Split("\n").ElementAt(playerinput-1));
                }
                return;
            }
            if(_Event.GetNumber()==3){
                if(playerinput==1){
                    System.Console.WriteLine(_Event.GetEndText().Split("\n").ElementAt(playerinput-1));
                }
                if(playerinput==2){
                    player.TakeDamage(3);
                    System.Console.WriteLine(_Event.GetEndText().Split("\n").ElementAt(playerinput-1));
                }
                if(playerinput==3){
                    System.Console.WriteLine(_Event.GetEndText().Split("\n").ElementAt(playerinput-1));
                }
                return;
            }
            if(_Event.GetNumber()==4){
                if(playerinput==1){
                    player.TakeDamage(10);
                    System.Console.WriteLine(_Event.GetEndText().Split("\n").ElementAt(playerinput-1));
                }
                if(playerinput==2){
                    System.Console.WriteLine(_Event.GetEndText().Split("\n").ElementAt(playerinput-1));
                }
                if(playerinput==3){
                    System.Console.WriteLine(_Event.GetEndText().Split("\n").ElementAt(playerinput-1));
                }
                return;
            }
        }
        if(_Event.GetEventType()==2){
            if(_Event.GetNumber()==5){
                player.AddMoney(50);
                System.Console.WriteLine("You collect 50 gold!");
                return;
            }
            if(_Event.GetNumber()==6){
                while(player.GetHealth()<player.GetMaxHP()){
                    player.Heal();
                }
                System.Console.WriteLine("You feel refreshed and strengthened!");
                int damage = player.GetDamage()+3;
                player.SetDamage(damage);
                return;
            }
            if(_Event.GetNumber()==7){
                player.Unlock();
                player.AddMoney(25);
                System.Console.WriteLine("You collect 25 gold and learn to cast firebolt!");
                return;
            }
            if(_Event.GetNumber()==8){
                int damage = player.GetDamage()+7;
                player.SetDamage(damage);
                System.Console.WriteLine("Your damage is increased by 7!");
                return;
            }
        }
        if(_Event.GetEventType()==3){
            if(_Event.GetNumber()==9){
                Combat(25, 3, player);
                player.AddMoney(15);
                return;
            }
            if(_Event.GetNumber()==10){
                Combat(15, 10, player);
                player.AddMoney(50);
                return;
            }
            if(_Event.GetNumber()==11){
                Combat(50, 10, player);
                player.AddMoney(75);
                return;
            }
            if(_Event.GetNumber()==12){
                Combat(40, 5, player);
                player.AddMoney(10);
                return;
            }
        }
        if(_Event.GetEventType()==4){
            System.Console.WriteLine($"Your gold: {player.GetMoney()}");
            if(_Event.GetNumber()==13){
                System.Console.WriteLine("1. Pay 50 gold for +10 health and +5 damage\n2. Refuse and leave");
                playerinput=int.Parse(Console.ReadLine());
                if(playerinput==1){
                    if(player.GetMoney()>=50){
                        player.LoseMoney(50);
                        player.AddMaxHP(10);
                        player.SetHealth(player.GetHealth()+10);
                        player.SetDamage(player.GetDamage()+5);
                        return;
                    }
                    else{
                        System.Console.WriteLine("You don't have enough money for this.");
                        return;
                    }

                }
                else{
                    return;
                }
            }
            if(_Event.GetNumber()==14){
                System.Console.WriteLine("1. Pay 75 gold for +10 damage\n2. Refuse and leave");
                playerinput=int.Parse(Console.ReadLine());
                if(playerinput==1){
                    if(player.GetMoney()>=75){
                        player.LoseMoney(75);
                        player.SetDamage(player.GetDamage()+10);
                        return;
                    }
                    else{
                        System.Console.WriteLine("You don't have enough money for this.");
                        return;
                    }
                }
                else{
                    return;
                }
            }
            if(_Event.GetNumber()==15){
                System.Console.WriteLine("1. Pay 40 gold to unlock a spell\n2. Refuse and leave");
                playerinput=int.Parse(Console.ReadLine());
                if(playerinput==1){
                    if(player.GetMoney()>=40){
                        player.LoseMoney(40);
                        player.Unlock();
                        return;
                    }
                    else{
                        System.Console.WriteLine("You don't have enough money for this.");
                        return;
                    }
                }
                else{
                    return;
                }
            }
            if(_Event.GetNumber()==16){
                System.Console.WriteLine("1. Pay 60 gold for +5 health and +5 damage\n2. Refuse and leave");
                playerinput=int.Parse(Console.ReadLine());
                if(playerinput==1){
                    if(player.GetMoney()>=60){
                        player.LoseMoney(60);
                        player.AddMaxHP(5);
                        player.SetDamage(player.GetDamage()+5);
                        player.SetHealth(player.GetHealth()+5);
                        return;
                    }
                    else{
                        System.Console.WriteLine("You don't have enough money for this.");
                        return;
                    }
                }
                else{
                    return;
                }
            }
        }
        if(_Event.GetEventType()==5){
            if(_Event.GetNumber()==17){
                Combat(100, 10, player);
                player.AddMoney(100);
            }
            if(_Event.GetNumber()==18){
                Combat(75, 20, player);
                player.AddMoney(100);
            }
            if(_Event.GetNumber()==19){
                Combat(150, 10, player);
                player.AddMoney(150);
            }
            if(_Event.GetNumber()==20){
                Combat(95, 15, player);
                player.AddMoney(125);
            }

        }
        System.Console.WriteLine();
    
    }
    private void Combat(int health, int damage, Player player){
        bool incombat=true;
        string firebolt="???";
        if(player.GetUnlock()){
            firebolt="Cast Firebolt";
        }
        Enemy enemy = new Enemy(health, damage);
        int playerinput=0;
        while(incombat){
            System.Console.WriteLine($"Enemy hp: {enemy.GetHealth()}\nYour hp: {player.GetHealth()}");
            System.Console.WriteLine("What would you like to do?");
            System.Console.WriteLine($"1. Attack\n2. {firebolt}\n3. Heal");
            playerinput=int.Parse(Console.ReadLine());
            if(playerinput==1){
                System.Console.WriteLine($"You attack your foe, dealing {player.GetDamage()} damage!");
                Thread.Sleep(1000);
                enemy.TakeDamage(player.GetDamage());
            }
            if(playerinput==2 && player.GetUnlock()){
                System.Console.WriteLine($"Conjuring a firebolt in your palm, you launch it at your foe, dealing {player.Firebolt()} damage!");
                Thread.Sleep(1000);
                enemy.TakeDamage(player.Firebolt());
            }
            else if(playerinput==2 && !player.GetUnlock()){
                System.Console.WriteLine("You can't use this!");
                Thread.Sleep(1000);
                continue;
            }
            if(playerinput==3){
                System.Console.WriteLine($"Healing energy gathers, restoring {10+player.GetDamage()} hp!");
                Thread.Sleep(1000);
                player.Heal();
            }
            if(enemy.Dead()){
                System.Console.WriteLine("You deafeated your foe!");
                incombat=false;
                break;
            }
            Thread.Sleep(1000);
            System.Console.WriteLine($"The enemy strikes at you, dealing {enemy.GetDamage()} damage to you!");
            player.TakeDamage(enemy.GetDamage());
            if(player.GetHealth()<=0){
                System.Console.WriteLine("You are slain...");
                Environment.Exit(0);
            }
        }

    }
    }
