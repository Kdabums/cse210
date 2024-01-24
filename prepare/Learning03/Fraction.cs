public class Fraction
{
    private int _top;
    private int _bottom;
    /* Creates a new instance of Fraction with the top and bottom set to*/
    public Fraction()
    {
        _top =1;
        _bottom =1;
    }
    public Fraction (int tp)
    {
        _top =tp;
        _bottom =1;
    }
    public Fraction(int tpp,int btt)
    {
        _top =tpp;
        _bottom =btt;
    }
    public int getTop()
    {
        return _top;
    }
    public void setTop(int top)
    {
        _top =top;
    }
    public int getBottom()
    {
        return _bottom;
    }
    public void setBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }
}