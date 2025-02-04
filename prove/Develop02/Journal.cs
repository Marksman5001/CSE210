using System;
using System.Text.Json.Serialization;
public class Journal{
    public List<string> _PromptList { get; private set; }

    [JsonInclude]
    public List<Entry> _EntryList { get; set; }
    public Journal()
    {
        _EntryList = new List<Entry>();
        _PromptList = new List<string>
        {
            "How have you seen the hand of the Lord today? ",
            "What was the most interesting 10 minutes of today? ",
            "What is one thing from today that you want to work on tomorrow? ",
            "What were your impressions from scripture study today? ",
            "What did you do today that you are most proud of? "
        };
    }
    public Journal(List<Entry> entryList) : this()
    {
        _EntryList = entryList;
    }
    public string GetDisplay(){
        List<Entry> entrylist = this._EntryList;
        string display="";
        foreach(Entry entry in entrylist){
            
            display+=entry.GetDisplay();
        }
        return display;
    }
    public void CreateEntry(){
        Random rand = new Random();
        try{
        string date =DateTime.Now.ToString("M/d/yyyy");
        string prompt = _PromptList[rand.Next(-1, 5)];
        System.Console.Write($"Here is your prompt: {prompt}" );
        string response =System.Console.ReadLine(); 
        Entry entry= new Entry(prompt, date, response);
        this._EntryList.Add(entry);
        }
        catch(Exception ex){
            System.Console.WriteLine($"Something went wrong with that. {ex.Message}");
        }
    }
    public void RemoveEntry()
    {
        Console.Write("Which entry do you want to remove? (Enter a number starting from 1): ");
        try
        {
            int entryIndex = int.Parse(Console.ReadLine()) - 1;

            if (entryIndex >= 0 && entryIndex < _EntryList.Count)
            {
                _EntryList.RemoveAt(entryIndex);
                Console.WriteLine("Entry successfully removed.");
            }
            else
            {
                Console.WriteLine("Invalid entry number.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Something went wrong: {ex.Message}");
        }
    }
}