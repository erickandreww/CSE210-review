using System;

class Swimming : Exercise
{
  private double _lapsNumber;
  public Swimming(string date, int minutes, double lapsNumber) : base(date, minutes)
  {
    _lapsNumber = lapsNumber;
    _distance = _lapsNumber * 50 / 1000;
    _speed = (_distance / _minutes) * 60;
    _pace = 60 / _speed;
  }

  public override double GetDistance()
  {
    return _distance;
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
    return $"{_date} Swimming ({_minutes} min)- Distance: {_distance}, Speed: {_speed}  kph, Pace: {_pace} min per km";
  }
}