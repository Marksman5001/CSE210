using System;
using System.Text;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;

public class Menu{
    public int Display(){
        System.Console.WriteLine("Welcome to your Journal!");
        System.Console.WriteLine("Please select from one of these options!");
        System.Console.WriteLine("1. Create an entry");
        System.Console.WriteLine("2. Remove an entry");
        System.Console.WriteLine("3. Display your journal");
        System.Console.WriteLine("4. Load a file");
        System.Console.WriteLine("5. Save your journal to a file");
        System.Console.WriteLine("6. Quit");
        int response = int.Parse(Console.ReadLine());
        return response;
    }
    public Journal Load(string filepath){
        if(!File.Exists(filepath)){
            System.Console.WriteLine("File does not exist.");
            return null;
        }
        try{
            string jsonstring = File.ReadAllText(filepath);
            Journal journal =JsonSerializer.Deserialize<Journal>(jsonstring);
            System.Console.WriteLine("Journal loaded successfully");
            return journal;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
            return null;
        }
    }
    public void Save(string filepath, Journal journal){
        try{
            string jsonstring =JsonSerializer.Serialize(journal, new JsonSerializerOptions {WriteIndented = true});
            File.WriteAllText(filepath, jsonstring);
            System.Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }
}