
public class Square : Rectegle
{
    private double _side = 1.0;

    public Square()
    {

    }
    public Square(double side)
    {
        _side = side;
    }
    public Square(double side, string color, Boolean filled)
    {
        _side = side;
        _color = color;
        _filled = filled;

    }
    public double GetRadius()
    {
        return _side;
    }
    public double GetSide()
    {
        return _side;

    }
    public void SetSide(double side)
    {
        _side = side;

    }

    public override double GetPerrimetr()
    {
        return 4 * _side;
    }
    public override double GetArea()
    {
        return _side * _side;
    }

    public override string ToString()
    {
        return ($"Shape color = {_color} {_filled} side ={_side}");
    }
}