
public class Shape{
    private string _Color;

    public Shape(){
        _Color="none";
    }
    public Shape(string color){
        _Color=color;
    }

    public string GetColor(){
        return _Color;
    }
    public void SetColor(string color){
        _Color=color;
    }

    public virtual double GetArea(){
        return 0;
    }

}