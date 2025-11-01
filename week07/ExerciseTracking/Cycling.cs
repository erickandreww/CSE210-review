using System;

class Cycling : Exercise
{
  public Cycling(string date, int minutes, double speed) : base(date, minutes)
  {
    _speed = speed;
    _pace = 60 / _speed;
    _distance = (_speed / 60) / _minutes;
  }

  public override double GetDistance()
  {
    return 0;
  }
  public override double GetSpeed() 
  {
    return _speed;
  }
  public override double GetPace()
  {
    return _pace;
  }
    public override string GetSummary()
  {
    return $"{_date} Cycling ({_minutes} min)- Distance: {_distance}, Speed: {_speed}  kph, Pace: {_pace} min per km";
  }
}