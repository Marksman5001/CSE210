
class Circle : Shape{
    private double _Radius;

    public Circle() :base("none"){
        _Radius=0;
    }

    public Circle(string color, double radius) : base(color){
        _Radius=radius;
    }

    public override double GetArea()
    {
        return _Radius*_Radius*Math.PI;
    }
}