using System;

class Running : Exercise
{
  public Running(string date, int minutes, double distance) : base(date, minutes)
  {
    _distance = distance;
    _speed = (_distance / _minutes) * 60;
    _pace = _minutes / _distance;
  }

  public override double GetDistance()
  {
    return _distance;
  }
  public override double GetSpeed() {
    return _speed;
  }
  public override double GetPace()
  {
    return _pace;
  }
  public override string GetSummary()
  {
    return $"{_date} Running ({_minutes} min)- Distance: {_distance}, Speed: {_speed}  kph, Pace: {_pace} min per km";
  }
}