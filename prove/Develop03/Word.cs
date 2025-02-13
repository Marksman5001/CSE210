using System;
using System.Text.Json.Serialization;
public class Word{
    
    private string _Text;
    private bool _IsHidden;

    public Word(){
        _Text="";
        _IsHidden=false;
    }
    public Word(string text){
        _Text=text;
        _IsHidden=false;
    }
    public void Hide(){
        if(!_IsHidden){
            _Text = new string('-', _Text.Length);
            _IsHidden=true;
        }
    }
    public String GetText(){
        return _Text;
    }
    public bool IsHidden(){
        return _IsHidden;
    }

}