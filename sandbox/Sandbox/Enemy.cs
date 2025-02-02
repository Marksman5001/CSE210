using System;

public class Enemy{
    private int hp;
    private int dps;
    private int speed;
    public Enemy(int health, int damage, int movementspeed){
       this.hp = health;
       this.dps = damage;
       this.speed = movementspeed;
    }
    public void TakeDamage(int damage){
        this.hp=this.hp-damage;
    }
    public void Update(){
        if(this.hp<=0){
            this.speed=0;
            this.dps=0;
        }
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
    public void DisplayStats(){
        System.Console.WriteLine($"Health: {this.hp.ToString()}, Damage: {this.dps.ToString()}, Speed: {this.speed.ToString()}");
    }
    
}