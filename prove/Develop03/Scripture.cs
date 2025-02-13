using System;
using System.Text.Json.Serialization;

public class Scripture{
    private Reference _Reference;
    private List<Word> _Words;

    public Scripture(){
        _Reference=new Reference();
        _Words= new List<Word>();
    }

    public Scripture(Reference reference, List<Word> words){
        _Reference=reference;
        _Words=words;
    }
    public Reference GetReference(){
        return _Reference;
    }
    public List<Word> GetWords(){
        return _Words;
    }
}