using System.Reflection.Metadata;

public class MyVector : IEquatable<MyVector>
{
    public MyVector(int x , int y)
    {
        this.X = X;
        this.Y = Y;
    }
    public int X {get; set;}
    public int Y {get; set;}
    public double Magnitude => Math.Sqrt(X*X + Y*Y);
    public MyVector SumOfVectors(MyVector v)
    {
        int SumX = this.X + v.X;
        int SumY = this.Y + v.Y;
        return new MyVector(SumX , SumY);
    }
    
    public static MyVector Parse(string s)
    {
        string[] tokens = s.Split(',');
        return new MyVector(int.Parse(tokens[0]) , int.Parse(tokens[1]));
    }

    public bool Equals(MyVector? v)
    {
        if(null == v)
            return false;
        return (v.X == this.X) && (v.Y  == this.Y);
    }
}