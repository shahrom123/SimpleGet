

public class Circle{
    private double _radius;
    private string _color;
    public Circle()
    {

    }
    public Circle(double radius)
    {
        _radius = radius;
    }
    public Circle (double radius, string color)
    {
        _radius = radius;
        _color = color;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetRadius(int radius)
    {
        _radius = radius;      
    }
    public void SetColor(string color)
    {
        _color = color;      
    }
    public string Tostring()
    {
        return " It is Cirlc... ";
    }
    public double GetArea()
    {
        return 2*(3.14*_radius*_radius);  
    }
}