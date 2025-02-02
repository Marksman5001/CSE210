using System;
using System.Text.Json.Serialization;

public class Entry{
    [JsonInclude]
    public string  _promptName{get; set;}
    [JsonInclude]
    public string _dateOfEntry{get; set;}
    [JsonInclude]
    public string _response{get; set;}

    public Entry(){}
    public Entry(string nameofentry, string entrydate, string userresponse){
        this._promptName=nameofentry;
        this._dateOfEntry=entrydate;
        this._response=userresponse;
    }
    public string GetDisplay(){
        string display = $"{_dateOfEntry}, {_promptName}, \n{_response};\n";
        return display;
    }
}