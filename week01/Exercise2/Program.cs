using System;

class Program
{
    static void Main(string[] args)
    {
        string gradeLetter;
        Console.Write("Please, insert your grade percentage (number): ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);

        if (grade >= 90)
        {
            gradeLetter = "A";
        }
        else if (grade >= 80)
        {
            gradeLetter = "B";
        }
        else if (grade >= 70)
        {
            gradeLetter = "C";
        }
        else if (grade >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }
        
        if (gradeLetter != "F"){
            if ((grade % 10) >= 7 && grade < 90)
            {
                gradeLetter += "+";
            }
            if ((grade % 10) < 3) {
                gradeLetter += "-";
            }
        }

        Console.WriteLine($"Your grade is {gradeLetter}");
        if (grade >= 70)
        {
            Console.WriteLine($"Congratulations, you passed!");
        } else
        {
            Console.WriteLine($"You do not passed, but please, try again!");
        }
    }
}