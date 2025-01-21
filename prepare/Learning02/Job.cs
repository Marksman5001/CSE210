using System;
public class Job(){
    public string _jobtitle;
    public string _company;
    public int _startyear;
    public int _endyear;
    public void display(){
        try{
            System.Console.WriteLine($"{_company}, {_jobtitle}, {_startyear}, {_endyear};");
        }
        catch{
            System.Console.WriteLine("Something went wrong");
        }
    }
}