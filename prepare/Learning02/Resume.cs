using System;
public class Resume(){
    public string _name;
    public List<Job> _jobs = new List<Job>();
    public void display(){
        try{
            System.Console.Write($"{_name}: ");
            foreach(Job job in _jobs){
                job.display();
            }

        }
        catch{
            System.Console.WriteLine("Something went wrong");
        }

    }
}