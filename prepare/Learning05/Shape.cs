public abstract class Shape 
{
    protected string color;
    public virtual double GetArea()
    {
        return 5;
    }
    public Shape(string _color)
    {
        color = _color;
    }
    public string GetColor()
    {
        return color;
    }
    public void SetColor(string _color)
    {
        color = _color;
    }

}