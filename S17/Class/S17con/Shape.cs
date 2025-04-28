using System.Drawing;

interface IShape
{
    // string Name;
}

class Vector
{
    public int x { get; set; }
    public int y { get; set; }
    public static Vector operator+(Vector v1 , Vector v2)
    {
        v1.x += v2.x;
        v1.y += v2.y;
        return v1;
    }

    public Vector(int X , int Y)
    {
        this.x = X;
        this.y = Y;
    }

    public override string ToString()
    {
        return $"[{x},{y}]";
    }
}

abstract class Shape 
{
    private string Name;
    protected Vector[] points; // because i want to use it in other drive classes, but we cant use it if its private. protected avoids outof class usage.

    public void Move(Vector d)
    {
        for(int i=0 ; i<points.Length ; i++)
            points[i] += d;
    }

    public void Draw()
    {
        Vector s = points[0];
        for(int i=1 ; i<points.Length ; i++)
        {
            Console.WriteLine($"line({points[i-1]} => {points[i]})");
        }
    }

    public abstract double GetArea(); // it doesnt have implementation in base class and it should be done in drive class
}

class Square : Shape
{
    public Square(Vector upperleft, int Len)
    {
        this.points = new Vector[4];
        this.points[0] = upperleft;
        this.points[1] = new Vector(upperleft.x + Len , upperleft.y);
        this.points[2] = new Vector(upperleft.x , upperleft.y + Len);
        this.points[3] = new Vector(upperleft.x  , upperleft.y);
    }
    public override double GetArea()
    {
        throw new NotImplementedException();
    }
}