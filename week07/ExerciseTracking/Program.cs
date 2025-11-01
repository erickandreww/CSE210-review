using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();

        Running running = new Running("01 Nov 2025", 30, 4.8);
        Cycling cycling = new Cycling("01 Nov 2025", 30, 9.7);
        Swimming swimming = new Swimming("01 Nov 2025", 30, 6.25);

        exercises.Add(running);
        exercises.Add(cycling);
        exercises.Add(swimming);

        foreach (Exercise exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}