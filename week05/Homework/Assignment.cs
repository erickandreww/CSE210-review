using System;

class Assignment
{
  protected string _studentName;
  protected string _topic;

  public Assignment()
  {
    _studentName = "Anonymous";
    _topic = "Unknow";
  }
  public Assignment(string student, string topic)
  {
    _studentName = student;
    _topic = topic;
  }

  public void GetSummary()
  {
    Console.WriteLine($"{_studentName} - {_topic}");
  }
}