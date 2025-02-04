using System;

public class Fraction{
    private int _Topnumber;
    private int _Bottomnumber;
    public Fraction(){
        this._Bottomnumber=1;
        this._Topnumber=1;
    }
    public Fraction(int topnumber){
        this._Bottomnumber=1;
        this._Topnumber=topnumber;
    }
    public Fraction(int topnumber, int bottomnumber){
        this._Bottomnumber=bottomnumber;
        this._Topnumber=topnumber;
    }
    
    public int GetTopNumber(){
        return this._Topnumber;
    }
    public int GetBottomNumber(){
        return this._Bottomnumber;
    }

    public string GetFractionString(){
        
        return$"{this._Topnumber.ToString()}/{this._Bottomnumber.ToString()}";
    }
    public double GetDecimalValue(){
        return (double)this._Topnumber/(double)this._Bottomnumber;
    }

}