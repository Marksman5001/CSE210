using System;
using System.Text.Json.Serialization;

public class Reference{
    private string _Book;
    private int _Chapter;
    private int _VerseStart;
    private int _VerseEnd;

    public Reference(){
        _Book="none";
        _Chapter=0;
        _VerseStart=0;
        _VerseEnd=0;
    }
    public Reference(string book, int chapter, int verse){
        this._Book=book;
        this._Chapter=chapter;
        this._VerseStart=verse;
        this._VerseEnd=verse;
    }
    public Reference(string book, int chapter, int versestart, int verseend){
        this._Book=book;
        this._Chapter=chapter;
        this._VerseStart=versestart;
        this._VerseEnd=verseend;
    }
    public string GetBook(){
        return _Book;
    }
    public int GetChapter(){
        return _Chapter;
    }
    public int GetStart(){
        return _VerseStart;
    }
    public int GetEnd(){
        return _VerseEnd;
    }
}