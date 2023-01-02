public class Circle
{
    public double _radius;
    public double _pi = 3.14;
    public Circle()
    {

    }
    public Circle(double radius, double pi)
    {
        _radius = radius;
        _pi = pi;
    }
    public double GetRadius()
    {
        return _radius;

    }
    public void SetRadius(double radius)
    {
        _radius = radius;

    }
    public void GetArea()
    {
        System.Console.WriteLine(_radius * _radius * _pi);
    }
    public double GetCircumeFerence()
    {
        return 2 * _pi * _radius;

    }
    public string ToString()
    {
        return $"Circle[{_radius}]";
    }

}