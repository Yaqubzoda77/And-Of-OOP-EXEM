public abstract class Shape
{
    protected string _color = "Red";
    protected Boolean _filled = true;
    public Shape()
    {

    }
    public Shape(string color, Boolean filled)
    {
        _color = color;
        _filled = filled;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public Boolean IsFille()
    {
        return _filled;
    }
    public void SetFilled(Boolean filled)
    {
        _filled = filled;
    }
    public abstract double GetArea();
    public abstract double GetPerrimetr();

    public override string ToString()
    {
        return ($"Shape color = {_color} {_filled}");
    }

}