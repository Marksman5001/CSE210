using System;

class Program
{
    static void Main(string[] args)
    {
        List<Room> rooms;
        int menuinput=0;
        System.Console.WriteLine("Welcome! please select an option!");
        while(menuinput!=2){
            System.Console.WriteLine("1. Start new game\n2. Quit");
            menuinput=int.Parse(Console.ReadLine());
            Player player = new Player(50, 5);
            if(menuinput==1){
                
                for(int i=0; i<3; i++){
                    Level level = new Level(5);
                    rooms = new List<Room>(level.GetRooms());
                    foreach(Room room in rooms){
                        room.PlayEvent(player);
                    }
                    Thread.Sleep(1000);
                    System.Console.WriteLine("You've cleared this floor...");
                }
                System.Console.WriteLine("You've beat the game!");
                
            }
        }

    }
}