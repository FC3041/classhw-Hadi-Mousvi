using System.Numerics;

public class ComplexNumber
{
    public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b) 
    {
        return new ComplexNumber(a.Re + b.Re , b.Im + a.Im);
    }
    public double Re;
    public double Im;
    public ComplexNumber(double r, double i)
    {
        this.Re = r;
        this.Im = i; 
    }
    public void PrintCN()
    {
        System.Console.WriteLine($"{this.Re}+{this.Im}i");
    }

    public double this[int index] //Indexer
    {
        get
        {
            if(index == 0)
                return this.Re;
            else if(index == 1)
                return this.Im;
            else 
                throw new IndexOutOfRangeException("index out of range!");
        }

        set
        {
            if(index == 0)
                this.Re = value;
            else if(index == 1)
                this.Im = value;
            else 
                throw new IndexOutOfRangeException("index out of range!");
        }
    }

    public double this[bool b] // Indexer
    {
        get
        {
            if(b==true)
                return this.Re;
            else
                return this.Im;
        }

        set
        {
            if(b==true)
                this.Re=value;
            else
                this.Im = value;
        }
    }

    // public static explicit operator double(ComplexNumber x)
    // {
    //     return x.Re;
    // }
    public static implicit operator double(ComplexNumber x)
    {
        return x.Re;
    }
    public static implicit operator ComplexNumber(double x)
    {
        return new ComplexNumber(x,x);
    }



}