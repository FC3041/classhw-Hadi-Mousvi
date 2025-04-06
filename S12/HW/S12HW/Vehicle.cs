
public interface Vparts
{
    public int wheels();
    public bool broken();
    public double occupied_space();
}

public class Automobile : Vparts
{
    public bool is_working;
    public double length;
    public double width;
    public double height;

    public Automobile(bool condition , double length1 , double width1 , double height1)
    {
        is_working = condition;
        length = length1;
        width = width1;
        height = height1;
    }

    public bool broken()
    {
        return is_working;
    }

    public double occupied_space()
    {
        return height*width*length;
    }

    public int wheels()
    {
        return 4;
    }
}

public class Bicycle : Vparts
{
    public bool is_working;
    public double length;
    public double width;
    public double height;

    public bool broken()
    {
        return is_working;
    }

    public double occupied_space()
    {
        return height*width*length;
    }

    public int wheels()
    {
        return 2;
    }
}