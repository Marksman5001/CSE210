using System;

public class Player{
    private int hp;
    private int dps;
    private int speed;
    public Player(int playerhp, int playerdps, int playerspeed){
        this.hp=playerhp;
        this.dps=playerdps;
        this.speed=playerspeed;
    }
    public void TakeDamage(int damage){
        this.hp-=damage;
    }
    public void DisplayStats(){
        System.Console.WriteLine($"Health: {this.hp.ToString()}, Damage: {this.dps.ToString()}, Speed: {this.speed.ToString()}");
    }
    public int Hp(){
        return this.hp;
    }
    public int Dps(){
        return this.dps;
    }
    public int Speed(){
        return this.speed;
    }
    public void Update(){
        if(this.hp==0){
            this.dps=0;
            this.speed=0;
        }
    }
}