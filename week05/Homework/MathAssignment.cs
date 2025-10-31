using System;

class MathAssignment : Assignment
{
  private string _textbookSection;
  private string _problems;

  public MathAssignment() : base()
  {
    _textbookSection = "empty";
    _problems = "none";
  }
  public MathAssignment(string student, string topic, string textbookSection, string problems) : base(student, topic)
  {
    _textbookSection = textbookSection;
    _problems = problems;
  }

  public void GetHomeworkList()
  {
    Console.WriteLine($"Section {_textbookSection} Problems {_problems}");
  }
}