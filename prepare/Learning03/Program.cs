using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3,4);
        Fraction fraction4 = new Fraction(1,3);
        System.Console.WriteLine($"{fraction1.GetFractionString()}, {fraction1.GetDecimalValue().ToString()}");
        System.Console.WriteLine($"{fraction2.GetFractionString()}, {fraction2.GetDecimalValue().ToString()}");
        System.Console.WriteLine($"{fraction3.GetFractionString()}, {fraction3.GetDecimalValue().ToString()}");
        System.Console.WriteLine($"{fraction4.GetFractionString()}, {fraction4.GetDecimalValue().ToString()}");
    }
}