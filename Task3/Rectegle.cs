public class Rectegle : Shape
{
    protected double _width = 1.0;
    protected double _length = 1.0;
    public Rectegle()
    {

    }
    public Rectegle(double width, double length)
    {
        _width = width;
        _length = length;
    }
    public Rectegle(double width, double length, string color, bool filled) : base(color, filled)
    {
        _width = width;
        _length = length;
    }
    public double GetWidth()
    {
        return _width;
    }
    public void SetWidth(double width)
    {
        _width = width;

    }
    public double GetLength()
    {
        return _length;
    }
    public void SetLength(double length)
    {
        _length = length;

    }
    public override double GetArea()
    {
        return _width * _length;
    }
    public override double GetPerrimetr()
    {
        return 2 * _length * _width;
    }
    public override string ToString()
    {
        return ($"Shape color = {_color} {_filled} radius = {_width} {_length}");
    }

}