using System;
using System.Drawing;
using System.Runtime.Remoting;
using System.Windows;

class Program
{
    static void Main(string[] args)
    {
        Enemy Guy = new Enemy(20, 5, 10);
        System.Console.WriteLine(Guy.Hp());
        Guy.TakeDamage(10);
        System.Console.WriteLine(Guy.Hp());
        Player Sir = new Player(50, 10, 10);
        Sir.DisplayStats();
        Sir.TakeDamage(10);
        Sir.DisplayStats();
        
    }
}