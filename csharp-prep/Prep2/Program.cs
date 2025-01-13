using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "f";
        System.Console.Write("What is the grade? ");
        int grade = int.Parse(Console.ReadLine());
        string gradeDigits =grade.ToString();
        char[] Digits = gradeDigits.ToCharArray();
        int secondDigit=int.Parse(Digits[1].ToString());
        string sign="";
        if(secondDigit<3){
            sign="-";
        }
        if(secondDigit>7){
            sign="+";
        }
        if(grade<60){
            letter="f";
            sign="";
        }
        if(grade<70&&grade>60){
            letter="D";
        }
        if(grade<80&&grade>70){
            letter="C";
        }
        if(grade<90&&grade>80){
            letter="B";
        }
        if(grade>90){
            letter="A";
            if(grade>93){
                sign="";
            }
        }
        System.Console.WriteLine($"You got a {letter}{sign}!");
        if(grade>=70){
            System.Console.WriteLine("You passed!");
        }
        
        

    }
}