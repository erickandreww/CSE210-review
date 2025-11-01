using System;

abstract class Exercise
{
  protected string _date;
  protected int _minutes;
  protected double _distance;
  protected double _speed;
  protected double _pace;

  public Exercise()
  {
    _date = "Unknown";
    _minutes = 0;
  }

  public Exercise(string date, int minutes)
  {
    _date = date;
    _minutes = minutes;
  }

  public abstract double GetDistance();
  public abstract double GetSpeed();
  public abstract double GetPace();
  public abstract string GetSummary();
}