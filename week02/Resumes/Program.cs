using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2026;
        job1._endYear = 2030;

        Job job2 = new Job();
        job2._jobTitle = "Game Programmer";
        job2._company = "From Software";
        job2._startYear = 2031;
        job2._endYear = 2045;

        Resume myResume = new Resume();
        myResume._name = "Erick";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayJobs();
    }
    
}