using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignemnt mathAssignemnt = new MathAssignemnt("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(mathAssignemnt.GetSummary());
        System.Console.WriteLine(mathAssignemnt.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        System.Console.WriteLine(writingAssignment.GetSummary());
        System.Console.WriteLine(writingAssignment.GetWritingInfo());
    }
}