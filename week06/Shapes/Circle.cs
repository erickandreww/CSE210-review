using System;

class Cicle : Shape
{
    protected double _radius;

    public Cicle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}