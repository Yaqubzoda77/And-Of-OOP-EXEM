public class Circle : Shape
{
    private double _radius = 1.0;

    public Circle()
    {

    }
    public Circle(double radius)
    {
        _radius = radius;
    }
    public Circle(double radius, string color, Boolean filled) : base(color, filled)
    {
        _radius = radius;

    }
    public void SetRadius(double radius)
    {
        _radius = radius;

    }
    public override double GetArea()
    {
        return 3.14 * _radius * _radius;
    }
    public override double GetPerrimetr()
    {
        return 2 * 3.14 * _radius;
    }
    public override string ToString()
    {
        return ($"Circle color = {_color} {_filled} radius = {_radius}");

    }
}