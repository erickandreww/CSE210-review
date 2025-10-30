using System;
using System.Security.Cryptography.X509Certificates;

public class Job
{
  public string _company;
  public string _jobTitle;
  public int _startYear;
  public int _endYear;
  public List<Job> _jobs = new List<Job>();

  public void DisplayJobDetails()
  {
    Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
  }
}
