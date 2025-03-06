using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeslist = new List<Shape>();
        shapeslist.Add(new Square("black", 5));
        shapeslist.Add(new Circle("red", 5));
        shapeslist.Add(new Rectangle("blue", 6, 10));
        foreach(Shape shape in shapeslist){
            System.Console.WriteLine($"color: {shape.GetColor()}, area: {shape.GetArea()}");
        }
    }
}