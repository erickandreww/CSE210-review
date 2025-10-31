using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        assignment.GetSummary();

        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        math.GetSummary();
        math.GetHomeworkList();

        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        writing.GetSummary();
        writing.GetWritingInformation();
    }
}