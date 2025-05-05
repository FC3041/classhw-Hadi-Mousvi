
public interface IShape
{
    public double Area();
    public double Perimeter();
}

public class Rectangle : IShape
{
    public double L;
    public double W;
    public Rectangle(double LL , double WW)
    {
        L = LL;
        W = WW;
    }

    public double Area()
    {
        return L*W;
    }

    public double Perimeter()
    {
        return 2*(L+W);
    }
}


public class Circle : IShape
{
    public double Radius;

    public Circle(double r)
    {
        Radius = r;
    }
    public double Area()
    {
        return Radius*Radius*3.14;
    }

    public double Perimeter()
    {
        return 2*Radius*3.14;
    }
}