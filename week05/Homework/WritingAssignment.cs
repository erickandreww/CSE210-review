using System;

class WritingAssignment : Assignment
{
  private string _title;

  public WritingAssignment() : base()
  {
    _title = "none";
  }
  public WritingAssignment(string student, string topic, string title) : base(student, topic)
  {
    _title = title;
  }

  public void GetWritingInformation()
  {
    Console.WriteLine($"{_title} by {_studentName}");
  }
}