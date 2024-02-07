using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment assignment = new Assignment(" Godstime Erubami", "Math108X");
        // Console.WriteLine(assignment.GetSummary());
        MathAssignment mathAssignment = new MathAssignment(" Godstime Erubami", "Math108X", "section 7.3", "problem 8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeWorkList());
        Console.WriteLine(" ");
        WrittingAssignment writtingAssignment = new WrittingAssignment( "Matt Damon", "Novel", "Good people die young");
        Console.WriteLine(writtingAssignment.GetSummary());
        Console.WriteLine(writtingAssignment.GetWrittingInformation());
    }
}