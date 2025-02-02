using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu= new Menu();
        int userinput = 10;
        Journal journal = new Journal(new List<Entry>());
        while(userinput!=6){
            userinput=menu.Display();
            if(userinput==1){
                journal.CreateEntry();
            }
            if(userinput==2){
                journal.RemoveEntry();
            }
            if(userinput==3){
                Console.WriteLine(journal.GetDisplay());
            }
            if(userinput==4){
                System.Console.Write("What is the path of the file you want to load? ");
                string filepath= Console.ReadLine();
                if(menu.Load(filepath)!=null){
                    journal=menu.Load(filepath);
                }
            }
            if(userinput==5){
                System.Console.Write("What is the path of where you want to save the file?");
                string filepath = Console.ReadLine();
                menu.Save(filepath, journal);
            }
        }
        System.Console.WriteLine("Goodbye!");
    }
}